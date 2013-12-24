namespace Evidence_zaměstnanců
{
    partial class controlZam
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EvidenceDB = new Evidence_zaměstnanců.EvidenceDB();
            this.reportZam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployeeTableAdapter = new Evidence_zaměstnanců.EvidenceDBTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceDB)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employee";
            this.EmployeeBindingSource.DataSource = this.EvidenceDB;
            // 
            // EvidenceDB
            // 
            this.EvidenceDB.DataSetName = "EvidenceDB";
            this.EvidenceDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportZam
            // 
            this.reportZam.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.EmployeeBindingSource;
            this.reportZam.LocalReport.DataSources.Add(reportDataSource2);
            this.reportZam.LocalReport.ReportEmbeddedResource = "Evidence_zaměstnanců.ReportZam.rdlc";
            this.reportZam.Location = new System.Drawing.Point(0, 0);
            this.reportZam.Name = "reportZam";
            this.reportZam.Size = new System.Drawing.Size(851, 536);
            this.reportZam.TabIndex = 0;
            // 
            // EmployeeTableAdapter
            // 
            this.EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // controlZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 536);
            this.Controls.Add(this.reportZam);
            this.Name = "controlZam";
            this.Text = "Kontrola zaměstnanců";
            this.Load += new System.EventHandler(this.controlZam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportZam;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private EvidenceDB EvidenceDB;
        private EvidenceDBTableAdapters.EmployeeTableAdapter EmployeeTableAdapter;
    }
}