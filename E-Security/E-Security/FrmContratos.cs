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
        String[] detUsuario;
        FrmPrincipal padre;
        UsuarioLN logicaUsuarios;
        TBL_USUARIOS users = new TBL_USUARIOS();
        public FrmContratos(FrmPrincipal padre)
        {
            InitializeComponent();
            logicaContrato = new ContratoLN();
            logicaUsuarios = new UsuarioLN();
            this.padre = padre;
        }

        private void FrmContratos_Load(object sender, EventArgs e)
        {
            encabezados();
            cargarUsuarioLogeado();
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
                detUsuario = (String[])datos[2];
                dtpFechaInicio.Value = (DateTime)contrato.FECHA_INICIAL;
                txtFechaFin.Value = (DateTime)contrato.FECHA_FINAL;

                DETALLE_CONTRATO detCont = (DETALLE_CONTRATO)datos[4];
                txtMonto.Text = detCont.MONTO_OFICIAL.ToString();
                txtCedUsuario.Text = detUsuario[0].ToString();
                txtNomUsuario.Text= detUsuario[1].ToString();
                txtNomCompUsuario.Text= detUsuario[2].ToString();

                String[] cliente = (String[])datos[3];
                txtCedCliente.Text = cliente[0].ToString();
                txtNomCompl.Text = cliente[1].ToString();
                txtUbicacion.Text = cliente[2].ToString();
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
                txtMontoTotal.Text = (Convert.ToInt32(txtMontoTotal.Text) - (int)dataGridViewOficial.CurrentRow.Cells[2].Value).ToString();
                dataGridViewOficial.Rows.RemoveAt(dataGridViewOficial.CurrentRow.Index);
               
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error en la seleccion");
            }
        }
        public void cargarUsuarioLogeado()
        {
            users = logicaUsuarios.consultarUsuario(padre.IdUsuario);
            txtCedUsuario.Text = users.identificacion;
            txtNomUsuario.Text = users.Nombre_Usuario;
            txtNomCompUsuario.Text = users.nombre_completo;
        }
    }
}
