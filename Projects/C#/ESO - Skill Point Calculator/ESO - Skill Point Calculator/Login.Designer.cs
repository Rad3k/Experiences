namespace ESO___Skill_Point_Calculator
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.forgetPassword = new System.Windows.Forms.LinkLabel();
            this.forgetUsername = new System.Windows.Forms.LinkLabel();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.myWebsiteButton = new System.Windows.Forms.Button();
            this.InterestButton = new System.Windows.Forms.Button();
            this.minimalizedButton = new System.Windows.Forms.Button();
            this.maximizedButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.beta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forgetPassword
            // 
            this.forgetPassword.AutoSize = true;
            this.forgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.forgetPassword.LinkColor = System.Drawing.Color.Red;
            this.forgetPassword.Location = new System.Drawing.Point(155, 357);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(91, 13);
            this.forgetPassword.TabIndex = 0;
            this.forgetPassword.TabStop = true;
            this.forgetPassword.Text = "Forget password?";
            this.forgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPassword_LinkClicked);
            // 
            // forgetUsername
            // 
            this.forgetUsername.AutoSize = true;
            this.forgetUsername.BackColor = System.Drawing.Color.Transparent;
            this.forgetUsername.LinkColor = System.Drawing.Color.Red;
            this.forgetUsername.Location = new System.Drawing.Point(154, 385);
            this.forgetUsername.Name = "forgetUsername";
            this.forgetUsername.Size = new System.Drawing.Size(92, 13);
            this.forgetUsername.TabIndex = 1;
            this.forgetUsername.TabStop = true;
            this.forgetUsername.Text = "Forget username?";
            this.forgetUsername.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetUsername_LinkClicked);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(269, 382);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(255, 20);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "password";
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(269, 354);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(255, 20);
            this.usernameText.TabIndex = 3;
            this.usernameText.Text = "username";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.Login;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(553, 354);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(76, 49);
            this.loginButton.TabIndex = 4;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.Register;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Location = new System.Drawing.Point(321, 435);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(149, 55);
            this.registerButton.TabIndex = 5;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.MouseEnter += new System.EventHandler(this.registerButton_MouseEnter);
            this.registerButton.MouseLeave += new System.EventHandler(this.registerButton_MouseLeave);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.Cancel;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(332, 496);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 54);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
            // 
            // myWebsiteButton
            // 
            this.myWebsiteButton.BackColor = System.Drawing.Color.Transparent;
            this.myWebsiteButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.Radek;
            this.myWebsiteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myWebsiteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myWebsiteButton.FlatAppearance.BorderSize = 0;
            this.myWebsiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myWebsiteButton.Location = new System.Drawing.Point(157, 447);
            this.myWebsiteButton.Name = "myWebsiteButton";
            this.myWebsiteButton.Size = new System.Drawing.Size(89, 92);
            this.myWebsiteButton.TabIndex = 7;
            this.myWebsiteButton.UseVisualStyleBackColor = false;
            this.myWebsiteButton.Click += new System.EventHandler(this.myWebsiteButton_Click);
            // 
            // InterestButton
            // 
            this.InterestButton.BackColor = System.Drawing.Color.Transparent;
            this.InterestButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.TESOcz;
            this.InterestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InterestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InterestButton.FlatAppearance.BorderSize = 0;
            this.InterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InterestButton.Location = new System.Drawing.Point(522, 447);
            this.InterestButton.Name = "InterestButton";
            this.InterestButton.Size = new System.Drawing.Size(131, 92);
            this.InterestButton.TabIndex = 8;
            this.InterestButton.UseVisualStyleBackColor = false;
            this.InterestButton.Click += new System.EventHandler(this.InterestButton_Click);
            // 
            // minimalizedButton
            // 
            this.minimalizedButton.BackColor = System.Drawing.Color.Transparent;
            this.minimalizedButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.min;
            this.minimalizedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimalizedButton.FlatAppearance.BorderSize = 0;
            this.minimalizedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimalizedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimalizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizedButton.Location = new System.Drawing.Point(689, 12);
            this.minimalizedButton.Name = "minimalizedButton";
            this.minimalizedButton.Size = new System.Drawing.Size(29, 23);
            this.minimalizedButton.TabIndex = 9;
            this.minimalizedButton.UseVisualStyleBackColor = false;
            this.minimalizedButton.Click += new System.EventHandler(this.minimalizedButton_Click);
            this.minimalizedButton.MouseEnter += new System.EventHandler(this.minimalizedButton_MouseEnter);
            this.minimalizedButton.MouseLeave += new System.EventHandler(this.minimalizedButton_MouseLeave);
            // 
            // maximizedButton
            // 
            this.maximizedButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizedButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.max;
            this.maximizedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizedButton.FlatAppearance.BorderSize = 0;
            this.maximizedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.maximizedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.maximizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizedButton.Location = new System.Drawing.Point(724, 12);
            this.maximizedButton.Name = "maximizedButton";
            this.maximizedButton.Size = new System.Drawing.Size(29, 23);
            this.maximizedButton.TabIndex = 10;
            this.maximizedButton.UseVisualStyleBackColor = false;
            this.maximizedButton.Click += new System.EventHandler(this.maximizedButton_Click);
            this.maximizedButton.MouseEnter += new System.EventHandler(this.maximizedButton_MouseEnter);
            this.maximizedButton.MouseLeave += new System.EventHandler(this.maximizedButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.close;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(759, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(29, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(196)))), ((int)(((byte)(181)))));
            this.version.Location = new System.Drawing.Point(651, 408);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(77, 13);
            this.version.TabIndex = 12;
            this.version.Text = "version: 0.3.6a";
            // 
            // beta
            // 
            this.beta.AutoSize = true;
            this.beta.BackColor = System.Drawing.Color.Transparent;
            this.beta.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(196)))), ((int)(((byte)(181)))));
            this.beta.Location = new System.Drawing.Point(352, 174);
            this.beta.Name = "beta";
            this.beta.Size = new System.Drawing.Size(72, 28);
            this.beta.TabIndex = 13;
            this.beta.Text = "BETA";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ESO___Skill_Point_Calculator.Properties.Resources.background_800_600;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.beta);
            this.Controls.Add(this.version);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.maximizedButton);
            this.Controls.Add(this.minimalizedButton);
            this.Controls.Add(this.InterestButton);
            this.Controls.Add(this.myWebsiteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.forgetUsername);
            this.Controls.Add(this.forgetPassword);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel forgetPassword;
        private System.Windows.Forms.LinkLabel forgetUsername;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button myWebsiteButton;
        private System.Windows.Forms.Button InterestButton;
        private System.Windows.Forms.Button minimalizedButton;
        private System.Windows.Forms.Button maximizedButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label beta;
    }
}

