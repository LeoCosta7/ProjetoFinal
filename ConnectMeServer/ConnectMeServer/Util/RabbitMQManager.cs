using RabbitMQ.Client;
using System.Text;

namespace ConnectMeServer.Util
{
    public class RabbitMQManager
    {
        private static IModel channel;

        public static IModel GetChannel()
        {
            if (channel == null || channel.IsClosed)
            {
                var factory = new ConnectionFactory
                {
                    HostName = "localhost"
                };

                IConnection connection = factory.CreateConnection();
                channel = connection.CreateModel();
            }

            return channel;
        }

        public static string CreateQueue()
        {
            try
            {
                string queueName = Guid.NewGuid().ToString();
                GetChannel().QueueDeclare(queueName, true, false, false, null);

                return queueName;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void SendMessage(string queueName, string message)
        {
            byte[] body = Encoding.UTF8.GetBytes(message);

            GetChannel().BasicPublish("", queueName, null, body);
        }

        public static string ConsumerMessages(string queueName)
        {
            StringBuilder concatenatedMessages = new StringBuilder();

            IModel channel = GetChannel();

            while (true)
            {
                BasicGetResult result = channel.BasicGet(queueName, true);

                if (result == null)
                    break;

                string message = Encoding.UTF8.GetString(result.Body.ToArray());
                concatenatedMessages.Append(message).Append("//");
            }

            return concatenatedMessages.ToString().Trim();
        }

        internal static void DeleteQueue(string queueName)
        {
            GetChannel().QueueDelete(queueName);
        }
    }
}
