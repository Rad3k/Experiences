namespace Evidence_zaměstnanců
{
    partial class ChangePassword
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
            this.oldPassword = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.Label();
            this.newPasswordText = new System.Windows.Forms.TextBox();
            this.oldPasswordText = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPassword
            // 
            this.oldPassword.AutoSize = true;
            this.oldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oldPassword.Location = new System.Drawing.Point(12, 15);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(75, 13);
            this.oldPassword.TabIndex = 0;
            this.oldPassword.Text = "Staré heslo:";
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPassword.Location = new System.Drawing.Point(12, 41);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(75, 13);
            this.newPassword.TabIndex = 1;
            this.newPassword.Text = "Nové heslo:";
            // 
            // newPasswordText
            // 
            this.newPasswordText.Location = new System.Drawing.Point(90, 38);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.Size = new System.Drawing.Size(156, 20);
            this.newPasswordText.TabIndex = 2;
            // 
            // oldPasswordText
            // 
            this.oldPasswordText.Location = new System.Drawing.Point(90, 12);
            this.oldPasswordText.Name = "oldPasswordText";
            this.oldPasswordText.Size = new System.Drawing.Size(156, 20);
            this.oldPasswordText.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 69);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(171, 69);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 6;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 104);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.oldPasswordText);
            this.Controls.Add(this.newPasswordText);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.oldPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPassword;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox newPasswordText;
        private System.Windows.Forms.TextBox oldPasswordText;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button finish;
    }
}