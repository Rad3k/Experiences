namespace Evidence_zaměstnanců
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameOrEmail = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.LoginToProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 97);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(55, 20);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Heslo";
            // 
            // usernameOrEmail
            // 
            this.usernameOrEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.usernameOrEmail.AutoSize = true;
            this.usernameOrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameOrEmail.Location = new System.Drawing.Point(12, 29);
            this.usernameOrEmail.Name = "usernameOrEmail";
            this.usernameOrEmail.Size = new System.Drawing.Size(249, 20);
            this.usernameOrEmail.TabIndex = 1;
            this.usernameOrEmail.Text = "Přihlašovací jméno nebo email";
            this.usernameOrEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(16, 61);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(245, 20);
            this.loginText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(16, 132);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(245, 20);
            this.passwordText.TabIndex = 3;
            // 
            // LoginToProgram
            // 
            this.LoginToProgram.Location = new System.Drawing.Point(186, 208);
            this.LoginToProgram.Name = "LoginToProgram";
            this.LoginToProgram.Size = new System.Drawing.Size(75, 23);
            this.LoginToProgram.TabIndex = 4;
            this.LoginToProgram.Text = "Continue";
            this.LoginToProgram.UseVisualStyleBackColor = true;
            this.LoginToProgram.Click += new System.EventHandler(this.LoginToProgram_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.LoginToProgram);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.usernameOrEmail);
            this.Controls.Add(this.passwordLabel);
            this.Name = "Login";
            this.Text = "Přihlašovací údaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameOrEmail;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button LoginToProgram;
    }
}