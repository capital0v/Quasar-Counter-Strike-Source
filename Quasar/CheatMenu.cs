using Quasar.Features;
using Quasar.UserControls;

namespace Quasar
{
    public partial class CheatMenu : Form
    {

        private Functions _functions = new Functions();

        private Visual_UC _visualUC = new Visual_UC();
        public CheatMenu()
        {
            InitializeComponent();

            _functions.Inject();
            AddUserControl(_visualUC);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            container_panel.Controls.Clear();
            container_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void visual_button_Click(object sender, EventArgs e)
        {
            AddUserControl(_visualUC);
        }

        private void CheatMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            States.DisableAll();
            Environment.Exit(0);
        }
    }
}
