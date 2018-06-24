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
        List<Object> consultarContratosTB;
        public FrmContratos()
        {
            InitializeComponent();
            consultarContratosTB = new List<Object>();
            logicaLN = new ContratoLN();
        }

        private void FrmContratos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            consultarContratosTB.Add(logicaLN.consultaContrataciones(txtIdContrato.Text));
            foreach (var value in consultarContratosTB)
            {
                Console.WriteLine(value);
                txtCedCliente.Text = Convert.ToString(value.ToString());n
            }


        }
    }
}
