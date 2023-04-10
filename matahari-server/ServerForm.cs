namespace Matahari
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();

            MatahariServer.AddUpdateListener(this, () =>
            {
                // Form updates need to be performed from the UI thread
                Invoke(() => HandleUpdate());
            });
        }

        private void HandleUpdate()
        {
            UpdateClientList();
            UpdateClientInformation();
        }

        private void UpdateClientList()
        {
            MatahariClient client = (MatahariClient)clientList.SelectedItem;

            clientList.Items.Clear();
            MatahariServer.GetClients().ForEach(client => clientList.Items.Add(client));

            clientList.SelectedItem = client;
        }

        private void UpdateClientInformation()
        {
            MatahariClient client = (MatahariClient)clientList.SelectedItem;
            if (client != null)
            {
                HeartbeatPacket? heartbeat = client.LastHeartbeat;
                if (heartbeat != null)
                {
                    machineName.Text = client.MachineName;
                    screenshot.Image = heartbeat.Screenshot;
                    connectedSince.Text = client.ConnectedSince.ToString("dd.MM.yyyy HH:mm:ss");
                    lastHeartbeat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                    cpuUsage.Text = heartbeat.CpuUsage + "%";
                    memoryAvailable.Text = heartbeat.MemoryAvailable + "MB";
                    return;
                }
            }

            // Clear information
            machineName.Text = string.Empty;
            screenshot.Image = null;
            connectedSince.Text = string.Empty;
            lastHeartbeat.Text = string.Empty;
            cpuUsage.Text = string.Empty;
            memoryAvailable.Text = string.Empty;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectedDeviceName_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectedClientChanged(object sender, EventArgs e)
        {
            UpdateClientInformation();
        }

        private void CloseButtonClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoMenuClicked(object sender, EventArgs e)
        {
            AboutForm form = new();
            form.ShowDialog();
        }

        private void ScreenshotClicked(object sender, EventArgs e)
        {
            MatahariClient client = (MatahariClient)clientList.SelectedItem;
            if (client != null)
            {
                ScreenshotForm form = new(client);
                form.ShowDialog();
            }
        }
    }
}