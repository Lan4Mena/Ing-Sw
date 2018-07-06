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
        private TBL_CLIENTES cliente;
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
            cargarIdContrato();
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
                /*El contrato*/
                Object[] datos = logicaContrato.getDataContratacion();
                TBL_CONTRATOS contrato = (TBL_CONTRATOS)datos[0];
                dtpFechaInicio.Value = (DateTime)contrato.FECHA_INICIAL;
                txtFechaFin.Value = (DateTime)contrato.FECHA_FINAL;
                txtMontoTotal.Text =  contrato.MONTO_TOTAL.ToString();

                /*El Usuario que realizò el contrato*/
                detUsuario = (String[])datos[2];
                txtCedUsuario.Text = detUsuario[0].ToString();
                txtNomUsuario.Text= detUsuario[1].ToString();
                txtNomCompUsuario.Text= detUsuario[2].ToString();

                /*Cliente al que se le hizo el contrato*/
                String[] cliente = (String[])datos[3];
                txtCedCliente.Text = cliente[0].ToString();
                txtNomCompl.Text = cliente[1].ToString();
                txtUbicacion.Text = cliente[2].ToString();

                /*Oficiales contratados en el contrato*/
                List<String[]> oficial = (List<String[]>)datos[1];
                dataGridViewOficial.DataSource = null;
                foreach (var item in oficial)
                {
                    dataGridViewOficial.Rows.Add(item);
                }

                /*List<String> lista = new List<String> { oficial.ID_OFICIAL.ToString(), oficial.NOMBRE_COMPLETO ,detCont.MONTO_OFICIAL.ToString()};
                dataGridViewOficial.Rows.Insert(0, lista);*/
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
                txtMontoTotal.Text = (Convert.ToInt32(txtMontoTotal.Text) - Convert.ToInt32(dataGridViewOficial.CurrentRow.Cells[2].Value)).ToString();
                dataGridViewOficial.Rows.RemoveAt(dataGridViewOficial.CurrentRow.Index);
               
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error en la seleccion");
            }
        }
        public void cargarUsuarioLogeado()
        {
            users = logicaUsuarios.consultarUsuario(padre.CedUsuario);
            txtCedUsuario.Text = users.identificacion;
            txtNomUsuario.Text = users.Nombre_Usuario;
            txtNomCompUsuario.Text = users.nombre_completo;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                List<DETALLE_CONTRATO> detalleContrato;
                detalleContrato = new List<DETALLE_CONTRATO>();
                TBL_CONTRATOS contratos = new TBL_CONTRATOS() {FECHA_INICIAL=dtpFechaInicio.Value,
                    FECHA_FINAL= txtFechaFin.Value,ESTADO_CONTRATO=true,
                    MONTO_TOTAL =Convert.ToInt32(txtMontoTotal.Text), ID_USUARIO=Convert.ToInt32(padre.IdUsuario),ID_CLIENTE=cliente.ID_CLIENTE,
                        };

                foreach (DataGridViewRow item in dataGridViewOficial.Rows)
                {

                    detalleContrato.Add(new DETALLE_CONTRATO(){ID_CONTRATO = Convert.ToInt32(txtIdContrato.Text),ID_OFICIAL = Convert.ToInt32(item.Cells[0].Value.ToString()),MONTO_OFICIAL= Convert.ToInt32(item.Cells[2].Value.ToString())});
                }

                logicaContrato.finalizarContrato(contratos, detalleContrato);
                cargarIdContrato();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void txtCedCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               cliente = logicaContrato.retornaCliente(txtCedCliente.Text);
                if (cliente != null)
                {
                    txtNomCompl.Text = cliente.NOMBRE;
                    txtUbicacion.Text = cliente.UBICACION;

                }
            }
        }

        public void cargarIdContrato()
        {
            try
            {
                lbIdContrato.Text = "Nº de Contrato: " + logicaContrato.getConsecutivo();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
