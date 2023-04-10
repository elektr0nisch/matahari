using System.Net;
using System.Net.Sockets;

namespace Matahari
{
    public class MatahariServer
    {
        private static Socket? serverSocket;

        private static readonly List<MatahariClient> clients = new();
        private static readonly Dictionary<Form, Action> listeners = new();

        [STAThread]
        static void Main()
        {
            // Start the server socket
            Task.Run(() => RunServer());

            // Start UI update timer
            System.Timers.Timer timer = new();
            timer.Elapsed += (obj, args) => CallUpdateListeners();
            timer.Interval = 1000;
            timer.Start();

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
        }

        public static void RemoveClient(MatahariClient client)
        {
            clients.Remove(client);
        }

        public static List<MatahariClient> GetClients()
        {
            return clients;
        }

        public static void AddUpdateListener(Form form, Action callback)
        {
            listeners.Add(form, callback);
        }

        public static void RemoveUpdateListener(Form form)
        {
            listeners.Remove(form);
        }

        private static void CallUpdateListeners()
        {
            foreach (var listener in listeners.Values)
            {
                listener();
            }
        }
    }
}