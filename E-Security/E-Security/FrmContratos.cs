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
        ContratoLN logicaLN;
        public FrmContratos()
        {
            InitializeComponent();
            logicaLN = new ContratoLN();
        }

        private void FrmContratos_Load(object sender, EventArgs e)
        {
            try
            {
                cbOficiales.DataSource = logicaLN.getOficiales();
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
            
            if (logicaLN.consultaContrataciones(txtIdContrato.Text))
            {
                Object[] datos = logicaLN.getDataContratacion();
                TBL_CONTRATOS contrato = (TBL_CONTRATOS)datos[0];
                dtpFechaInicio.Value = (DateTime)contrato.FECHA_INICIAL;
            }
            else
            {
                MessageBox.Show("No existen contratos registados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
