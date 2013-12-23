namespace Evidence_zaměstnanců
{
    partial class odstraneniUzivatele
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
            this.jmeno = new System.Windows.Forms.Label();
            this.jmenoText = new System.Windows.Forms.TextBox();
            this.prijmeni = new System.Windows.Forms.Label();
            this.prijmeniText = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jmeno
            // 
            this.jmeno.AutoSize = true;
            this.jmeno.Location = new System.Drawing.Point(12, 64);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(38, 13);
            this.jmeno.TabIndex = 0;
            this.jmeno.Text = "Jméno";
            // 
            // jmenoText
            // 
            this.jmenoText.Location = new System.Drawing.Point(64, 61);
            this.jmenoText.Name = "jmenoText";
            this.jmenoText.Size = new System.Drawing.Size(100, 20);
            this.jmenoText.TabIndex = 1;
            // 
            // prijmeni
            // 
            this.prijmeni.AutoSize = true;
            this.prijmeni.Location = new System.Drawing.Point(12, 90);
            this.prijmeni.Name = "prijmeni";
            this.prijmeni.Size = new System.Drawing.Size(46, 13);
            this.prijmeni.TabIndex = 2;
            this.prijmeni.Text = "Přijmění";
            // 
            // prijmeniText
            // 
            this.prijmeniText.Location = new System.Drawing.Point(64, 87);
            this.prijmeniText.Name = "prijmeniText";
            this.prijmeniText.Size = new System.Drawing.Size(100, 20);
            this.prijmeniText.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(15, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(257, 35);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Vyplňte pole podle kterého nalezneme uživatele k odstranění.\r\n";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(170, 61);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 46);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // odstraneniUzivatele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 121);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.prijmeniText);
            this.Controls.Add(this.prijmeni);
            this.Controls.Add(this.jmenoText);
            this.Controls.Add(this.jmeno);
            this.Name = "odstraneniUzivatele";
            this.Text = "Odstranit uživatele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jmeno;
        private System.Windows.Forms.TextBox jmenoText;
        private System.Windows.Forms.Label prijmeni;
        private System.Windows.Forms.TextBox prijmeniText;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button delete;
    }
}