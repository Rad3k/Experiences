namespace Evidence_zaměstnanců
{
    partial class addCVs
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
            this.traceToFileLabel = new System.Windows.Forms.Label();
            this.traceToFileText = new System.Windows.Forms.TextBox();
            this.finish = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.traceToFile = new System.Windows.Forms.Button();
            this.identityLabel = new System.Windows.Forms.Label();
            this.jmeno = new System.Windows.Forms.Label();
            this.prijmeni = new System.Windows.Forms.Label();
            this.prijmeniText = new System.Windows.Forms.TextBox();
            this.jmenoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // traceToFileLabel
            // 
            this.traceToFileLabel.AutoSize = true;
            this.traceToFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.traceToFileLabel.Location = new System.Drawing.Point(25, 24);
            this.traceToFileLabel.Name = "traceToFileLabel";
            this.traceToFileLabel.Size = new System.Drawing.Size(188, 16);
            this.traceToFileLabel.TabIndex = 0;
            this.traceToFileLabel.Text = "Zadejte cestu k životopisu";
            // 
            // traceToFileText
            // 
            this.traceToFileText.Location = new System.Drawing.Point(28, 54);
            this.traceToFileText.Name = "traceToFileText";
            this.traceToFileText.ReadOnly = true;
            this.traceToFileText.Size = new System.Drawing.Size(185, 20);
            this.traceToFileText.TabIndex = 1;
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(171, 162);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 2;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(28, 162);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // traceToFile
            // 
            this.traceToFile.Location = new System.Drawing.Point(219, 52);
            this.traceToFile.Name = "traceToFile";
            this.traceToFile.Size = new System.Drawing.Size(27, 23);
            this.traceToFile.TabIndex = 4;
            this.traceToFile.Text = "...";
            this.traceToFile.UseVisualStyleBackColor = true;
            this.traceToFile.Click += new System.EventHandler(this.traceToFile_Click);
            // 
            // identityLabel
            // 
            this.identityLabel.AutoSize = true;
            this.identityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.identityLabel.Location = new System.Drawing.Point(25, 86);
            this.identityLabel.Name = "identityLabel";
            this.identityLabel.Size = new System.Drawing.Size(96, 16);
            this.identityLabel.TabIndex = 5;
            this.identityLabel.Text = "Indentifikace";
            // 
            // jmeno
            // 
            this.jmeno.AutoSize = true;
            this.jmeno.Location = new System.Drawing.Point(25, 113);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(41, 13);
            this.jmeno.TabIndex = 6;
            this.jmeno.Text = "Jméno:";
            // 
            // prijmeni
            // 
            this.prijmeni.AutoSize = true;
            this.prijmeni.Location = new System.Drawing.Point(140, 113);
            this.prijmeni.Name = "prijmeni";
            this.prijmeni.Size = new System.Drawing.Size(46, 13);
            this.prijmeni.TabIndex = 7;
            this.prijmeni.Text = "Přijmení";
            // 
            // prijmeniText
            // 
            this.prijmeniText.Location = new System.Drawing.Point(140, 129);
            this.prijmeniText.Name = "prijmeniText";
            this.prijmeniText.Size = new System.Drawing.Size(100, 20);
            this.prijmeniText.TabIndex = 8;
            // 
            // jmenoText
            // 
            this.jmenoText.Location = new System.Drawing.Point(28, 129);
            this.jmenoText.Name = "jmenoText";
            this.jmenoText.Size = new System.Drawing.Size(100, 20);
            this.jmenoText.TabIndex = 9;
            // 
            // addCVs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 197);
            this.Controls.Add(this.jmenoText);
            this.Controls.Add(this.prijmeniText);
            this.Controls.Add(this.prijmeni);
            this.Controls.Add(this.jmeno);
            this.Controls.Add(this.identityLabel);
            this.Controls.Add(this.traceToFile);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.traceToFileText);
            this.Controls.Add(this.traceToFileLabel);
            this.Name = "addCVs";
            this.Text = "Přidat životopis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label traceToFileLabel;
        private System.Windows.Forms.TextBox traceToFileText;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button traceToFile;
        private System.Windows.Forms.Label identityLabel;
        private System.Windows.Forms.Label jmeno;
        private System.Windows.Forms.Label prijmeni;
        private System.Windows.Forms.TextBox prijmeniText;
        private System.Windows.Forms.TextBox jmenoText;
    }
}