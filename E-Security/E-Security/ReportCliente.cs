using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Security
{
    public partial class ReportCliente : Form
    {
        public ReportCliente()
        {
            InitializeComponent();
        }

        private void ReportCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DBEsparzaSeguridadDataSet.TBL_CLIENTES' table. You can move, or remove it, as needed.
            this.TBL_CLIENTESTableAdapter.Fill(this.DBEsparzaSeguridadDataSet.TBL_CLIENTES);
            // TODO: This line of code loads data into the 'DBEsparzaSeguridadDataSet.TBL_CLIENTE_CORREOS' table. You can move, or remove it, as needed.
            this.TBL_CLIENTE_CORREOSTableAdapter.Fill(this.DBEsparzaSeguridadDataSet.TBL_CLIENTE_CORREOS);
            // TODO: This line of code loads data into the 'DBEsparzaSeguridadDataSet.TBL_CLIENTE_TELEFONOS' table. You can move, or remove it, as needed.
            this.TBL_CLIENTE_TELEFONOSTableAdapter.Fill(this.DBEsparzaSeguridadDataSet.TBL_CLIENTE_TELEFONOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
