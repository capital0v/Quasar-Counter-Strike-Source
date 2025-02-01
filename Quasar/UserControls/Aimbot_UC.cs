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

            switch (bone_combo.Text)
            {
                case "Head":
                    preview_picture.Image = Properties.Resources.aim1;
                    break;
                case "Neck":
                    preview_picture.Image = Properties.Resources.aim2;
                    break;
                case "Body":
                    preview_picture.Image = Properties.Resources.aim3;
                    break;
                case "Legs":
                    preview_picture.Image = Properties.Resources.aim4;
                    break;
            }
        }

        private void mouse_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Functions.mousePressed = mouse_checkbox.Checked;
        }
    }
}
