namespace ESO___Skill_Point_Calculator
{
    partial class buildEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buildEditor));
            this.minimalizedButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minimalizedButton
            // 
            this.minimalizedButton.BackColor = System.Drawing.Color.Transparent;
            this.minimalizedButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.min_transparent1;
            this.minimalizedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimalizedButton.FlatAppearance.BorderSize = 0;
            this.minimalizedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimalizedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimalizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizedButton.Location = new System.Drawing.Point(817, 127);
            this.minimalizedButton.Name = "minimalizedButton";
            this.minimalizedButton.Size = new System.Drawing.Size(22, 22);
            this.minimalizedButton.TabIndex = 0;
            this.minimalizedButton.UseVisualStyleBackColor = false;
            this.minimalizedButton.Click += new System.EventHandler(this.minimalizedButton_Click);
            this.minimalizedButton.MouseEnter += new System.EventHandler(this.minimalizedButton_MouseEnter);
            this.minimalizedButton.MouseLeave += new System.EventHandler(this.minimalizedButton_MouseLeave);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.about_transparent;
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(845, 127);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(22, 22);
            this.helpButton.TabIndex = 1;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            this.helpButton.MouseEnter += new System.EventHandler(this.helpButton_MouseEnter);
            this.helpButton.MouseLeave += new System.EventHandler(this.helpButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.close_transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(873, 127);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(22, 22);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // buildEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::ESO___Skill_Point_Calculator.BuildResource.build_editor_window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 860);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.minimalizedButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buildEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESO - Build editor";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minimalizedButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
    }
}