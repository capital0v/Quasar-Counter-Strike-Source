namespace Quasar.UserControls
{
    partial class Misc_UC
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
            ui_panel = new Panel();
            thirdperson_checkbox = new CheckBox();
            bunnyhop_checkbox = new CheckBox();
            antiflash_checkbox = new CheckBox();
            ui_label = new Label();
            ui2_label = new Label();
            ui2_panel = new Panel();
            update_textbox = new TextBox();
            update_checkbox = new Label();
            getinformation_checkbox = new CheckBox();
            information_label = new Label();
            label1 = new Label();
            panel1 = new Panel();
            clantag_button = new Button();
            ui3_label = new Label();
            clantag_textbox = new TextBox();
            nickname_button = new Button();
            label2 = new Label();
            nickname_textbox = new TextBox();
            thirdperson_checkbox = new CheckBox();
            ui_panel.SuspendLayout();
            ui2_panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ui_panel
            // 
            ui_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui_panel.Controls.Add(thirdperson_checkbox);
            ui_panel.Controls.Add(bunnyhop_checkbox);
            ui_panel.Controls.Add(antiflash_checkbox);
            ui_panel.Location = new Point(24, 66);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(335, 123);
            ui_panel.TabIndex = 8;
            // 
            // thirdperson_checkbox
            // 
            thirdperson_checkbox.AutoSize = true;
            thirdperson_checkbox.Location = new Point(14, 75);
            thirdperson_checkbox.Name = "thirdperson_checkbox";
            thirdperson_checkbox.Size = new Size(131, 26);
            thirdperson_checkbox.TabIndex = 2;
            thirdperson_checkbox.Text = "Thirdperson";
            thirdperson_checkbox.UseVisualStyleBackColor = true;
            thirdperson_checkbox.CheckedChanged += thirdperson_checkbox_CheckedChanged;
            // 
            // bunnyhop_checkbox
            // 
            bunnyhop_checkbox.AutoSize = true;
            bunnyhop_checkbox.Location = new Point(14, 45);
            bunnyhop_checkbox.Name = "bunnyhop_checkbox";
            bunnyhop_checkbox.Size = new Size(117, 26);
            bunnyhop_checkbox.TabIndex = 1;
            bunnyhop_checkbox.Text = "Bunnyhop";
            bunnyhop_checkbox.UseVisualStyleBackColor = true;
            bunnyhop_checkbox.CheckedChanged += bunnyhop_checkbox_CheckedChanged;
            // 
            // antiflash_checkbox
            // 
            antiflash_checkbox.AutoSize = true;
            antiflash_checkbox.Location = new Point(14, 15);
            antiflash_checkbox.Name = "antiflash_checkbox";
            antiflash_checkbox.Size = new Size(102, 26);
            antiflash_checkbox.TabIndex = 0;
            antiflash_checkbox.Text = "Antiflash";
            antiflash_checkbox.UseVisualStyleBackColor = true;
            antiflash_checkbox.CheckedChanged += antiflash_checkbox_CheckedChanged;
            // 
            // ui_label
            // 
            ui_label.AutoSize = true;
            ui_label.Location = new Point(24, 26);
            ui_label.Name = "ui_label";
            ui_label.Size = new Size(141, 22);
            ui_label.TabIndex = 10;
            ui_label.Text = "Main Functions";
            // 
            // ui2_label
            // 
            ui2_label.AutoSize = true;
            ui2_label.Location = new Point(428, 26);
            ui2_label.Name = "ui2_label";
            ui2_label.Size = new Size(110, 22);
            ui2_label.TabIndex = 11;
            ui2_label.Text = "Information";
            // 
            // ui2_panel
            // 
            ui2_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui2_panel.Controls.Add(update_textbox);
            ui2_panel.Controls.Add(update_checkbox);
            ui2_panel.Controls.Add(getinformation_checkbox);
            ui2_panel.Controls.Add(information_label);
            ui2_panel.Location = new Point(428, 66);
            ui2_panel.Name = "ui2_panel";
            ui2_panel.Size = new Size(335, 363);
            ui2_panel.TabIndex = 9;
            // 
            // update_textbox
            // 
            update_textbox.Location = new Point(14, 75);
            update_textbox.Name = "update_textbox";
            update_textbox.Size = new Size(83, 29);
            update_textbox.TabIndex = 14;
            update_textbox.Text = "100";
            update_textbox.TextChanged += update_textbox_TextChanged;
            // 
            // update_checkbox
            // 
            update_checkbox.AutoSize = true;
            update_checkbox.Location = new Point(14, 45);
            update_checkbox.Name = "update_checkbox";
            update_checkbox.Size = new Size(144, 22);
            update_checkbox.TabIndex = 13;
            update_checkbox.Text = "Update in (ms):";
            // 
            // getinformation_checkbox
            // 
            getinformation_checkbox.AutoSize = true;
            getinformation_checkbox.Location = new Point(14, 15);
            getinformation_checkbox.Name = "getinformation_checkbox";
            getinformation_checkbox.Size = new Size(166, 26);
            getinformation_checkbox.TabIndex = 3;
            getinformation_checkbox.Text = "Get Information";
            getinformation_checkbox.UseVisualStyleBackColor = true;
            getinformation_checkbox.CheckedChanged += getinformation_checkbox_CheckedChanged;
            // 
            // information_label
            // 
            information_label.AutoSize = true;
            information_label.Location = new Point(14, 125);
            information_label.Name = "information_label";
            information_label.Size = new Size(110, 22);
            information_label.TabIndex = 12;
            information_label.Text = "Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 202);
            label1.Name = "label1";
            label1.Size = new Size(257, 22);
            label1.TabIndex = 14;
            label1.Text = "Changer (Only NON_STEAM)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(clantag_button);
            panel1.Controls.Add(ui3_label);
            panel1.Controls.Add(clantag_textbox);
            panel1.Controls.Add(nickname_button);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nickname_textbox);
            panel1.Location = new Point(24, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 187);
            panel1.TabIndex = 13;
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
            ui3_label.Size = new Size(80, 22);
            ui3_label.TabIndex = 17;
            ui3_label.Text = "Clantag";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 13;
            label2.Text = "Nickname";
            // 
            // nickname_textbox
            // 
            nickname_textbox.Location = new Point(17, 50);
            nickname_textbox.Name = "nickname_textbox";
            nickname_textbox.Size = new Size(124, 29);
            nickname_textbox.TabIndex = 15;
            nickname_textbox.Text = "...";
            // 
            // thirdperson_checkbox
            // 
            thirdperson_checkbox.AutoSize = true;
            thirdperson_checkbox.Location = new Point(12, 75);
            thirdperson_checkbox.Name = "thirdperson_checkbox";
            thirdperson_checkbox.Size = new Size(131, 26);
            thirdperson_checkbox.TabIndex = 2;
            thirdperson_checkbox.Text = "Thirdperson";
            thirdperson_checkbox.UseVisualStyleBackColor = true;
            thirdperson_checkbox.CheckedChanged += thirdperson_checkbox_CheckedChanged;
            // 
            // Misc_UC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(ui2_panel);
            Controls.Add(ui2_label);
            Controls.Add(ui_label);
            Controls.Add(ui_panel);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximumSize = new Size(808, 442);
            MinimumSize = new Size(808, 442);
            Name = "Misc_UC";
            Size = new Size(808, 442);
            ui_panel.ResumeLayout(false);
            ui_panel.PerformLayout();
            ui2_panel.ResumeLayout(false);
            ui2_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ui_panel;
        private CheckBox tracers_checkbox;
        private CheckBox hitboxes_checkbox;
        private CheckBox antiflash_checkbox;
        private CheckBox bunnyhop_checkbox;
        private Label ui_label;
        private Label ui2_label;
        private Panel ui2_panel;
        private Label information_label;
        private CheckBox getinformation_checkbox;
        private Label update_checkbox;
        private TextBox update_textbox;
        private Label label1;
        private Panel panel1;
        private Button clantag_button;
        private Label ui3_label;
        private TextBox clantag_textbox;
        private Button nickname_button;
        private Label label2;
        private TextBox nickname_textbox;
        private CheckBox thirdperson_checkbox;
    }
}
