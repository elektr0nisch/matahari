using System.Net.Sockets;

namespace Matahari
{
    public class MatahariClient
    {
        public Socket Socket { get; }

        public NetworkStream Stream { get; }

        public string MachineName { get; private set; }

        public HeartbeatPacket? LastHeartbeat { get; private set; }

        public DateTime ConnectedSince { get; }

        public bool Connected { get; private set; }

        private readonly Queue<Packet> packetQueue = new Queue<Packet>();

        public MatahariClient(Socket socket)
        {
            Socket = socket;
            Stream = new NetworkStream(socket, true);
            MachineName = "n/a";
            ConnectedSince = DateTime.Now;
            Connected = true;

            Task.Run(() => StartListening());
            Task.Run(() => StartSendQueue());
        }

        private void StartListening()
        {
            // Read incoming packets while connected
            while (Socket.Connected)
            {
                try
                {
                    Packet packet = PacketUtility.ReadPacket(Stream);
                    if (packet != null)
                    {
                        HandlePacket(packet);
                    }
                }
                catch { }
            }

            // Remove from clients on connection loss
            MatahariServer.RemoveClient(this);
            Connected = false;
        }

        private void StartSendQueue()
        {
            while (Socket.Connected)
            {
                if (packetQueue.Count > 0)
                {
                    try
                    {
                        PacketUtility.WritePacket(Stream, packetQueue.Dequeue());
                        Thread.Sleep(100);
                    }
                    catch { }
                }
            }
        }

        public void SendPacket(Packet packet)
        {
            packetQueue.Enqueue(packet);
        }

        private void HandlePacket(Packet packet)
        {
            if (packet is LoginPacket loginPacket)
            {
                MachineName = loginPacket.MachineName;
            }
            else if (packet is HeartbeatPacket heartbeatPacket)
            {
                LastHeartbeat = heartbeatPacket;
            }
        }
    }
}
