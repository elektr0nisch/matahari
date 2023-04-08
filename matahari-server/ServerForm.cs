namespace Matahari
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();

            MatahariServer.RegisterUpdateListener(() =>
            {
                // Form updates need to be performed from the UI thread
                this.Invoke(() => HandleUpdate());
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
            if (client == null)
            {
                machineName.Text = string.Empty;
                screenshot.Image = null;
                return;
            }

            machineName.Text = client.MachineName;
            if (client.Screenshot != null)
            {
                screenshot.Image = client.Screenshot;
            }
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
    }
}