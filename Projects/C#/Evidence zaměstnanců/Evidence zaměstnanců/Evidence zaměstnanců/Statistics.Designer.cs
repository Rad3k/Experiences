namespace Evidence_zaměstnanců
{
    partial class Statistics
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
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EvidenceDB = new Evidence_zaměstnanců.EvidenceDB();
            this.reportMzdy = new Microsoft.Reporting.WinForms.ReportViewer();
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
            // reportMzdy
            // 
            this.reportMzdy.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployeeBindingSource;
            this.reportMzdy.LocalReport.DataSources.Add(reportDataSource1);
            this.reportMzdy.LocalReport.ReportEmbeddedResource = "Evidence_zaměstnanců.ReportMzdy.rdlc";
            this.reportMzdy.Location = new System.Drawing.Point(0, 0);
            this.reportMzdy.Name = "reportMzdy";
            this.reportMzdy.Size = new System.Drawing.Size(851, 536);
            this.reportMzdy.TabIndex = 0;
            // 
            // EmployeeTableAdapter
            // 
            this.EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 536);
            this.Controls.Add(this.reportMzdy);
            this.Name = "Statistics";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportMzdy;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private EvidenceDB EvidenceDB;
        private EvidenceDBTableAdapters.EmployeeTableAdapter EmployeeTableAdapter;
    }
}