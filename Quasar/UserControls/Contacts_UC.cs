using System.Diagnostics;

namespace Quasar.UserControls
{
    public partial class Contacts_UC : UserControl
    {
        public Contacts_UC()
        {
            InitializeComponent();
        }

        private void github_picture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/capital0v") { UseShellExecute = true });
        }

        private void telegram_picture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/capital0v") { UseShellExecute = true });
        }
    }
}
