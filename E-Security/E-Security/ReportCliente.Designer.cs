namespace E_Security
{
    partial class ReportCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DBEsparzaSeguridadDataSet = new E_Security.DBEsparzaSeguridadDataSet();
            this.TBL_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_CLIENTESTableAdapter = new E_Security.DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTESTableAdapter();
            this.TBL_CLIENTE_CORREOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_CLIENTE_CORREOSTableAdapter = new E_Security.DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTE_CORREOSTableAdapter();
            this.TBL_CLIENTE_TELEFONOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_CLIENTE_TELEFONOSTableAdapter = new E_Security.DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTE_TELEFONOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBEsparzaSeguridadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTE_CORREOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTE_TELEFONOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataClientes";
            reportDataSource1.Value = this.TBL_CLIENTESBindingSource;
            reportDataSource2.Name = "DataClienteCorreo";
            reportDataSource2.Value = this.TBL_CLIENTE_CORREOSBindingSource;
            reportDataSource3.Name = "DataClienteTelefonos";
            reportDataSource3.Value = this.TBL_CLIENTE_TELEFONOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E_Security.ReporteClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(668, 423);
            this.reportViewer1.TabIndex = 0;
            // 
            // DBEsparzaSeguridadDataSet
            // 
            this.DBEsparzaSeguridadDataSet.DataSetName = "DBEsparzaSeguridadDataSet";
            this.DBEsparzaSeguridadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_CLIENTESBindingSource
            // 
            this.TBL_CLIENTESBindingSource.DataMember = "TBL_CLIENTES";
            this.TBL_CLIENTESBindingSource.DataSource = this.DBEsparzaSeguridadDataSet;
            // 
            // TBL_CLIENTESTableAdapter
            // 
            this.TBL_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // TBL_CLIENTE_CORREOSBindingSource
            // 
            this.TBL_CLIENTE_CORREOSBindingSource.DataMember = "TBL_CLIENTE_CORREOS";
            this.TBL_CLIENTE_CORREOSBindingSource.DataSource = this.DBEsparzaSeguridadDataSet;
            // 
            // TBL_CLIENTE_CORREOSTableAdapter
            // 
            this.TBL_CLIENTE_CORREOSTableAdapter.ClearBeforeFill = true;
            // 
            // TBL_CLIENTE_TELEFONOSBindingSource
            // 
            this.TBL_CLIENTE_TELEFONOSBindingSource.DataMember = "TBL_CLIENTE_TELEFONOS";
            this.TBL_CLIENTE_TELEFONOSBindingSource.DataSource = this.DBEsparzaSeguridadDataSet;
            // 
            // TBL_CLIENTE_TELEFONOSTableAdapter
            // 
            this.TBL_CLIENTE_TELEFONOSTableAdapter.ClearBeforeFill = true;
            // 
            // ReportCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 423);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportCliente";
            this.Text = "ReportCliente";
            this.Load += new System.EventHandler(this.ReportCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBEsparzaSeguridadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTE_CORREOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTE_TELEFONOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBL_CLIENTESBindingSource;
        private DBEsparzaSeguridadDataSet DBEsparzaSeguridadDataSet;
        private System.Windows.Forms.BindingSource TBL_CLIENTE_CORREOSBindingSource;
        private System.Windows.Forms.BindingSource TBL_CLIENTE_TELEFONOSBindingSource;
        private DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTESTableAdapter TBL_CLIENTESTableAdapter;
        private DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTE_CORREOSTableAdapter TBL_CLIENTE_CORREOSTableAdapter;
        private DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTE_TELEFONOSTableAdapter TBL_CLIENTE_TELEFONOSTableAdapter;
    }
}