using System.Drawing;

namespace Matahari
{
    public class HeartbeatPacket : Packet
    {
        public static readonly ImageConverter converter = new();

        public Bitmap? Screenshot { get; set; }

        public float CpuUsage { get; set; }

        public float MemoryAvailable { get; set; }

        public int BatteryStatus { get; set; }

        public HeartbeatPacket() {
        }

        public HeartbeatPacket(Bitmap screenshot, float cpuUsage, float memoryAvailable, int batteryStatus)
        {
            Screenshot = screenshot;
            CpuUsage = cpuUsage;
            MemoryAvailable = memoryAvailable;
            BatteryStatus = batteryStatus;
        }

        public override void Read(BinaryReader reader)
        {
            int count = reader.Read7BitEncodedInt();
            byte[] data = reader.ReadBytes(count);
            Screenshot = (Bitmap?)converter.ConvertFrom(data);

            CpuUsage = reader.ReadSingle();
            MemoryAvailable = reader.ReadSingle();
            BatteryStatus = reader.ReadInt32();
        }

        public override void Write(BinaryWriter writer)
        {
            byte[] bytes = (byte[])converter.ConvertTo(Screenshot, typeof(byte[]));
            writer.Write7BitEncodedInt(bytes.Length);
            writer.Write(bytes);

            writer.Write(CpuUsage);
            writer.Write(MemoryAvailable);
            writer.Write(BatteryStatus);
        }
    }
}