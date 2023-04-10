using System.Diagnostics;

namespace Matahari
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CopyrightClicked(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", "/c start https://elektronisch.dev") { CreateNoWindow = true });
        }
    }
}
