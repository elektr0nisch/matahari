using System.Drawing;

namespace Matahari
{
    public class HeartbeatPacket: Packet
    {
        public static readonly ImageConverter converter = new();

        public Bitmap? Screenshot { get; set; }

        public HeartbeatPacket() {
        }

        public HeartbeatPacket(Bitmap screenshot)
        {
            this.Screenshot = screenshot;
        }

        public override void Read(BinaryReader reader)
        {
            int count = reader.Read7BitEncodedInt();
            byte[] data = reader.ReadBytes(count);
            Screenshot = (Bitmap?)converter.ConvertFrom(data);
        }

        public override void Write(BinaryWriter writer)
        {
            byte[] bytes = (byte[])converter.ConvertTo(Screenshot, typeof(byte[]));
            writer.Write7BitEncodedInt(bytes.Length);
            writer.Write(bytes);
        }
    }
}