using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace E_Security
{
    public partial class FrmLogin : Form
    {
        FrmPrincipal padre;
        Boolean validado = false;//Para cerrar la ventana principal en caso de no hacer el LogIn correctamente
        UsuarioLN usuarioLN = new UsuarioLN();
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
                txtExit.ForeColor = Color.FromArgb(126, 166,224);
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
                txtExit.BackColor = Color.FromArgb(126, 166, 224);
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
                informativa.mostrarMensajeSiNo("Hasta Luego", "¿Desea salir?");
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
                if (usuarioLN.validarUsuario(txtNombreUsuario.Text, txtContrasena.Text))
                {
                    validado = true;
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
