using Vexium.Scripts.Features;
using static Vexium.Scripts.States;
using static Vexium.Scripts.SoundManager;

namespace Vexium.UserControls
{
    public partial class Combat_UC : UserControl
    {
        private readonly string _menuSound = "Sounds/click3.wav";
        private Functions _functions;

        internal Combat_UC(Functions functions)
        {
            InitializeComponent();
            bone_combo.SelectedItem = "Body";
            smooth_combo.SelectedItem = "Medium";
            _functions = functions;
            _functions.targetLevel = bone_combo.Text;
        }

        private void aimbot_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            aimbotEnabled = aimbot_checkbox.Checked;
            if (aimlock_checkbox.Checked && aimbot_checkbox.Checked) aimlock_checkbox.Checked = false;
            PlaySound(_menuSound);
        }

        private void bone_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _functions.targetLevel = bone_combo.Text;
            preview_picture.Image = bone_combo.Text switch
            {
                "Head" => Properties.Resources.aim1,
                "Neck" => Properties.Resources.aim2,
                "Body" => Properties.Resources.aim3,
                "Legs" => Properties.Resources.aim4,
                _ => preview_picture.Image
            };
            PlaySound(_menuSound);
        }

        private void mouse_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            _functions.mousePressed = mouse_checkbox.Checked;
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
            if (aimlock_checkbox.Checked && aimbot_checkbox.Checked) aimbot_checkbox.Checked = false;
            PlaySound(_menuSound);
        }

        private void smooth_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _functions.aimSmoothness = smooth_combo.SelectedIndex switch
            {
                0 => 2,
                1 => 5,
                2 => 10,
                3 => 20,
                4 => 100,
                _ => _functions.aimSmoothness
            };
        }

        public void DisableAll()
        {
            aimlock_checkbox.Checked = false;
            aimbot_checkbox.Checked = false;
            triggerbot_checkbox.Checked = false;
            knifebot_checkbox.Checked = false;
            mouse_checkbox.Checked = false;
        }
    }
}
