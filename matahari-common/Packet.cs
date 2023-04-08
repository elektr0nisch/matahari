using System.Net.Sockets;

namespace Matahari
{
    public abstract class Packet
    {
        public abstract void Read(BinaryReader reader);

        public abstract void Write(BinaryWriter writer);

    }
}