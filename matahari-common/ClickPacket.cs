namespace Matahari
{
    public class ClickPacket : Packet
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Button { get; set; }
        public bool Down { get; set; }

        public ClickPacket()
        {

        }

        public ClickPacket(float x, float y, int button, bool down)
        {
            X = x;
            Y = y;
            Button = button;
            Down = down;    
        }

        public override void Read(BinaryReader reader)
        {
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
            Button = reader.ReadInt32();
            Down = reader.ReadBoolean();
        }

        public override void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Button);
            writer.Write(Down);
        }
    }
}
