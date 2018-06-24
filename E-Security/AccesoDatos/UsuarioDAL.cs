using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class UsuarioDAL
    {
        public TBL_USUARIOS consultarUsuario(String cedula)
        {
            try
            {
                using (DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities())
                {
                    return db.TBL_USUARIOS.First(TBL_USUARIOS => TBL_USUARIOS.identificacion == cedula);
                }
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
                using (DBEsparzaSeguridadEntities db=new DBEsparzaSeguridadEntities())
                {
                    db.TBL_USUARIOS.Add(usuario);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean modificarUsuario(TBL_USUARIOS usuario)
        {
            try
            {
                using (DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities())
                {
                    TBL_USUARIOS usuarioModificar = db.TBL_USUARIOS.First(TBL_USUARIOS=> TBL_USUARIOS.identificacion==usuario.identificacion);
                    usuarioModificar.nombre_completo = usuario.nombre_completo;
                    usuarioModificar.Nombre_Usuario = usuario.Nombre_Usuario;
                    usuarioModificar.contrasena = usuario.contrasena;
                    usuarioModificar.estado = usuario.estado;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
