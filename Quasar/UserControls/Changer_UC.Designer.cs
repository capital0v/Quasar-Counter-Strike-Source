namespace Quasar.UserControls
{
    partial class Changer_UC
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
            ui_label = new Label();
            ui_panel = new Panel();
            clantag_button = new Button();
            ui3_label = new Label();
            clantag_textbox = new TextBox();
            nickname_button = new Button();
            ui2_label = new Label();
            nickname_textbox = new TextBox();
            ui_panel.SuspendLayout();
            SuspendLayout();
            // 
            // ui_label
            // 
            ui_label.AutoSize = true;
            ui_label.Location = new Point(21, 20);
            ui_label.Name = "ui_label";
            ui_label.Size = new Size(464, 22);
            ui_label.TabIndex = 12;
            ui_label.Text = "Experimental (Only works after restarting the match)";
            // 
            // ui_panel
            // 
            ui_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui_panel.Controls.Add(clantag_button);
            ui_panel.Controls.Add(ui3_label);
            ui_panel.Controls.Add(clantag_textbox);
            ui_panel.Controls.Add(nickname_button);
            ui_panel.Controls.Add(ui2_label);
            ui_panel.Controls.Add(nickname_textbox);
            ui_panel.Location = new Point(21, 60);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(335, 230);
            ui_panel.TabIndex = 11;
            // 
            // clantag_button
            // 
            clantag_button.BackColor = Color.FromArgb(40, 40, 40);
            clantag_button.FlatStyle = FlatStyle.Flat;
            clantag_button.Location = new Point(189, 143);
            clantag_button.Name = "clantag_button";
            clantag_button.Size = new Size(124, 29);
            clantag_button.TabIndex = 16;
            clantag_button.Text = "Confirm";
            clantag_button.UseVisualStyleBackColor = false;
            clantag_button.Click += clantag_button_Click;
            // 
            // ui3_label
            // 
            ui3_label.AutoSize = true;
            ui3_label.Location = new Point(12, 107);
            ui3_label.Name = "ui3_label";
            ui3_label.Size = new Size(101, 22);
            ui3_label.TabIndex = 17;
            ui3_label.Text = "Nickname";
            // 
            // clantag_textbox
            // 
            clantag_textbox.Location = new Point(17, 143);
            clantag_textbox.Name = "clantag_textbox";
            clantag_textbox.Size = new Size(124, 29);
            clantag_textbox.TabIndex = 18;
            clantag_textbox.Text = "...";
            // 
            // nickname_button
            // 
            nickname_button.BackColor = Color.FromArgb(40, 40, 40);
            nickname_button.FlatStyle = FlatStyle.Flat;
            nickname_button.Location = new Point(189, 50);
            nickname_button.Name = "nickname_button";
            nickname_button.Size = new Size(124, 29);
            nickname_button.TabIndex = 13;
            nickname_button.Text = "Confirm";
            nickname_button.UseVisualStyleBackColor = false;
            nickname_button.Click += nickname_button_Click;
            // 
            // ui2_label
            // 
            ui2_label.AutoSize = true;
            ui2_label.Location = new Point(12, 14);
            ui2_label.Name = "ui2_label";
            ui2_label.Size = new Size(101, 22);
            ui2_label.TabIndex = 13;
            ui2_label.Text = "Nickname";
            // 
            // nickname_textbox
            // 
            nickname_textbox.Location = new Point(17, 50);
            nickname_textbox.Name = "nickname_textbox";
            nickname_textbox.Size = new Size(124, 29);
            nickname_textbox.TabIndex = 15;
            nickname_textbox.Text = "...";
            // 
            // Server_UC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(ui_label);
            Controls.Add(ui_panel);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            MaximumSize = new Size(808, 442);
            MinimumSize = new Size(808, 442);
            Name = "Server_UC";
            Size = new Size(808, 442);
            ui_panel.ResumeLayout(false);
            ui_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ui_label;
        private Panel ui_panel;
        private Label ui2_label;
        private TextBox nickname_textbox;
        private Button clantag_button;
        private Label ui3_label;
        private TextBox clantag_textbox;
        private Button nickname_button;
    }
}
