namespace Matahari
{
    public class LoginPacket : Packet
    {
        public string MachineName { get; set; }

        public LoginPacket() {
            MachineName = string.Empty;
        }

        public LoginPacket(string machineName)
        {
            this.MachineName = machineName;
        }

        public override void Read(BinaryReader reader)
        {
            MachineName = reader.ReadString();
        }

        public override void Write(BinaryWriter writer)
        {
            writer.Write(MachineName);
        }
    }
}