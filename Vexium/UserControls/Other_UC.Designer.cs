namespace Vexium.UserControls
{
    partial class Other_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Other_UC));
            ui_panel = new Panel();
            turnoffall_button = new Button();
            saveoffsets_button = new Button();
            colortransition_checkbox = new CheckBox();
            ui3_label = new Label();
            panel1 = new Panel();
            telegram_picture = new PictureBox();
            github_picture = new PictureBox();
            ui_label = new Label();
            ui_panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)telegram_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)github_picture).BeginInit();
            SuspendLayout();
            // 
            // ui_panel
            // 
            ui_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui_panel.Controls.Add(turnoffall_button);
            ui_panel.Controls.Add(saveoffsets_button);
            ui_panel.Controls.Add(colortransition_checkbox);
            ui_panel.Controls.Add(ui3_label);
            ui_panel.Controls.Add(panel1);
            ui_panel.Controls.Add(ui_label);
            ui_panel.Location = new Point(19, 20);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(769, 500);
            ui_panel.TabIndex = 9;
            // 
            // turnoffall_button
            // 
            turnoffall_button.BackColor = Color.FromArgb(40, 40, 40);
            turnoffall_button.FlatStyle = FlatStyle.Flat;
            turnoffall_button.Location = new Point(575, 73);
            turnoffall_button.Name = "turnoffall_button";
            turnoffall_button.Size = new Size(178, 32);
            turnoffall_button.TabIndex = 11;
            turnoffall_button.Text = "Turn off all";
            turnoffall_button.UseVisualStyleBackColor = false;
            turnoffall_button.Click += turnoffall_button_Click;
            // 
            // saveoffsets_button
            // 
            saveoffsets_button.BackColor = Color.FromArgb(40, 40, 40);
            saveoffsets_button.FlatStyle = FlatStyle.Flat;
            saveoffsets_button.Location = new Point(575, 23);
            saveoffsets_button.Name = "saveoffsets_button";
            saveoffsets_button.Size = new Size(178, 32);
            saveoffsets_button.TabIndex = 10;
            saveoffsets_button.Text = "Save offsets";
            saveoffsets_button.UseVisualStyleBackColor = false;
            saveoffsets_button.Click += saveoffsets_button_Click;
            // 
            // colortransition_checkbox
            // 
            colortransition_checkbox.AutoSize = true;
            colortransition_checkbox.Location = new Point(15, 23);
            colortransition_checkbox.Name = "colortransition_checkbox";
            colortransition_checkbox.Size = new Size(218, 26);
            colortransition_checkbox.TabIndex = 5;
            colortransition_checkbox.Text = "Menu Color Transition";
            colortransition_checkbox.UseVisualStyleBackColor = true;
            colortransition_checkbox.CheckedChanged += colortransition_checkbox_CheckedChanged;
            // 
            // ui3_label
            // 
            ui3_label.AutoSize = true;
            ui3_label.Location = new Point(15, 75);
            ui3_label.Name = "ui3_label";
            ui3_label.Size = new Size(291, 22);
            ui3_label.TabIndex = 4;
            ui3_label.Text = "Developer social medias (click)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(telegram_picture);
            panel1.Controls.Add(github_picture);
            panel1.Location = new Point(15, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 188);
            panel1.TabIndex = 3;
            // 
            // telegram_picture
            // 
            telegram_picture.Image = (Image)resources.GetObject("telegram_picture.Image");
            telegram_picture.Location = new Point(226, 17);
            telegram_picture.Name = "telegram_picture";
            telegram_picture.Size = new Size(144, 144);
            telegram_picture.SizeMode = PictureBoxSizeMode.Zoom;
            telegram_picture.TabIndex = 3;
            telegram_picture.TabStop = false;
            telegram_picture.Click += telegram_picture_Click;
            // 
            // github_picture
            // 
            github_picture.Image = Properties.Resources.Github;
            github_picture.Location = new Point(23, 17);
            github_picture.Name = "github_picture";
            github_picture.Size = new Size(144, 144);
            github_picture.SizeMode = PictureBoxSizeMode.Zoom;
            github_picture.TabIndex = 2;
            github_picture.TabStop = false;
            github_picture.Click += github_picture_Click;
            // 
            // ui_label
            // 
            ui_label.AutoSize = true;
            ui_label.Location = new Point(15, 460);
            ui_label.Name = "ui_label";
            ui_label.Size = new Size(198, 22);
            ui_label.TabIndex = 0;
            ui_label.Text = "Software by capital0v";
            // 
            // Other_UC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(ui_panel);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            MaximumSize = new Size(805, 543);
            MinimumSize = new Size(805, 543);
            Name = "Other_UC";
            Size = new Size(805, 543);
            ui_panel.ResumeLayout(false);
            ui_panel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)telegram_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)github_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ui_panel;
        private Label ui_label;
        private PictureBox github_picture;
        private Panel panel1;
        private PictureBox telegram_picture;
        private Label ui3_label;
        private CheckBox colortransition_checkbox;
        private Button saveoffsets_button;
        private Button turnoffall_button;
    }
}
