using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Matahari
{
    public class PacketUtility
    {
        public static Packet ReadPacket(Stream stream)
        {
            using BinaryReader networkReader = new(stream, Encoding.UTF8, true);

            // Read four-byte signed integer determining following packet length
            int length = networkReader.ReadInt32();
            byte[] data = networkReader.ReadBytes(length);

            Console.WriteLine("meeep");
            if (data.Length < length)
            {
                throw new NetworkException("eof reached before packet end");
            }

            // Read packet from data bytes
            using BinaryReader packetReader = new BinaryReader(new MemoryStream(data), Encoding.UTF8);
            string className = packetReader.ReadString();
            Type? type = Type.GetType(className);
            if (type == null)
                throw new NetworkException("invalid packet " + className);

            var packet = Activator.CreateInstance(type);
            if (packet == null)
                throw new NetworkException("format error in packet " + className);

            Packet castPacket = (Packet)packet;
            castPacket.Read(packetReader);

            return castPacket;
        }

        public static void WritePacket(Stream stream, Packet packet)
        {
            Type type = packet.GetType();
            if (type == null || type.AssemblyQualifiedName == null)
                throw new NetworkException("invalid packet");

            // Locally store the packet in bytes
            MemoryStream localStream = new();
            using BinaryWriter localWriter = new(localStream, Encoding.UTF8);
            localWriter.Write(type.AssemblyQualifiedName);
            packet.Write(localWriter);

            // Write a four-byte signed integer determining the length of the packet
            BinaryWriter networkWriter = new(stream, Encoding.UTF8, true);
            networkWriter.Write((int)localStream.Length);

            // Write the packet data
            byte[] data = localStream.ToArray();
            stream.Write(data, 0, data.Length);
        }
    }
}
