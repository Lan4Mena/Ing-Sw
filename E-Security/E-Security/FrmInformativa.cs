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
    public partial class FrmInformativa : Form
    {
        //Holis
        Boolean seleccion;
        public FrmInformativa()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad para retornar y asignar el valor seleccionados
        /// </summary>
        public bool Seleccion{ get{return seleccion;}set{seleccion = value;}}

        public void mostrarMensaje(String encabezado, String msj)
        {
            try
            {
                this.Text = encabezado;
                txtMsj.Text = msj;
                btnAceptar.Visible = true;
                btnSi.Visible = false;
                btnNo.Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        /// <summary>
        /// Metodo para seleccoinar una opción
        /// </summary>
        /// <param name="encabezado"></param>
        /// <param name="msj"></param>
        public void mostrarMensajeSiNo(String encabezado, String msj)
        {
            try
            {
                this.Text = encabezado;
                txtMsj.Text = msj;

                btnAceptar.Visible = false;
                btnSi.Visible = true;
                btnNo.Visible = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            try
            {
                Seleccion = true;
                this.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            try
            {
                Seleccion = false;
                this.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
