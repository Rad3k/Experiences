namespace Evidence_zaměstnanců
{
    partial class delCVs
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
            this.jmenoText = new System.Windows.Forms.TextBox();
            this.prijmeniText = new System.Windows.Forms.TextBox();
            this.prijmeni = new System.Windows.Forms.Label();
            this.jmeno = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jmenoText
            // 
            this.jmenoText.Location = new System.Drawing.Point(35, 41);
            this.jmenoText.Name = "jmenoText";
            this.jmenoText.Size = new System.Drawing.Size(100, 20);
            this.jmenoText.TabIndex = 14;
            // 
            // prijmeniText
            // 
            this.prijmeniText.Location = new System.Drawing.Point(147, 41);
            this.prijmeniText.Name = "prijmeniText";
            this.prijmeniText.Size = new System.Drawing.Size(100, 20);
            this.prijmeniText.TabIndex = 13;
            // 
            // prijmeni
            // 
            this.prijmeni.AutoSize = true;
            this.prijmeni.Location = new System.Drawing.Point(144, 25);
            this.prijmeni.Name = "prijmeni";
            this.prijmeni.Size = new System.Drawing.Size(46, 13);
            this.prijmeni.TabIndex = 12;
            this.prijmeni.Text = "Přijmení";
            // 
            // jmeno
            // 
            this.jmeno.AutoSize = true;
            this.jmeno.Location = new System.Drawing.Point(32, 25);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(41, 13);
            this.jmeno.TabIndex = 11;
            this.jmeno.Text = "Jméno:";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(35, 79);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(172, 79);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // delCVs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.jmenoText);
            this.Controls.Add(this.prijmeniText);
            this.Controls.Add(this.prijmeni);
            this.Controls.Add(this.jmeno);
            this.Name = "delCVs";
            this.Text = "Odstranění životopisu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jmenoText;
        private System.Windows.Forms.TextBox prijmeniText;
        private System.Windows.Forms.Label prijmeni;
        private System.Windows.Forms.Label jmeno;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
    }
}