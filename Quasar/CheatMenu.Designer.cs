﻿namespace Quasar
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
            contact_button = new Button();
            other_button = new Button();
            triggerbot_button = new Button();
            misc_button = new Button();
            visual_button = new Button();
            logo_picture = new PictureBox();
            panel1 = new Panel();
            container_panel = new Panel();
            ui_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_picture).BeginInit();
            SuspendLayout();
            // 
            // ui_panel
            // 
            ui_panel.Anchor = AnchorStyles.Top;
            ui_panel.BackColor = Color.FromArgb(25, 25, 25);
            ui_panel.Controls.Add(contact_button);
            ui_panel.Controls.Add(other_button);
            ui_panel.Controls.Add(triggerbot_button);
            ui_panel.Controls.Add(misc_button);
            ui_panel.Controls.Add(visual_button);
            ui_panel.Controls.Add(logo_picture);
            ui_panel.Controls.Add(panel1);
            ui_panel.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ui_panel.Location = new Point(-3, -1);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(811, 78);
            ui_panel.TabIndex = 0;
            // 
            // contact_button
            // 
            contact_button.BackColor = Color.FromArgb(40, 40, 40);
            contact_button.FlatStyle = FlatStyle.Flat;
            contact_button.Location = new Point(657, 28);
            contact_button.Name = "contact_button";
            contact_button.Size = new Size(119, 32);
            contact_button.TabIndex = 6;
            contact_button.Text = "Contact";
            contact_button.UseVisualStyleBackColor = false;
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
            // 
            // triggerbot_button
            // 
            triggerbot_button.BackColor = Color.FromArgb(40, 40, 40);
            triggerbot_button.FlatStyle = FlatStyle.Flat;
            triggerbot_button.Location = new Point(369, 28);
            triggerbot_button.Name = "triggerbot_button";
            triggerbot_button.Size = new Size(119, 32);
            triggerbot_button.TabIndex = 4;
            triggerbot_button.Text = "Triggerbot";
            triggerbot_button.UseVisualStyleBackColor = false;
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
            logo_picture.Image = Properties.Resources.Logo;
            logo_picture.Location = new Point(15, 19);
            logo_picture.Name = "logo_picture";
            logo_picture.Size = new Size(47, 50);
            logo_picture.SizeMode = PictureBoxSizeMode.Zoom;
            logo_picture.TabIndex = 1;
            logo_picture.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(93, 25, 181);
            panel1.Location = new Point(4, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 20);
            panel1.TabIndex = 1;
            // 
            // container_panel
            // 
            container_panel.Location = new Point(-3, 74);
            container_panel.Name = "container_panel";
            container_panel.Size = new Size(808, 442);
            container_panel.TabIndex = 1;
            // 
            // CheatMenu
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(802, 514);
            Controls.Add(container_panel);
            Controls.Add(ui_panel);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(818, 553);
            MinimumSize = new Size(818, 553);
            Name = "CheatMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quasar";
            FormClosing += CheatMenu_FormClosing;
            ui_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ui_panel;
        private Panel panel1;
        private PictureBox logo_picture;
        private Button visual_button;
        private Button misc_button;
        private Button contact_button;
        private Button other_button;
        private Button triggerbot_button;
        private Panel container_panel;
    }
}
