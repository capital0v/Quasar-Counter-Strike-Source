namespace Quasar.UserControls
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
            wireframe_checkbox = new CheckBox();
            showshots_checkbox = new CheckBox();
            fullbright_checkbox = new CheckBox();
            whiteTexture_checkbox = new CheckBox();
            SuspendLayout();
            // 
            // wallhack_checkbox
            // 
            wallhack_checkbox.AutoSize = true;
            wallhack_checkbox.Location = new Point(33, 34);
            wallhack_checkbox.Name = "wallhack_checkbox";
            wallhack_checkbox.Size = new Size(110, 26);
            wallhack_checkbox.TabIndex = 0;
            wallhack_checkbox.Text = "Wallhack";
            wallhack_checkbox.UseVisualStyleBackColor = true;
            wallhack_checkbox.CheckedChanged += wallhack_checkbox_CheckedChanged;
            // 
            // wireframe_checkbox
            // 
            wireframe_checkbox.AutoSize = true;
            wireframe_checkbox.Location = new Point(33, 75);
            wireframe_checkbox.Name = "wireframe_checkbox";
            wireframe_checkbox.Size = new Size(119, 26);
            wireframe_checkbox.TabIndex = 1;
            wireframe_checkbox.Text = "Wireframe";
            wireframe_checkbox.UseVisualStyleBackColor = true;
            wireframe_checkbox.CheckedChanged += wireframe_checkbox_CheckedChanged;
            // 
            // showshots_checkbox
            // 
            showshots_checkbox.AutoSize = true;
            showshots_checkbox.Location = new Point(33, 117);
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
            fullbright_checkbox.Location = new Point(33, 159);
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
            whiteTexture_checkbox.Location = new Point(33, 204);
            whiteTexture_checkbox.Name = "whiteTexture_checkbox";
            whiteTexture_checkbox.Size = new Size(146, 26);
            whiteTexture_checkbox.TabIndex = 4;
            whiteTexture_checkbox.Text = "White Texture";
            whiteTexture_checkbox.UseVisualStyleBackColor = true;
            whiteTexture_checkbox.CheckedChanged += whiteTexture_checkbox_CheckedChanged;
            // 
            // Visual_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(whiteTexture_checkbox);
            Controls.Add(fullbright_checkbox);
            Controls.Add(showshots_checkbox);
            Controls.Add(wireframe_checkbox);
            Controls.Add(wallhack_checkbox);
            Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximumSize = new Size(808, 442);
            MinimumSize = new Size(808, 442);
            Name = "Visual_UC";
            Size = new Size(808, 442);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox wallhack_checkbox;
        private CheckBox wireframe_checkbox;
        private CheckBox showshots_checkbox;
        private CheckBox fullbright_checkbox;
        private CheckBox whiteTexture_checkbox;
    }
}
