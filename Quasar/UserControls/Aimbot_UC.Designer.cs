namespace Quasar.UserControls
{
    partial class Aimbot_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aimbot_UC));
            ui_label = new Label();
            ui_panel = new Panel();
            mouse_checkbox = new CheckBox();
            ui2_label = new Label();
            bone_combo = new ComboBox();
            aimbot_checkbox = new CheckBox();
            ui2_panel = new Panel();
            preview_picture = new PictureBox();
            label1 = new Label();
            ui_panel.SuspendLayout();
            ui2_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)preview_picture).BeginInit();
            SuspendLayout();
            // 
            // ui_label
            // 
            ui_label.AutoSize = true;
            ui_label.Location = new Point(24, 26);
            ui_label.Name = "ui_label";
            ui_label.Size = new Size(144, 22);
            ui_label.TabIndex = 11;
            ui_label.Text = "Aimbot Settings";
            // 
            // ui_panel
            // 
            ui_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui_panel.Controls.Add(mouse_checkbox);
            ui_panel.Controls.Add(ui2_label);
            ui_panel.Controls.Add(bone_combo);
            ui_panel.Controls.Add(aimbot_checkbox);
            ui_panel.Location = new Point(24, 66);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(335, 356);
            ui_panel.TabIndex = 10;
            // 
            // mouse_checkbox
            // 
            mouse_checkbox.AutoSize = true;
            mouse_checkbox.Location = new Point(14, 45);
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
            ui2_label.Location = new Point(14, 80);
            ui2_label.Name = "ui2_label";
            ui2_label.Size = new Size(115, 22);
            ui2_label.TabIndex = 14;
            ui2_label.Text = "Target Bone";
            // 
            // bone_combo
            // 
            bone_combo.FormattingEnabled = true;
            bone_combo.Items.AddRange(new object[] { "Head", "Neck", "Body", "Legs" });
            bone_combo.Location = new Point(145, 80);
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
            ui2_panel.Size = new Size(335, 356);
            ui2_panel.TabIndex = 15;
            // 
            // preview_picture
            // 
            preview_picture.Image = (Image)resources.GetObject("preview_picture.Image");
            preview_picture.Location = new Point(43, 12);
            preview_picture.Name = "preview_picture";
            preview_picture.Size = new Size(279, 341);
            preview_picture.SizeMode = PictureBoxSizeMode.Zoom;
            preview_picture.TabIndex = 0;
            preview_picture.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 26);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 16;
            label1.Text = "Preview";
            // 
            // Aimbot_UC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(label1);
            Controls.Add(ui2_panel);
            Controls.Add(ui_label);
            Controls.Add(ui_panel);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            MaximumSize = new Size(808, 442);
            MinimumSize = new Size(808, 442);
            Name = "Aimbot_UC";
            Size = new Size(808, 442);
            ui_panel.ResumeLayout(false);
            ui_panel.PerformLayout();
            ui2_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)preview_picture).EndInit();
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
        private Label label1;
        private PictureBox preview_picture;
        private CheckBox mouse_checkbox;
    }
}
