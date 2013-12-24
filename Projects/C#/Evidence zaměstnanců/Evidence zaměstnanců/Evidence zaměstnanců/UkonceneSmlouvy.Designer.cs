namespace Evidence_zaměstnanců
{
    partial class ukonceneSmlouvy
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
            this.reportSmlouvy = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportSmlouvy
            // 
            this.reportSmlouvy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportSmlouvy.LocalReport.ReportEmbeddedResource = "Evidence_zaměstnanců.ReportSmlouvy.rdlc";
            this.reportSmlouvy.Location = new System.Drawing.Point(0, 0);
            this.reportSmlouvy.Name = "reportSmlouvy";
            this.reportSmlouvy.Size = new System.Drawing.Size(851, 536);
            this.reportSmlouvy.TabIndex = 0;
            // 
            // ukonceneSmlouvy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 536);
            this.Controls.Add(this.reportSmlouvy);
            this.Name = "ukonceneSmlouvy";
            this.Text = "Ukončené smlouvy";
            this.Load += new System.EventHandler(this.ukonceneSmlouvy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportSmlouvy;
    }
}