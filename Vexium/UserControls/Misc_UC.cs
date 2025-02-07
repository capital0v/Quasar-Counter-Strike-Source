using static Vexium.Scripts.SoundManager;
using Vexium.Scripts.Features;
using static Vexium.Scripts.States;

namespace Vexium.UserControls
{
    public partial class Misc_UC : UserControl
    {
        private Functions _functions;

        private readonly string _menuSound = "Sounds/click3.wav";
        internal Misc_UC(Functions functions)
        {
            InitializeComponent();

            _functions = functions;
        }

        private void antiflash_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            antiflashEnabled = antiflash_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void bunnyhop_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bunnyhopEnabled = bunnyhop_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void getinformation_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            getInformationEnabled = getinformation_checkbox.Checked;
            PlaySound(_menuSound);
            UpdateInformation();
        }

        public async void UpdateInformation()
        {
            int ms = Convert.ToInt32(update_textbox.Text);

            if (getInformationEnabled)
            {
                while (getInformationEnabled)
                {
                    information_label.Text = _functions.GetInformation();
                    await Task.Delay(ms);
                }
            }
            else
            {
                information_label.Text = string.Empty;
            }
        }

        private void update_textbox_TextChanged(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void nickname_button_Click(object sender, EventArgs e)
        {
            _functions.ChangeNickname(nickname_textbox.Text);
        }

        private void clantag_button_Click(object sender, EventArgs e)
        {
            _functions.ChangeClantag(clantag_textbox.Text);
        }

        private void thirdperson_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            thirdpersonEnabled = thirdperson_checkbox.Checked;
            _functions.Thirdperson();
        }

        public void DisableAll()
        {
            bunnyhop_checkbox.Checked = false;
            thirdperson_checkbox.Checked = false;
            antiflash_checkbox.Checked = false;
        }
    }
}
