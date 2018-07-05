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
    public partial class FrmContratos : Form
    {
        ContratoLN logicaContrato;
        public FrmContratos()
        {
            InitializeComponent();
            logicaContrato = new ContratoLN();
            
        }

        private void FrmContratos_Load(object sender, EventArgs e)
        {
            encabezados();
            try
            {
                cbOficiales.DataSource = logicaContrato.getOficiales();
                cbOficiales.ValueMember = "ID_OFICIAL";
                cbOficiales.DisplayMember = "NOMBRE_COMPLETO";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (logicaContrato.consultaContrataciones(txtIdContrato.Text))
            {
                Object[] datos = logicaContrato.getDataContratacion();
                TBL_CONTRATOS contrato = (TBL_CONTRATOS)datos[0];
                DETALLE_CONTRATO detCont = (DETALLE_CONTRATO)datos[4];
                dtpFechaInicio.Value = (DateTime)contrato.FECHA_INICIAL;
                txtFechaFin.Value = (DateTime)contrato.FECHA_FINAL;
                txtMonto.Text = detCont.MONTO_OFICIAL.ToString();
            }
            else
            {
                MessageBox.Show("No existen contratos registados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void encabezados()
        {
            dataGridViewOficial.ColumnCount = 4;
            dataGridViewOficial.ColumnHeadersVisible = true;
            dataGridViewOficial.Columns[0].HeaderText = "ID Oficial";
            dataGridViewOficial.Columns[1].HeaderText = "Nombre Completo";
            dataGridViewOficial.Columns[2].HeaderText = "Monto";

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] list = { cbOficiales.SelectedValue.ToString(), cbOficiales.Text, txtMonto.Text };
                dataGridViewOficial.Rows.Insert(0, list);
                txtMontoTotal.Text = (Convert.ToInt32(txtMontoTotal.Text) + Convert.ToInt32(txtMonto.Text)).ToString();
            }
            catch (Exception)
            {
                throw;
            } 
        }

        private void btnRemoverDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOficial.Rows.RemoveAt(dataGridViewOficial.CurrentRow.Index);
                txtMontoTotal.Text = (Convert.ToInt32(txtMontoTotal.Text) - (int)dataGridViewOficial.CurrentRow.Cells[2].Value).ToString();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error en la seleccion");
            }
        }
    }
}
