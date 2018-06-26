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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarContratosTB.Add(logicaLN.consultaContrataciones(txtIdContrato.Text));
            if (logicaLN.consultaContrataciones(txtIdContrato.Text) != null)
            {
                foreach (var value in consultarContratosTB)
                {
                    Console.WriteLine("Entra a revisar lista de objetos");
                    Console.WriteLine(value.ToString());
                    //Esto es un cambio, v2
                }
            }
            else
            {
                MessageBox.Show("No existen contratos registados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
