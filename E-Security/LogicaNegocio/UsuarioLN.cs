using System;
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

        public List<TBL_USUARIOS> usuarioGeneral()
        {
            try
            {
                return new UsuarioDAL().consultaGeneralUsuario();
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

        public bool eliminarUsuario(String identificacion)
        {
            try
            {
                return new UsuarioDAL().eliminarUsuario(identificacion);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public TBL_USUARIOS validarUsuario(string nombreUsuario, string contrasena)
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

        public List<TBL_USUARIOS> getListadoUsuarios()
        {
            try
            {
                return new UsuarioDAL().getListadoUsuarios();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
