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
            ((System.ComponentModel.ISupportInitialize)(this.seznamPenez)).BeginInit();
            this.SuspendLayout();
            // 
            // seznamPenez
            // 
            this.seznamPenez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seznamPenez.Location = new System.Drawing.Point(0, 0);
            this.seznamPenez.Name = "seznamPenez";
            this.seznamPenez.Size = new System.Drawing.Size(286, 389);
            this.seznamPenez.TabIndex = 0;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(325, 354);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 1;
            this.next.Text = "Další";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 389);
            this.Controls.Add(this.next);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.seznamPenez);
            this.Name = "DataGridView";
            this.Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.seznamPenez)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView seznamPenez;
        private System.Windows.Forms.Button next;
    }
}