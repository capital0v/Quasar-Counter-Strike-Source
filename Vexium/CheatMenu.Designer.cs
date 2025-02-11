namespace Vexium
{
    partial class CheatMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheatMenu));
            ui_panel = new Panel();
            ui2_panel = new Panel();
            unhook_button = new Button();
            other_button = new Button();
            aimbot_button = new Button();
            misc_button = new Button();
            visual_button = new Button();
            logo_picture = new PictureBox();
            container_panel = new Panel();
            ui_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_picture).BeginInit();
            SuspendLayout();
            // 
            // ui_panel
            // 
            ui_panel.Anchor = AnchorStyles.None;
            ui_panel.BackColor = Color.FromArgb(25, 25, 25);
            ui_panel.Controls.Add(ui2_panel);
            ui_panel.Controls.Add(unhook_button);
            ui_panel.Controls.Add(other_button);
            ui_panel.Controls.Add(aimbot_button);
            ui_panel.Controls.Add(misc_button);
            ui_panel.Controls.Add(visual_button);
            ui_panel.Controls.Add(logo_picture);
            ui_panel.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ui_panel.Location = new Point(0, -2);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(805, 77);
            ui_panel.TabIndex = 0;
            // 
            // ui2_panel
            // 
            ui2_panel.BackColor = Color.FromArgb(255, 20, 55);
            ui2_panel.Location = new Point(0, 0);
            ui2_panel.Name = "ui2_panel";
            ui2_panel.Size = new Size(805, 13);
            ui2_panel.TabIndex = 0;
            // 
            // unhook_button
            // 
            unhook_button.BackColor = Color.FromArgb(40, 40, 40);
            unhook_button.FlatStyle = FlatStyle.Flat;
            unhook_button.Location = new Point(657, 28);
            unhook_button.Name = "unhook_button";
            unhook_button.Size = new Size(119, 32);
            unhook_button.TabIndex = 6;
            unhook_button.Text = "Unhook";
            unhook_button.UseVisualStyleBackColor = false;
            unhook_button.Click += unhook_button_Click;
            // 
            // other_button
            // 
            other_button.BackColor = Color.FromArgb(40, 40, 40);
            other_button.FlatStyle = FlatStyle.Flat;
            other_button.Location = new Point(513, 28);
            other_button.Name = "other_button";
            other_button.Size = new Size(119, 32);
            other_button.TabIndex = 5;
            other_button.Text = "Other";
            other_button.UseVisualStyleBackColor = false;
            other_button.Click += other_button_Click;
            // 
            // aimbot_button
            // 
            aimbot_button.BackColor = Color.FromArgb(40, 40, 40);
            aimbot_button.FlatStyle = FlatStyle.Flat;
            aimbot_button.Location = new Point(369, 28);
            aimbot_button.Name = "aimbot_button";
            aimbot_button.Size = new Size(119, 32);
            aimbot_button.TabIndex = 4;
            aimbot_button.Text = "Combat";
            aimbot_button.UseVisualStyleBackColor = false;
            aimbot_button.Click += aimbot_button_Click;
            // 
            // misc_button
            // 
            misc_button.BackColor = Color.FromArgb(40, 40, 40);
            misc_button.FlatStyle = FlatStyle.Flat;
            misc_button.Location = new Point(225, 28);
            misc_button.Name = "misc_button";
            misc_button.Size = new Size(119, 32);
            misc_button.TabIndex = 3;
            misc_button.Text = "Misc";
            misc_button.UseVisualStyleBackColor = false;
            misc_button.Click += misc_button_Click;
            // 
            // visual_button
            // 
            visual_button.BackColor = Color.FromArgb(40, 40, 40);
            visual_button.FlatStyle = FlatStyle.Flat;
            visual_button.Location = new Point(81, 28);
            visual_button.Name = "visual_button";
            visual_button.Size = new Size(119, 32);
            visual_button.TabIndex = 2;
            visual_button.Text = "Visual";
            visual_button.UseVisualStyleBackColor = false;
            visual_button.Click += visual_button_Click;
            // 
            // logo_picture
            // 
            logo_picture.Image = (Image)resources.GetObject("logo_picture.Image");
            logo_picture.Location = new Point(15, 19);
            logo_picture.Name = "logo_picture";
            logo_picture.Size = new Size(50, 50);
            logo_picture.SizeMode = PictureBoxSizeMode.Zoom;
            logo_picture.TabIndex = 1;
            logo_picture.TabStop = false;
            // 
            // container_panel
            // 
            container_panel.Anchor = AnchorStyles.None;
            container_panel.Location = new Point(0, 73);
            container_panel.Name = "container_panel";
            container_panel.Size = new Size(805, 543);
            container_panel.TabIndex = 1;
            // 
            // CheatMenu
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(802, 615);
            Controls.Add(container_panel);
            Controls.Add(ui_panel);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(818, 654);
            MinimumSize = new Size(818, 654);
            Name = "CheatMenu";
            Text = "Vexium";
            FormClosing += CheatMenu_FormClosing;
            ui_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ui_panel;
        private PictureBox logo_picture;
        private Button visual_button;
        private Button misc_button;
        private Button unhook_button;
        private Button other_button;
        private Button aimbot_button;
        private Panel container_panel;
        private Panel ui2_panel;
    }
}
