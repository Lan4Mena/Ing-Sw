namespace E_Security
{
    partial class reportOficial_Inventarios
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DBEsparzaSeguridadDataSet = new E_Security.DBEsparzaSeguridadDataSet();
            this.TBL_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_CLIENTESTableAdapter = new E_Security.DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTESTableAdapter();
            this.TBL_CLIENTE_CORREOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_CLIENTE_CORREOSTableAdapter = new E_Security.DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTE_CORREOSTableAdapter();
            this.TBL_CLIENTE_TELEFONOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_CLIENTE_TELEFONOSTableAdapter = new E_Security.DBEsparzaSeguridadDataSetTableAdapters.TBL_CLIENTE_TELEFONOSTableAdapter();
            this.dgvOfiEquipos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBEsparzaSeguridadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTE_CORREOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTE_TELEFONOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfiEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
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
            // dgvOfiEquipos
            // 
            this.dgvOfiEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOfiEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfiEquipos.Location = new System.Drawing.Point(22, 76);
            this.dgvOfiEquipos.Name = "dgvOfiEquipos";
            this.dgvOfiEquipos.Size = new System.Drawing.Size(621, 368);
            this.dgvOfiEquipos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte Inventario en oficiales";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(439, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(267, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // reportOficial_Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOfiEquipos);
            this.Name = "reportOficial_Inventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Oficiales Equipos";
            this.Load += new System.EventHandler(this.reportOficial_Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBEsparzaSeguridadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTE_CORREOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_CLIENTE_TELEFONOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfiEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvOfiEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}