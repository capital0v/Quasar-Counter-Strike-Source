using System.Diagnostics;

namespace Vexium
{
    public partial class Login : Form
    {
        private CheatMenu _menu;

        public Login()
        {
            InitializeComponent();
        }

        public void CheckProcess()
        {
            Process[] processes = Process.GetProcessesByName("hl2");

            if (processes.Length > 0)
            {
                this.Hide();
                _menu = new CheatMenu(windowed_checkbox.Checked);
                _menu.Show();
            }
            else
            {
                MessageBox.Show("Error: The required process 'hl2' is not running.", "Process Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void visual_button_Click(object sender, EventArgs e)
        {
            CheckProcess();
        }
    }
}
