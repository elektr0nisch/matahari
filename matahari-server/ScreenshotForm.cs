namespace Matahari
{
    public partial class ScreenshotForm : Form
    {
        private readonly MatahariClient client;

        public ScreenshotForm(MatahariClient client)
        {
            this.client = client;

            InitializeComponent();
            Text = client.MachineName + " – " + "matahari";
            UpdateImage();

            MatahariServer.AddUpdateListener(this, () =>
            {
                Invoke(() => UpdateImage());
            });

            MouseWheel += ScreenshotMouseWheel;
        }

        private void UpdateImage()
        {
            if (!client.Connected)
            {
                Close();
            }

            HeartbeatPacket? heartbeat = client.LastHeartbeat;
            if (heartbeat != null)
            {
                screenshot.Image = heartbeat.Screenshot;
            }
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            MatahariServer.RemoveUpdateListener(this);
        }

        private void ScreenshotMouseDown(object sender, MouseEventArgs e)
        {
            Point mouseLocation = e.Location;
            int button = (int)e.Button;

            client.SendPacket(new ClickPacket((float)mouseLocation.X / screenshot.Width, (float)mouseLocation.Y / screenshot.Height, button, true));
        }

        private void ScreenshotMouseUp(object sender, MouseEventArgs e)
        {
            Point mouseLocation = e.Location;
            int button = (int)e.Button;

            client.SendPacket(new ClickPacket((float)mouseLocation.X / screenshot.Width, (float)mouseLocation.Y / screenshot.Height, button, false));
        }

        private void ScreenshotMouseWheel(object? sender, MouseEventArgs e)
        {
            client.SendPacket(new MouseWheelPacket(e.Delta));
        }

        private void ScreenshotKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.KeyCode;
            client.SendPacket(new KeyPressPacket(key, true));
        }

        private void ScreenshotKeyUp(object sender, KeyEventArgs e)
        {
            int key = (int)e.KeyCode;
            client.SendPacket(new KeyPressPacket(key, false));
        }
    }
}
