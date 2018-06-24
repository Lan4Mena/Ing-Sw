using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccesoDatos
{
   public class ContratoDAL
    {
        
        public List<Object> consultaContrataciones(String idContrato)
        {

            try
            {
                using (DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities())
                {
                    var consultaContrato = from tblContratos in db.TBL_CONTRATOS
                                           join usuarios in db.TBL_USUARIOS on tblContratos.ID_USUARIO equals usuarios.ID_Usuario
                                           join detalleContrato in db.DETALLE_CONTRATO on tblContratos.ID_CONTRATO equals detalleContrato.ID_CONTRATO
                                           join detalleCliente in db.TBL_CLIENTES on tblContratos.ID_CLIENTE equals detalleCliente.ID_CLIENTE
                                           join tipoCedula in db.TBL_TIPO_CEDULAS on detalleCliente.ID_CLIENTE equals tipoCedula.ID_CLIENTE
                                           join oficial in db.TBL_OFICIALES on detalleContrato.ID_OFICIAL equals oficial.ID_OFICIAL
                                           where tblContratos.ID_CONTRATO == Convert.ToInt32(idContrato)
                                           select new
                                           {
                                               cedUsuario = usuarios.identificacion,
                                               nombreUsuario = usuarios.Nombre_Usuario,
                                               nombreCompleto = usuarios.nombre_completo,
                                               cedCliente = tipoCedula.CEDULA,
                                               nombClien = detalleCliente.NOMBRE,
                                               ubicaicon = detalleCliente.UBICACION,
                                               cedOficial = oficial.CEDULA_OFICIAL,
                                               idOficial = oficial.ID_OFICIAL,
                                               nomOfifcial = oficial.NOMBRE_COMPLETO,
                                               montoOfifial = detalleContrato.MONTO_OFICIAL,
                                           };
                    return consultaContrato.ToList<Object>();  
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
