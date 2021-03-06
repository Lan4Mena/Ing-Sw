﻿using System;
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
    public partial class FrmUsuarios : Form
    {
        UsuarioLN usuarioLN = null;
        TBL_USUARIOS usuario = null;
        public FrmUsuarios()
        {
            usuarioLN = new UsuarioLN();
            usuario = new TBL_USUARIOS();
            InitializeComponent();
        }



        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = usuarioLN.consultarUsuario(txtCedula.Text);
                if (usuario != null)
                {
                    txtNombre.Text = usuario.nombre_completo;
                    txtIdUsuario.Text = usuario.ID_Usuario.ToString();
                    txtNombreUsuario.Text = usuario.Nombre_Usuario;
                }
                else
                {
                    FrmInformativa frm = new FrmInformativa();
                    frm.mostrarMensajeSiNo("Consulta", "¿El usuario NO existe, desea agregarlo?");
                    frm.ShowDialog();
                    if (frm.Seleccion)
                    {
                        //Habilitar Agregar
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmInformativa frm = new FrmInformativa();
            try
            {
                if (usuario != null)//Verificar si los campos están vacios
                {
                    if (usuarioLN.agregarUsuario(new TBL_USUARIOS() { identificacion = txtCedula.Text, estado = true, contrasena = txtContrasena.Text, nombre_completo = txtNombre.Text, Nombre_Usuario = txtNombreUsuario.Text }))
                    {
                        frm.mostrarMensaje("Exito", "Usuario Agregado");
                        //Limpiar campos
                    }
                    else
                    {
                        frm.mostrarMensaje("Error", "No se pudo agregar");
                    }
                }
                else
                {
                    frm.mostrarMensaje("Error", "Rellene todos los campos");
                    frm.ShowDialog();
                    if (frm.Seleccion)
                    {
                        //Habilitar Agregar
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmInformativa frm = new FrmInformativa();
            try
            {
                if (usuario != null)//Verificar si los campos están vacios
                {
                    if (usuarioLN.modificarUsuario(new TBL_USUARIOS() { identificacion = txtCedula.Text, estado = true, contrasena = txtContrasena.Text, nombre_completo = txtNombre.Text, Nombre_Usuario = txtNombreUsuario.Text }))
                    {
                        frm.mostrarMensaje("Exito", "Usuario Modificado");
                        //Limpiar campos
                    }
                    else
                    {
                        frm.mostrarMensaje("Error", "No se pudo Modificar");
                    }
                }
                else
                {
                    frm.mostrarMensaje("Error", "Rellene todos los campos");
                    frm.ShowDialog();
                    if (frm.Seleccion)
                    {
                        //Habilitar Agregar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
