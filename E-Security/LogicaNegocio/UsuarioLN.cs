﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class UsuarioLN
    {

        public TBL_USUARIOS consultarUsuario(String cedula)
        {
            try
            {
                return new UsuarioDAL().consultarUsuario(cedula);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean agregarUsuario(TBL_USUARIOS usuario)
        {
            try
            {
                return new UsuarioDAL().agregarUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool modificarUsuario(TBL_USUARIOS usuario)
        {
            try
            {
                return new UsuarioDAL().modificarUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool validarUsuario(string nombreUsuario, string contrasena)
        {
            try
            {
               return new UsuarioDAL().validarUsuario(nombreUsuario, contrasena);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
