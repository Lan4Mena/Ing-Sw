using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccesoDatos;
using Entidades;
namespace PruebasIngSW
{
    [TestClass]
    public class agregarUsuarioTest
    {
        [TestMethod]
        public void agregarUsuario()
        {
            UsuarioDAL usuario = new UsuarioDAL();
            DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities();

            TBL_USUARIOS tabla = new TBL_USUARIOS();
            tabla.identificacion = "207490746";
            tabla.nombre_completo = "EXDER LOPEZ G";
            tabla.Nombre_Usuario = "EXLOGO";
            tabla.estado = true;
            tabla.contrasena = "123456789";

            var resultado = usuario.agregarUsuario(tabla);

            Assert.IsNotNull(resultado);
        }
    }
}
