namespace Matahari
{
    public class KeyPressPacket : Packet
    {
        public int Key { get; set; }
        public bool Down { get; set; }

        public KeyPressPacket()
        {

        }

        public KeyPressPacket(int key, bool down)
        {
            Key = key;
            Down = down;    
        }

        public override void Read(BinaryReader reader)
        {
            Key = reader.ReadInt32();
            Down = reader.ReadBoolean();
        }

        public override void Write(BinaryWriter writer)
        {
            writer.Write(Key);
            writer.Write(Down);
        }
    }
}
