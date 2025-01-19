namespace Quasar
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            visual_button = new Button();
            logo_pciture = new PictureBox();
            windowed_checkbox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)logo_pciture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(93, 25, 181);
            panel1.Location = new Point(-426, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 15);
            panel1.TabIndex = 2;
            // 
            // visual_button
            // 
            visual_button.BackColor = Color.FromArgb(40, 40, 40);
            visual_button.FlatStyle = FlatStyle.Flat;
            visual_button.Location = new Point(61, 214);
            visual_button.Margin = new Padding(4, 3, 4, 3);
            visual_button.Name = "visual_button";
            visual_button.Size = new Size(211, 39);
            visual_button.TabIndex = 3;
            visual_button.Text = "Inject";
            visual_button.UseVisualStyleBackColor = false;
            visual_button.Click += visual_button_Click;
            // 
            // logo_pciture
            // 
            logo_pciture.Image = Properties.Resources.Logo;
            logo_pciture.Location = new Point(88, 33);
            logo_pciture.Margin = new Padding(4, 3, 4, 3);
            logo_pciture.Name = "logo_pciture";
            logo_pciture.Size = new Size(149, 127);
            logo_pciture.SizeMode = PictureBoxSizeMode.Zoom;
            logo_pciture.TabIndex = 4;
            logo_pciture.TabStop = false;
            // 
            // windowed_checkbox
            // 
            windowed_checkbox.AutoSize = true;
            windowed_checkbox.Location = new Point(51, 166);
            windowed_checkbox.Name = "windowed_checkbox";
            windowed_checkbox.Size = new Size(236, 26);
            windowed_checkbox.TabIndex = 5;
            windowed_checkbox.Text = "Game in Window Mode";
            windowed_checkbox.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(331, 278);
            Controls.Add(windowed_checkbox);
            Controls.Add(logo_pciture);
            Controls.Add(visual_button);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(347, 317);
            MinimumSize = new Size(347, 317);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quasar";
            ((System.ComponentModel.ISupportInitialize)logo_pciture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button visual_button;
        private PictureBox logo_pciture;
        private CheckBox windowed_checkbox;
    }
}