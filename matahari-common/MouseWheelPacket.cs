namespace Matahari
{
    public class MouseWheelPacket : Packet
    {
        public int Delta { get; set; }

        public MouseWheelPacket()
        {

        }

        public MouseWheelPacket(int delta)
        {
            Delta = delta;
        }

        public override void Read(BinaryReader reader)
        {
            Delta = reader.ReadInt32();
        }

        public override void Write(BinaryWriter writer)
        {
            writer.Write(Delta);
        }
    }
}
