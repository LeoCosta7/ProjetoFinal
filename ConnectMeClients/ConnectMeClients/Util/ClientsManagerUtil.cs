using ClientMe;
using Grpc.Core;
using Grpc.Net.Client;
using System.Net;


namespace ConnectMeClients.Util
{
    public class ClientsManagerUtil
    {
        private static GrpcChannel channel;
        private static Greeter.GreeterClient client;


        private static AsyncDuplexStreamingCall<RequestClient, ResponseClient> streamingCall;
        private static IAsyncStreamWriter<RequestClient> requestStream;
        private static IAsyncStreamReader<ResponseClient> responseStream;

        private static AsyncDuplexStreamingCall<RequestConnection, ResponseConnection> streamingConnectionCall;
        private static IAsyncStreamWriter<RequestConnection> requestConnectionStream;
        private static IAsyncStreamReader<ResponseConnection> responseConnectionStream;

        public async Task InitializeGrpcConnection()
        {
            try
            {
                channel = GrpcChannel.ForAddress("https://localhost:7069");
                client = new Greeter.GreeterClient(channel);

                streamingCall = client.ConnectClient();
                requestStream = streamingCall.RequestStream;
                responseStream = streamingCall.ResponseStream;

                streamingConnectionCall = client.handleConnection();
                requestConnectionStream = streamingConnectionCall.RequestStream;
                responseConnectionStream = streamingConnectionCall.ResponseStream;
            }
            catch
            {
                MessageBox.Show("Server startup error. Please check and retry");
            }
        }

        public async Task RequestClient(RequestClient RequestClientConnect, FormClient formClient)
        {
            try
            {
                await requestStream.WriteAsync(RequestClientConnect);
                
                Task.Run(async () =>
                {
                    await foreach (var message in responseStream.ReadAllAsync())
                    {
                        formClient.Invoke((Action)(() =>
                        {
                            formClient.ChatTextBox.Text += $"{formClient.txtClientRecipient.Text}: {message.Message}\r\n";
                        }));
                    }
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task HandleConnection(RequestConnection requestConnection, FormClient formClient)
        {
            try
            {
                await requestConnectionStream.WriteAsync(requestConnection);

                Task.Run(async () =>
                {
                    await foreach (var message in responseConnectionStream.ReadAllAsync())
                    {
                        string[] fullmsg = message.Message.Replace("//", " ").Trim().Split();

                        foreach (string msg in fullmsg)
                        {
                            formClient.Invoke((Action)(() =>
                            {
                                formClient.ChatTextBox.Text += $"{formClient.txtClientRecipient.Text}: {msg}\r\n";
                            }));
                        }                        
                    }
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    
}
