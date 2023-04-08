namespace Matahari
{
    public class ShutdownPacket: Packet
    {
        public string Message { get; set; }
        public int Delay { get; set; }

        public ShutdownPacket() {
            Message = string.Empty;
            Delay = 0;
        }

        public ShutdownPacket(string message, int delay)
        {
            this.Message = message;
            this.Delay = delay;
        }

        public override void Read(BinaryReader reader)
        {
            Message = reader.ReadString();
            Delay = reader.ReadInt16();
        }

        public override void Write(BinaryWriter writer)
        {
            writer.Write(Message);
            writer.Write(Delay);   
        }
    }
}