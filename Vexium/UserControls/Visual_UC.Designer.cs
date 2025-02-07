namespace Vexium.UserControls
{
    partial class Visual_UC
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
            wallhack_checkbox = new CheckBox();
            showshots_checkbox = new CheckBox();
            fullbright_checkbox = new CheckBox();
            whiteTexture_checkbox = new CheckBox();
            nosmoke_checkbox = new CheckBox();
            hitboxes_checkbox = new CheckBox();
            ui_panel = new Panel();
            showpos_checkbox = new CheckBox();
            shadow_checkbox = new CheckBox();
            tracers_checkbox = new CheckBox();
            panel1 = new Panel();
            minecraft_checkbox = new CheckBox();
            ui_label = new Label();
            ui2_label = new Label();
            wireframe_checkbox = new CheckBox();
            ui_panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // wallhack_checkbox
            // 
            wallhack_checkbox.AutoSize = true;
            wallhack_checkbox.Location = new Point(14, 12);
            wallhack_checkbox.Name = "wallhack_checkbox";
            wallhack_checkbox.Size = new Size(110, 26);
            wallhack_checkbox.TabIndex = 0;
            wallhack_checkbox.Text = "Wallhack";
            wallhack_checkbox.UseVisualStyleBackColor = true;
            wallhack_checkbox.CheckedChanged += wallhack_checkbox_CheckedChanged;
            // 
            // showshots_checkbox
            // 
            showshots_checkbox.AutoSize = true;
            showshots_checkbox.Location = new Point(14, 72);
            showshots_checkbox.Name = "showshots_checkbox";
            showshots_checkbox.Size = new Size(125, 26);
            showshots_checkbox.TabIndex = 2;
            showshots_checkbox.Text = "Show Shots";
            showshots_checkbox.UseVisualStyleBackColor = true;
            showshots_checkbox.CheckedChanged += showshots_checkbox_CheckedChanged;
            // 
            // fullbright_checkbox
            // 
            fullbright_checkbox.AutoSize = true;
            fullbright_checkbox.Location = new Point(14, 42);
            fullbright_checkbox.Name = "fullbright_checkbox";
            fullbright_checkbox.Size = new Size(107, 26);
            fullbright_checkbox.TabIndex = 3;
            fullbright_checkbox.Text = "Fullbright";
            fullbright_checkbox.UseVisualStyleBackColor = true;
            fullbright_checkbox.CheckedChanged += fullbright_checkbox_CheckedChanged;
            // 
            // whiteTexture_checkbox
            // 
            whiteTexture_checkbox.AutoSize = true;
            whiteTexture_checkbox.Location = new Point(14, 102);
            whiteTexture_checkbox.Name = "whiteTexture_checkbox";
            whiteTexture_checkbox.Size = new Size(154, 26);
            whiteTexture_checkbox.TabIndex = 4;
            whiteTexture_checkbox.Text = "White Textures";
            whiteTexture_checkbox.UseVisualStyleBackColor = true;
            whiteTexture_checkbox.CheckedChanged += whiteTexture_checkbox_CheckedChanged;
            // 
            // nosmoke_checkbox
            // 
            nosmoke_checkbox.AutoSize = true;
            nosmoke_checkbox.Location = new Point(14, 12);
            nosmoke_checkbox.Name = "nosmoke_checkbox";
            nosmoke_checkbox.Size = new Size(118, 26);
            nosmoke_checkbox.TabIndex = 5;
            nosmoke_checkbox.Text = "No smoke";
            nosmoke_checkbox.UseVisualStyleBackColor = true;
            nosmoke_checkbox.CheckedChanged += nosmoke_checkbox_CheckedChanged;
            // 
            // hitboxes_checkbox
            // 
            hitboxes_checkbox.AutoSize = true;
            hitboxes_checkbox.Location = new Point(14, 72);
            hitboxes_checkbox.Name = "hitboxes_checkbox";
            hitboxes_checkbox.Size = new Size(151, 26);
            hitboxes_checkbox.TabIndex = 6;
            hitboxes_checkbox.Text = "Players Hitbox";
            hitboxes_checkbox.UseVisualStyleBackColor = true;
            hitboxes_checkbox.CheckedChanged += hitboxes_checkbox_CheckedChanged;
            // 
            // ui_panel
            // 
            ui_panel.BackColor = Color.FromArgb(40, 40, 40);
            ui_panel.Controls.Add(showpos_checkbox);
            ui_panel.Controls.Add(shadow_checkbox);
            ui_panel.Controls.Add(tracers_checkbox);
            ui_panel.Controls.Add(hitboxes_checkbox);
            ui_panel.Controls.Add(wallhack_checkbox);
            ui_panel.Location = new Point(24, 66);
            ui_panel.Name = "ui_panel";
            ui_panel.Size = new Size(335, 451);
            ui_panel.TabIndex = 7;
            // 
            // showpos_checkbox
            // 
            showpos_checkbox.AutoSize = true;
            showpos_checkbox.Location = new Point(14, 132);
            showpos_checkbox.Name = "showpos_checkbox";
            showpos_checkbox.Size = new Size(148, 26);
            showpos_checkbox.TabIndex = 9;
            showpos_checkbox.Text = "Show position";
            showpos_checkbox.UseVisualStyleBackColor = true;
            showpos_checkbox.CheckedChanged += showpos_checkbox_CheckedChanged;
            // 
            // shadow_checkbox
            // 
            shadow_checkbox.AutoSize = true;
            shadow_checkbox.Location = new Point(14, 42);
            shadow_checkbox.Name = "shadow_checkbox";
            shadow_checkbox.Size = new Size(160, 26);
            shadow_checkbox.TabIndex = 8;
            shadow_checkbox.Text = "Shadow Frame";
            shadow_checkbox.UseVisualStyleBackColor = true;
            shadow_checkbox.CheckedChanged += shadow_checkbox_CheckedChanged;
            // 
            // tracers_checkbox
            // 
            tracers_checkbox.AutoSize = true;
            tracers_checkbox.Location = new Point(14, 102);
            tracers_checkbox.Name = "tracers_checkbox";
            tracers_checkbox.Size = new Size(93, 26);
            tracers_checkbox.TabIndex = 7;
            tracers_checkbox.Text = "Tracers";
            tracers_checkbox.UseVisualStyleBackColor = true;
            tracers_checkbox.CheckedChanged += tracers_checkbox_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(wireframe_checkbox);
            panel1.Controls.Add(minecraft_checkbox);
            panel1.Controls.Add(whiteTexture_checkbox);
            panel1.Controls.Add(fullbright_checkbox);
            panel1.Controls.Add(nosmoke_checkbox);
            panel1.Controls.Add(showshots_checkbox);
            panel1.Location = new Point(428, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 451);
            panel1.TabIndex = 8;
            // 
            // minecraft_checkbox
            // 
            minecraft_checkbox.AutoSize = true;
            minecraft_checkbox.Location = new Point(14, 132);
            minecraft_checkbox.Name = "minecraft_checkbox";
            minecraft_checkbox.Size = new Size(112, 26);
            minecraft_checkbox.TabIndex = 6;
            minecraft_checkbox.Text = "Minecraft";
            minecraft_checkbox.UseVisualStyleBackColor = true;
            minecraft_checkbox.CheckedChanged += minecraft_checkbox_CheckedChanged;
            // 
            // ui_label
            // 
            ui_label.AutoSize = true;
            ui_label.Location = new Point(24, 26);
            ui_label.Name = "ui_label";
            ui_label.Size = new Size(64, 22);
            ui_label.TabIndex = 9;
            ui_label.Text = "Player";
            // 
            // ui2_label
            // 
            ui2_label.AutoSize = true;
            ui2_label.Location = new Point(428, 26);
            ui2_label.Name = "ui2_label";
            ui2_label.Size = new Size(60, 22);
            ui2_label.TabIndex = 10;
            ui2_label.Text = "World";
            // 
            // wireframe_checkbox
            // 
            wireframe_checkbox.AutoSize = true;
            wireframe_checkbox.Location = new Point(14, 162);
            wireframe_checkbox.Name = "wireframe_checkbox";
            wireframe_checkbox.Size = new Size(119, 26);
            wireframe_checkbox.TabIndex = 7;
            wireframe_checkbox.Text = "Wireframe";
            wireframe_checkbox.UseVisualStyleBackColor = true;
            wireframe_checkbox.CheckedChanged += wireframe_checkbox_CheckedChanged;
            // 
            // Visual_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(ui2_label);
            Controls.Add(ui_label);
            Controls.Add(panel1);
            Controls.Add(ui_panel);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximumSize = new Size(805, 543);
            MinimumSize = new Size(805, 543);
            Name = "Visual_UC";
            Size = new Size(805, 543);
            ui_panel.ResumeLayout(false);
            ui_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox wallhack_checkbox;
        private CheckBox showshots_checkbox;
        private CheckBox fullbright_checkbox;
        private CheckBox whiteTexture_checkbox;
        private CheckBox nosmoke_checkbox;
        private CheckBox hitboxes_checkbox;
        private Panel ui_panel;
        private Panel panel1;
        private CheckBox tracers_checkbox;
        private Label ui_label;
        private Label ui2_label;
        private CheckBox minecraft_checkbox;
        private CheckBox shadow_checkbox;
        private CheckBox showpos_checkbox;
        private CheckBox wireframe_checkbox;
    }
}
