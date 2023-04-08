using System.Net.Sockets;

namespace Matahari
{
    public class MatahariClient
    {
        public Socket Socket { get; }
        public string MachineName { get; private set; }
        public Bitmap? Screenshot { get; private set; }

        public MatahariClient(Socket socket)
        {
            this.Socket = socket;
            this.MachineName = "n/a";

            Task.Run(() => StartListening());
        }

        private void StartListening()
        {
            NetworkStream networkStream = new(Socket, true);

            while (Socket.Connected)
            {
                try
                {
                    Packet packet = PacketUtility.ReadPacket(networkStream);
                    if (packet != null)
                    {
                        HandlePacket(packet);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            // Remove from clients on connection loss
            MatahariServer.RemoveClient(this);
        }

        private void HandlePacket(Packet packet)
        {
            if (packet is LoginPacket loginPacket)
            {
                MachineName = loginPacket.MachineName;
                MatahariServer.CallUpdateListeners();
            }
            else if (packet is HeartbeatPacket heartbeatPacket)
            {
                Screenshot = heartbeatPacket.Screenshot;
                MatahariServer.CallUpdateListeners();
            }
        }
    }
}
