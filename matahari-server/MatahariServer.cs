using System.Net;
using System.Net.Sockets;

namespace Matahari
{
    public class MatahariServer
    {
        private static Socket? serverSocket;

        private static readonly List<MatahariClient> clients = new();
        private static readonly List<Action> listeners = new();

        [STAThread]
        static void Main()
        {
            // Start the server socket
            Task.Run(() => RunServer());

            ApplicationConfiguration.Initialize();
            Application.Run(new ServerForm());
        }

        private static void RunServer()
        {
            IPAddress address = IPAddress.Parse("0.0.0.0");
            IPEndPoint endPoint = new(address, 1337);

            serverSocket = new(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                serverSocket.Bind(endPoint);
                serverSocket.Listen(1000);

                while (true)
                {
                    Socket clientSocket = serverSocket.Accept();
                    MatahariClient client = new(clientSocket);

                    AddClient(client);
                }
            } catch (Exception)
            {
                Console.WriteLine();
            }
        }

        public static void AddClient(MatahariClient client)
        {
            clients.Add(client);
            CallUpdateListeners();
        }

        public static void RemoveClient(MatahariClient client)
        {
            clients.Remove(client);
            CallUpdateListeners();
        }

        public static List<MatahariClient> GetClients()
        {
            return clients;
        }

        public static void RegisterUpdateListener(Action callback)
        {
            listeners.Add(callback);
        }

        public static void CallUpdateListeners()
        {
            listeners.ForEach(callback => callback());
        }
    }
}