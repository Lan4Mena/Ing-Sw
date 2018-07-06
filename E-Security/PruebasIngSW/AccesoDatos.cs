using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using AccesoDatos;


namespace PruebasIngSW
{
    [TestClass]
    public class AccesoDatos
    {
        [TestMethod]
        public void consultaUsuarioTest()
        {
            UsuarioDAL usuario = new UsuarioDAL();

            var result = usuario.consultarUsuario("123");

            Assert.IsNotNull(result);

        }
    }
}
