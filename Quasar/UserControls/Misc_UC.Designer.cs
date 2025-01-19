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
            triggerbot_checkbox = new CheckBox();
            bunnyhop_checkbox = new CheckBox();
            antiflash_checkbox = new CheckBox();
            ui_label = new Label();
            ui2_label = new Label();
            ui2_panel = new Panel();
            update_textbox = new TextBox();
            update_checkbox = new Label();
            getinformation_checkbox = new CheckBox();
            information_label = new Label();
            ui_panel.SuspendLayout();
            ui2_panel.SuspendLayout();
            SuspendLayout();
            // 
            // ui_panel
            // 
            ui_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui_panel.Controls.Add(triggerbot_checkbox);
            ui_panel.Controls.Add(bunnyhop_checkbox);
            ui_panel.Controls.Add(antiflash_checkbox);
            ui_panel.Location = new Point(24, 66);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(335, 121);
            ui_panel.TabIndex = 8;
            // 
            // triggerbot_checkbox
            // 
            triggerbot_checkbox.AutoSize = true;
            triggerbot_checkbox.Location = new Point(14, 75);
            triggerbot_checkbox.Name = "triggerbot_checkbox";
            triggerbot_checkbox.Size = new Size(118, 26);
            triggerbot_checkbox.TabIndex = 2;
            triggerbot_checkbox.Text = "Triggerbot";
            triggerbot_checkbox.UseVisualStyleBackColor = true;
            triggerbot_checkbox.CheckedChanged += triggerbot_checkbox_CheckedChanged;
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
            ui2_panel.Size = new Size(335, 345);
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
            // Misc_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ui_panel;
        private CheckBox tracers_checkbox;
        private CheckBox hitboxes_checkbox;
        private CheckBox antiflash_checkbox;
        private CheckBox wireframe_checkbox;
        private CheckBox bunnyhop_checkbox;
        private CheckBox triggerbot_checkbox;
        private Label ui_label;
        private Label ui2_label;
        private Panel ui2_panel;
        private Label information_label;
        private CheckBox getinformation_checkbox;
        private Label update_checkbox;
        private TextBox update_textbox;
    }
}
