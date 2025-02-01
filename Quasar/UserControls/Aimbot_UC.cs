using Quasar.Features;
using static Quasar.Scripts.States;

namespace Quasar.UserControls
{
    public partial class Aimbot_UC : UserControl
    {

        internal Aimbot_UC(Functions functions)
        {
            InitializeComponent();
            bone_combo.SelectedItem = "Body";
        }

        private void aimbot_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            aimbotEnabled = aimbot_checkbox.Checked;
            Functions.targetLevel = bone_combo.Text;
        }

        private void bone_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.targetLevel = bone_combo.Text;
        }
    }
}
