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
            bunnyhop_checkbox = new CheckBox();
            antiflash_checkbox = new CheckBox();
            triggerbot_checkbox = new CheckBox();
            ui_panel.SuspendLayout();
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
            ui_panel.Size = new Size(335, 345);
            ui_panel.TabIndex = 8;
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
            // Misc_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel ui_panel;
        private CheckBox tracers_checkbox;
        private CheckBox hitboxes_checkbox;
        private CheckBox antiflash_checkbox;
        private CheckBox wireframe_checkbox;
        private CheckBox bunnyhop_checkbox;
        private CheckBox triggerbot_checkbox;
    }
}
