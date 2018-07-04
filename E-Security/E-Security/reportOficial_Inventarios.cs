using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Entidades;


namespace E_Security
{
    public partial class reportOficial_Inventarios : Form
    {
        OficialLN consultaPrueba;

        DataSet datos;
        List<TBL_USUARIOS> lista;
        public reportOficial_Inventarios()
        {
            InitializeComponent();
            consultaPrueba = new OficialLN();
            datos = new DataSet();
           

        }
        public void inicializa(List<TBL_USUARIOS> consulta)
        {
           
            
        }

        private void reportOficial_Inventarios_Load(object sender, EventArgs e)
        {
            /*Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {*/
            try
            {
                dgvOfiEquipos.DataSource = consultaPrueba.getOficialInventario();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
      
       }
    }
}
