using NAudio.Wave;
using static Quasar.States;

namespace Quasar.UserControls
{
    public partial class Visual_UC : UserControl
    {

        private readonly string _menuSound = "Sounds/click3.wav";
        public Visual_UC()
        {
            InitializeComponent();
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

        private void wallhack_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            wallhackEnabled = wallhack_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void wireframe_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            wireframeEnabled = wireframe_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void showshots_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            showimpactEnabled = showshots_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void fullbright_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            fullbrightEnabled = fullbright_checkbox.Checked;

            if (fullbright_checkbox.Checked && whiteTexture_checkbox.Checked)
            {
                fullbright_checkbox.Checked = true;
                whiteTexture_checkbox.Checked = false;
            }
            PlaySound(_menuSound);
        }

        private void whiteTexture_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            whiteTextureEnabled = whiteTexture_checkbox.Checked;

            if (fullbright_checkbox.Checked && whiteTexture_checkbox.Checked)
            {
                fullbright_checkbox.Checked = false;
                whiteTexture_checkbox.Checked = true;
            }
            PlaySound(_menuSound);
        }

        private void nosmoke_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            nosmokeEnabled = nosmoke_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void hitboxes_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            hitboxesEnabled = hitboxes_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void minecraft_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            lowresolutionEnabled = minecraft_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void tracers_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            tracersEnabled = tracers_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void shadow_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            shadowFrameEnabled = shadow_checkbox.Checked;
            PlaySound(_menuSound);
        }
    }
}
