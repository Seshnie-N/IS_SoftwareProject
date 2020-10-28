namespace Stuport
{
    partial class StuportReport
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
            this.GroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StuportDatabaseDataSetGroups = new Stuport.StuportDatabaseDataSetGroups();
            this.GroupTableAdapter = new Stuport.StuportDatabaseDataSetGroupsTableAdapters.GroupTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuportDatabaseDataSetGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBindingSource
            // 
            this.GroupBindingSource.DataMember = "Group";
            this.GroupBindingSource.DataSource = this.StuportDatabaseDataSetGroups;
            // 
            // StuportDatabaseDataSetGroups
            // 
            this.StuportDatabaseDataSetGroups.DataSetName = "StuportDatabaseDataSetGroups";
            this.StuportDatabaseDataSetGroups.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GroupTableAdapter
            // 
            this.GroupTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Groups";
            reportDataSource1.Value = this.GroupBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stuport.StuportReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // StuportReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StuportReport";
            this.Text = "StuportReport";
            this.Load += new System.EventHandler(this.StuportReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuportDatabaseDataSetGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource GroupBindingSource;
        private StuportDatabaseDataSetGroups StuportDatabaseDataSetGroups;
        private StuportDatabaseDataSetGroupsTableAdapters.GroupTableAdapter GroupTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}