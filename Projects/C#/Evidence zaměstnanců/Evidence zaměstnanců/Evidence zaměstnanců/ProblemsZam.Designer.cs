namespace Evidence_zaměstnanců
{
    partial class problemsZam
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
            this.reportProblemZam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportProblemZam
            // 
            this.reportProblemZam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportProblemZam.LocalReport.ReportEmbeddedResource = "Evidence_zaměstnanců.ReportProblems.rdlc";
            this.reportProblemZam.Location = new System.Drawing.Point(0, 0);
            this.reportProblemZam.Name = "reportProblemZam";
            this.reportProblemZam.Size = new System.Drawing.Size(851, 536);
            this.reportProblemZam.TabIndex = 0;
            // 
            // problemsZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 536);
            this.Controls.Add(this.reportProblemZam);
            this.Name = "problemsZam";
            this.Text = "Problémový zaměstnanci";
            this.Load += new System.EventHandler(this.problemsZam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportProblemZam;
    }
}