using Quasar.Scripts.Features;
using static Quasar.Scripts.States;
using static Quasar.Scripts.SoundManager;

namespace Quasar.UserControls
{
    public partial class Combat_UC : UserControl
    {

        private readonly string _menuSound = "Sounds/click3.wav";

        internal Combat_UC(Functions functions)
        {
            InitializeComponent();
            bone_combo.SelectedItem = "Body";
            Functions.targetLevel = bone_combo.Text;
        }

        private void aimbot_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            aimbotEnabled = aimbot_checkbox.Checked;

            if (aimlock_checkbox.Checked && aimbot_checkbox.Checked)
            {
                aimlock_checkbox.Checked = false;
            }

            PlaySound(_menuSound);
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

            PlaySound(_menuSound);
        }

        private void mouse_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Functions.mousePressed = mouse_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void knifebot_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            knifebotEnabled = knifebot_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void triggerbot_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            triggerbotEnabled = triggerbot_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void aimlock_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            aimlockEnabled = aimlock_checkbox.Checked;

            if (aimlock_checkbox.Checked && aimbot_checkbox.Checked)
            {
                aimbot_checkbox.Checked = false;
            }

            PlaySound(_menuSound);
        }
    }
}
