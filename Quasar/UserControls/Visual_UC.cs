namespace Quasar.UserControls
{
    public partial class Visual_UC : UserControl
    {
        public Visual_UC()
        {
            InitializeComponent();
        }

        private void wallhack_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            States.wallhackEnabled = wallhack_checkbox.Checked;
        }

        private void wireframe_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            States.wireframeEnabled = wireframe_checkbox.Checked;
        }

        private void showshots_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            States.showimpactEnabled = showshots_checkbox.Checked;
        }

        private void fullbright_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            States.fullbrightEnabled = fullbright_checkbox.Checked;

            if (fullbright_checkbox.Checked && whiteTexture_checkbox.Checked)
            {
                fullbright_checkbox.Checked = true;
                whiteTexture_checkbox.Checked = false;
            }
        }

        private void whiteTexture_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            States.whiteTextureEnabled = whiteTexture_checkbox.Checked;

            if (fullbright_checkbox.Checked && whiteTexture_checkbox.Checked)
            {
                fullbright_checkbox.Checked = false;
                whiteTexture_checkbox.Checked = true;
            }
        }
    }
}
