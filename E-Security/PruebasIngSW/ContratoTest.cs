using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using AccesoDatos;
using System.Collections.Generic;
using LogicaNegocio;

namespace PruebasIngSW
{
    [TestClass]
    public class ContratoTest
    {
        [TestMethod]
        public void crearContrato()
        {
            ContratoLN contratoln = new ContratoLN();
            TBL_CONTRATOS contrato = new TBL_CONTRATOS();
            List<DETALLE_CONTRATO> detContrato = new List<DETALLE_CONTRATO>();


            contrato.FECHA_INICIAL = Convert.ToDateTime("2017/06/20");
            contrato.FECHA_FINAL = DateTime.Today;
            contrato.ESTADO_CONTRATO = true;
            contrato.MONTO_TOTAL = 666000;
            contrato.ID_CLIENTE = 3;
            contrato.ID_USUARIO = 6;

            //7 FUE EL ULTIMO, VER CBX DE LA PANTALLA CONTRATO PARA AGREGAR EL SIGUIENTE EN 
            //LA PRUEBA
            detContrato.Add(new DETALLE_CONTRATO() { ID_CONTRATO = 7, ID_OFICIAL = 3, MONTO_OFICIAL = 60000 });

            var result = contratoln.finalizarContrato(contrato, detContrato);

            Assert.IsNotNull(result);
        }
    }
}
