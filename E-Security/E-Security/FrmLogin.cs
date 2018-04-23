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
    public partial class FrmLogin : Form
    {
        FrmPrincipal padre;
        Boolean validado = false;//Para cerrar la ventana principal en caso de no hacer el LogIn correctamente
        public FrmLogin(FrmPrincipal padre)//Contructor que recibe la ventana padre para bloquearla
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void txtExit_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                txtExit.BackColor = Color.Black;
                txtExit.ForeColor = SystemColors.ActiveCaption;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtExit_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                txtExit.BackColor = SystemColors.ActiveCaption;
                txtExit.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInformativa informativa = new FrmInformativa();
                informativa.mostrarMensajeSiNo("Hasta Luego", "¿Verdaderamente desea salir?");
                informativa.ShowDialog();
                if (informativa.Seleccion)
                    this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!validado)//Para cerrar la ventana principal en caso de no hacer el LogIn correctamente
                    padre.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInformativa informativa = new FrmInformativa();
                informativa.mostrarMensajeSiNo("Hasta Luego", "¿Verdaderamente desea salir?");
                informativa.ShowDialog();
                if (informativa.Seleccion)
                    this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
