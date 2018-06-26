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
    public partial class FrmPrincipal : Form
    {
        ReportCliente reporte;
        FrmContratos contratos;
        public FrmPrincipal()
        {
            
            InitializeComponent();
           
        }
        public string Login{get{return labelLogin.Text; }set{labelLogin.Text = value;}}

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                new FrmLogin(this).ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmUsuarios().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reportClientes_Click(object sender, EventArgs e)
        {
            reporte = new ReportCliente();
            reporte.ShowDialog();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contratos = new FrmContratos();
            contratos.ShowDialog();
        }
    }
}
