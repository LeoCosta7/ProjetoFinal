using ConnectMeServer;
using ConnectMeServer.Util;
using Grpc.Core;

namespace ConnectMeServer.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        public static Dictionary<string, string> ClientsQueue = new Dictionary<string, string>();
        private static Dictionary<string, IServerStreamWriter<ResponseClientConnect>> connectMeClients = new Dictionary<string, IServerStreamWriter<ResponseClientConnect>>();
        private static Dictionary<string, IServerStreamWriter<ResponseClientConnect>> disconnectMeClients = new Dictionary<string, IServerStreamWriter<ResponseClientConnect>>();


        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override async Task ConnectClient(IAsyncStreamReader<RequestClientConnect> request, IServerStreamWriter<ResponseClientConnect> responseStream, ServerCallContext context)
        {
            string queueName = null;

            try
            {
                await foreach (var msg in request.ReadAllAsync())
                {
                    //Cria fila pela primeira vez
                    if (!string.IsNullOrEmpty(msg.ClientName) && !ClientsQueue.ContainsKey(msg.ClientName))
                    {
                        queueName = RabbitMQManager.CreateQueue();
                        ClientsQueue[msg.ClientName] = queueName;
                        connectMeClients[msg.ClientName] = responseStream;
                    }

                    //Estando off, envia para o servidor de mensagens
                    if (connectMeClients.TryGetValue(msg.ClientToSend, out var recipientStreamObject))
                    {
                        if (recipientStreamObject is IServerStreamWriter<ResponseClientConnect> recipientStreamForChat)
                            await recipientStreamForChat.WriteAsync(new ResponseClientConnect { Message = msg.Message });
                    }
                    else if (disconnectMeClients.ContainsKey(msg.ClientToSend) && ClientsQueue.ContainsKey(msg.ClientToSend))       //Verifica se está na lista de desconectados e se existe uma fila para ele
                    {
                        ClientsQueue.TryGetValue(msg.ClientToSend, out var queueNameObject);
                        RabbitMQManager.SendMessage(queueNameObject, msg.Message);
                    }
                }
            }
            catch
            {
                RabbitMQManager.DeleteQueue(queueName);
            }
        }

        public override async Task handleConnection(IAsyncStreamReader<RequestConnection> request, IServerStreamWriter<ResponseConnection> responseStream, ServerCallContext context)
        {
            string messages = "";

            try
            {
                await foreach (var msg in request.ReadAllAsync())
                {
                    if (msg.Status)
                        EnableClient(msg.ClientName, connectMeClients, disconnectMeClients);
                    else
                        DisableClient(msg.ClientName, disconnectMeClients, connectMeClients);

                    if (msg.Status)
                        messages = GetMessagesFromRabbitByClientName(msg.ClientName);

                    await responseStream.WriteAsync(new ResponseConnection { Message = messages });
                }
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }

        private string GetMessagesFromRabbitByClientName(string clientName)
        {
            ClientsQueue.TryGetValue(clientName, out var QueueName);

            return RabbitMQManager.ConsumerMessages(QueueName);
        }

        private void EnableClient(
            string clientName,
            Dictionary<string, IServerStreamWriter<ResponseClientConnect>> connectClients,
            Dictionary<string, IServerStreamWriter<ResponseClientConnect>> disconnectClients)
        {
            string msg = null;

            foreach (var item in disconnectClients)
            {
                if (item.Key == clientName)
                {
                    connectClients.Add(item.Key, item.Value);
                    disconnectClients.Remove(item.Key);
                }
            }
        }

        private void HandleClientState(
            string clientName, bool status,
            Dictionary<string, IServerStreamWriter<ResponseClientConnect>> disconnectClients,
            Dictionary<string, IServerStreamWriter<ResponseClientConnect>> connectClients)
        {
            var sourceDictionary = status ? disconnectClients : connectClients;
            var targetDictionary = status ? connectClients : disconnectClients;

            var client = sourceDictionary.FirstOrDefault(item => item.Key == clientName);

            if (client.Key != null)
            {
                targetDictionary.Add(client.Key, client.Value);
                sourceDictionary.Remove(client.Key);
            }
        }

        private void DisableClient(
            string clientName,
            Dictionary<string, IServerStreamWriter<ResponseClientConnect>> disconnectClients,
            Dictionary<string, IServerStreamWriter<ResponseClientConnect>> connectClients)
        {
            string msg = null;

            foreach (var item in connectClients)
            {
                if (item.Key == clientName)
                {
                    disconnectClients.Add(item.Key, item.Value);
                    connectClients.Remove(item.Key);
                }
            }
        }
    }
}