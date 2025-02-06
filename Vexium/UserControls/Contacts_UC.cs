using System.Diagnostics;
using static Vexium.Scripts.SoundManager;

namespace Vexium.UserControls
{
    public partial class Contacts_UC : UserControl
    {
        private readonly string _menuSound = "Sounds/click3.wav";
        public Contacts_UC()
        {
            InitializeComponent();
        }

        private void github_picture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/capital0v") { UseShellExecute = true });
            PlaySound(_menuSound);
        }

        private void telegram_picture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/capital0v") { UseShellExecute = true });
            PlaySound(_menuSound);
        }
    }
}
