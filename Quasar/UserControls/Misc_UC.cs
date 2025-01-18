using NAudio.Wave;
using Quasar.Features;
using static Quasar.States;

namespace Quasar.UserControls
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

        private void PlaySound(string audioFilePath)
        {
            using (var audioFile = new AudioFileReader(audioFilePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(1);
                }
            }
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

        private void triggerbot_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            triggerbotEnabled = triggerbot_checkbox.Checked;
            PlaySound(_menuSound);
        }
    }
}
