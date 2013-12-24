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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportProblemZam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EvidenceDB = new Evidence_zaměstnanců.EvidenceDB();
            this.TroubledEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TroubledEmployeesTableAdapter = new Evidence_zaměstnanců.EvidenceDBTableAdapters.TroubledEmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TroubledEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportProblemZam
            // 
            this.reportProblemZam.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TroubledEmployeesBindingSource;
            this.reportProblemZam.LocalReport.DataSources.Add(reportDataSource1);
            this.reportProblemZam.LocalReport.ReportEmbeddedResource = "Evidence_zaměstnanců.ReportProblems.rdlc";
            this.reportProblemZam.Location = new System.Drawing.Point(0, 0);
            this.reportProblemZam.Name = "reportProblemZam";
            this.reportProblemZam.Size = new System.Drawing.Size(851, 536);
            this.reportProblemZam.TabIndex = 0;
            // 
            // EvidenceDB
            // 
            this.EvidenceDB.DataSetName = "EvidenceDB";
            this.EvidenceDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TroubledEmployeesBindingSource
            // 
            this.TroubledEmployeesBindingSource.DataMember = "TroubledEmployees";
            this.TroubledEmployeesBindingSource.DataSource = this.EvidenceDB;
            // 
            // TroubledEmployeesTableAdapter
            // 
            this.TroubledEmployeesTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TroubledEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportProblemZam;
        private System.Windows.Forms.BindingSource TroubledEmployeesBindingSource;
        private EvidenceDB EvidenceDB;
        private EvidenceDBTableAdapters.TroubledEmployeesTableAdapter TroubledEmployeesTableAdapter;
    }
}