namespace Predfakturace
{
    partial class DataGridView
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
            this.seznamPenez = new System.Windows.Forms.DataGridView();
            this.next = new System.Windows.Forms.Button();
            this.traceToFile = new System.Windows.Forms.Button();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seznamPenez)).BeginInit();
            this.SuspendLayout();
            // 
            // seznamPenez
            // 
            this.seznamPenez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seznamPenez.Location = new System.Drawing.Point(0, 0);
            this.seznamPenez.Name = "seznamPenez";
            this.seznamPenez.Size = new System.Drawing.Size(138, 389);
            this.seznamPenez.TabIndex = 0;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(298, 343);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(102, 34);
            this.next.TabIndex = 1;
            this.next.Text = "Dokončit";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // traceToFile
            // 
            this.traceToFile.Location = new System.Drawing.Point(369, 12);
            this.traceToFile.Name = "traceToFile";
            this.traceToFile.Size = new System.Drawing.Size(31, 21);
            this.traceToFile.TabIndex = 2;
            this.traceToFile.Text = "...";
            this.traceToFile.UseVisualStyleBackColor = true;
            this.traceToFile.Click += new System.EventHandler(this.traceToFile_Click);
            // 
            // filePathText
            // 
            this.filePathText.Location = new System.Drawing.Point(159, 12);
            this.filePathText.Name = "filePathText";
            this.filePathText.ReadOnly = true;
            this.filePathText.Size = new System.Drawing.Size(204, 20);
            this.filePathText.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(159, 343);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(102, 34);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Zavřít";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 389);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.traceToFile);
            this.Controls.Add(this.next);
            this.Controls.Add(this.seznamPenez);
            this.Name = "DataGridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.seznamPenez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView seznamPenez;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button traceToFile;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Button cancel;
    }
}