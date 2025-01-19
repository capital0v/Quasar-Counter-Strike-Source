namespace Quasar.UserControls
{
    partial class Contacts_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts_UC));
            ui_panel = new Panel();
            panel1 = new Panel();
            telegram_picture = new PictureBox();
            github_picture = new PictureBox();
            ui2_label = new Label();
            ui_label = new Label();
            ui3_label = new Label();
            ui_panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)telegram_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)github_picture).BeginInit();
            SuspendLayout();
            // 
            // ui_panel
            // 
            ui_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui_panel.Controls.Add(ui3_label);
            ui_panel.Controls.Add(panel1);
            ui_panel.Controls.Add(ui2_label);
            ui_panel.Controls.Add(ui_label);
            ui_panel.Location = new Point(19, 20);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(769, 402);
            ui_panel.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(telegram_picture);
            panel1.Controls.Add(github_picture);
            panel1.Location = new Point(16, 52);
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
            // ui2_label
            // 
            ui2_label.AutoSize = true;
            ui2_label.Location = new Point(16, 363);
            ui2_label.Name = "ui2_label";
            ui2_label.Size = new Size(292, 22);
            ui2_label.TabIndex = 1;
            ui2_label.Text = "Email: danyacapital@gmail.com";
            // 
            // ui_label
            // 
            ui_label.AutoSize = true;
            ui_label.Location = new Point(16, 330);
            ui_label.Name = "ui_label";
            ui_label.Size = new Size(198, 22);
            ui_label.TabIndex = 0;
            ui_label.Text = "Software by capital0v";
            // 
            // ui3_label
            // 
            ui3_label.AutoSize = true;
            ui3_label.Location = new Point(16, 16);
            ui3_label.Name = "ui3_label";
            ui3_label.Size = new Size(224, 22);
            ui3_label.TabIndex = 4;
            ui3_label.Text = "My social medias (click)";
            // 
            // Contacts_UC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(ui_panel);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            MaximumSize = new Size(808, 442);
            MinimumSize = new Size(808, 442);
            Name = "Contacts_UC";
            Size = new Size(808, 442);
            ui_panel.ResumeLayout(false);
            ui_panel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)telegram_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)github_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ui_panel;
        private Label ui2_label;
        private Label ui_label;
        private PictureBox github_picture;
        private Panel panel1;
        private PictureBox telegram_picture;
        private Label ui3_label;
    }
}
