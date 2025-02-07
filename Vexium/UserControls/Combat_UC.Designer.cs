namespace Vexium.UserControls
{
    partial class Combat_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Combat_UC));
            ui_label = new Label();
            ui_panel = new Panel();
            smooth_combo = new ComboBox();
            ui4_label = new Label();
            aimlock_checkbox = new CheckBox();
            mouse_checkbox = new CheckBox();
            ui2_label = new Label();
            bone_combo = new ComboBox();
            aimbot_checkbox = new CheckBox();
            ui2_panel = new Panel();
            preview_picture = new PictureBox();
            ui3_label = new Label();
            ui5_label = new Label();
            panel1 = new Panel();
            triggerbot_checkbox = new CheckBox();
            knifebot_checkbox = new CheckBox();
            ui_panel.SuspendLayout();
            ui2_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)preview_picture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ui_label
            // 
            ui_label.AutoSize = true;
            ui_label.Location = new Point(24, 26);
            ui_label.Name = "ui_label";
            ui_label.Size = new Size(73, 22);
            ui_label.TabIndex = 11;
            ui_label.Text = "Aimbot";
            // 
            // ui_panel
            // 
            ui_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui_panel.Controls.Add(smooth_combo);
            ui_panel.Controls.Add(ui4_label);
            ui_panel.Controls.Add(aimlock_checkbox);
            ui_panel.Controls.Add(mouse_checkbox);
            ui_panel.Controls.Add(ui2_label);
            ui_panel.Controls.Add(bone_combo);
            ui_panel.Controls.Add(aimbot_checkbox);
            ui_panel.Location = new Point(24, 66);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(335, 249);
            ui_panel.TabIndex = 10;
            // 
            // smooth_combo
            // 
            smooth_combo.FormattingEnabled = true;
            smooth_combo.Items.AddRange(new object[] { "Very low", "Low", "Medium", "High", "Very High" });
            smooth_combo.Location = new Point(145, 162);
            smooth_combo.Name = "smooth_combo";
            smooth_combo.Size = new Size(121, 27);
            smooth_combo.TabIndex = 18;
            smooth_combo.Text = "Medium";
            smooth_combo.SelectedIndexChanged += smooth_combo_SelectedIndexChanged;
            // 
            // ui4_label
            // 
            ui4_label.AutoSize = true;
            ui4_label.Location = new Point(14, 165);
            ui4_label.Name = "ui4_label";
            ui4_label.Size = new Size(115, 22);
            ui4_label.TabIndex = 17;
            ui4_label.Text = "Smoothness";
            // 
            // aimlock_checkbox
            // 
            aimlock_checkbox.AutoSize = true;
            aimlock_checkbox.Location = new Point(14, 42);
            aimlock_checkbox.Name = "aimlock_checkbox";
            aimlock_checkbox.Size = new Size(110, 26);
            aimlock_checkbox.TabIndex = 16;
            aimlock_checkbox.Text = "Aim Lock";
            aimlock_checkbox.UseVisualStyleBackColor = true;
            aimlock_checkbox.CheckedChanged += aimlock_checkbox_CheckedChanged;
            // 
            // mouse_checkbox
            // 
            mouse_checkbox.AutoSize = true;
            mouse_checkbox.Location = new Point(14, 72);
            mouse_checkbox.Name = "mouse_checkbox";
            mouse_checkbox.Size = new Size(308, 26);
            mouse_checkbox.TabIndex = 15;
            mouse_checkbox.Text = "Only when the button is pressed";
            mouse_checkbox.UseVisualStyleBackColor = true;
            mouse_checkbox.CheckedChanged += mouse_checkbox_CheckedChanged;
            // 
            // ui2_label
            // 
            ui2_label.AutoSize = true;
            ui2_label.Location = new Point(14, 112);
            ui2_label.Name = "ui2_label";
            ui2_label.Size = new Size(115, 22);
            ui2_label.TabIndex = 14;
            ui2_label.Text = "Target Bone";
            // 
            // bone_combo
            // 
            bone_combo.FormattingEnabled = true;
            bone_combo.Items.AddRange(new object[] { "Head", "Neck", "Body", "Legs" });
            bone_combo.Location = new Point(145, 112);
            bone_combo.Name = "bone_combo";
            bone_combo.Size = new Size(121, 27);
            bone_combo.TabIndex = 1;
            bone_combo.Text = "Body";
            bone_combo.SelectedIndexChanged += bone_combo_SelectedIndexChanged;
            // 
            // aimbot_checkbox
            // 
            aimbot_checkbox.AutoSize = true;
            aimbot_checkbox.Location = new Point(14, 12);
            aimbot_checkbox.Name = "aimbot_checkbox";
            aimbot_checkbox.Size = new Size(92, 26);
            aimbot_checkbox.TabIndex = 0;
            aimbot_checkbox.Text = "Aimbot";
            aimbot_checkbox.UseVisualStyleBackColor = true;
            aimbot_checkbox.CheckedChanged += aimbot_checkbox_CheckedChanged;
            // 
            // ui2_panel
            // 
            ui2_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui2_panel.Controls.Add(preview_picture);
            ui2_panel.Location = new Point(444, 66);
            ui2_panel.Name = "ui2_panel";
            ui2_panel.Size = new Size(335, 451);
            ui2_panel.TabIndex = 15;
            // 
            // preview_picture
            // 
            preview_picture.Image = (Image)resources.GetObject("preview_picture.Image");
            preview_picture.Location = new Point(36, 52);
            preview_picture.Name = "preview_picture";
            preview_picture.Size = new Size(279, 341);
            preview_picture.SizeMode = PictureBoxSizeMode.Zoom;
            preview_picture.TabIndex = 0;
            preview_picture.TabStop = false;
            // 
            // ui3_label
            // 
            ui3_label.AutoSize = true;
            ui3_label.Location = new Point(24, 360);
            ui3_label.Name = "ui3_label";
            ui3_label.Size = new Size(59, 22);
            ui3_label.TabIndex = 17;
            ui3_label.Text = "Other";
            // 
            // ui5_label
            // 
            ui5_label.AutoSize = true;
            ui5_label.Location = new Point(444, 26);
            ui5_label.Name = "ui5_label";
            ui5_label.Size = new Size(78, 22);
            ui5_label.TabIndex = 18;
            ui5_label.Text = "Preview";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(knifebot_checkbox);
            panel1.Controls.Add(triggerbot_checkbox);
            panel1.Location = new Point(24, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 117);
            panel1.TabIndex = 19;
            // 
            // triggerbot_checkbox
            // 
            triggerbot_checkbox.AutoSize = true;
            triggerbot_checkbox.Location = new Point(14, 16);
            triggerbot_checkbox.Name = "triggerbot_checkbox";
            triggerbot_checkbox.Size = new Size(118, 26);
            triggerbot_checkbox.TabIndex = 19;
            triggerbot_checkbox.Text = "Triggerbot";
            triggerbot_checkbox.UseVisualStyleBackColor = true;
            triggerbot_checkbox.CheckedChanged += triggerbot_checkbox_CheckedChanged;
            // 
            // knifebot_checkbox
            // 
            knifebot_checkbox.AutoSize = true;
            knifebot_checkbox.Location = new Point(14, 46);
            knifebot_checkbox.Name = "knifebot_checkbox";
            knifebot_checkbox.Size = new Size(101, 26);
            knifebot_checkbox.TabIndex = 20;
            knifebot_checkbox.Text = "Knifebot";
            knifebot_checkbox.UseVisualStyleBackColor = true;
            knifebot_checkbox.CheckedChanged += knifebot_checkbox_CheckedChanged;
            // 
            // Combat_UC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel1);
            Controls.Add(ui5_label);
            Controls.Add(ui3_label);
            Controls.Add(ui2_panel);
            Controls.Add(ui_label);
            Controls.Add(ui_panel);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            MaximumSize = new Size(805, 543);
            MinimumSize = new Size(805, 543);
            Name = "Combat_UC";
            Size = new Size(805, 543);
            ui_panel.ResumeLayout(false);
            ui_panel.PerformLayout();
            ui2_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)preview_picture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ui_label;
        private Panel ui_panel;
        private CheckBox aimbot_checkbox;
        private ComboBox bone_combo;
        private Label ui2_label;
        private Panel ui2_panel;
        private PictureBox preview_picture;
        private CheckBox mouse_checkbox;
        private Label ui3_label;
        private CheckBox aimlock_checkbox;
        private ComboBox smooth_combo;
        private Label ui4_label;
        private Label ui5_label;
        private Panel panel1;
        private CheckBox knifebot_checkbox;
        private CheckBox triggerbot_checkbox;
    }
}
