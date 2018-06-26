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
        TBL_CONTRATOS consultaContrato;
        List<TBL_OFICIALES> detalleContratoOficial;
        TBL_USUARIOS consultaUsuario;
        TBL_CLIENTES tbClientes;


        public Boolean consultaContrataciones(int idContrato)
        {

            try
            {
                using (DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities())
                {
                    consultaContrato = db.TBL_CONTRATOS.First(contrato => contrato.ID_CONTRATO == idContrato);
                    if (consultaContrato != null)
                    {
                        var resultado = from oficiales in db.TBL_OFICIALES
                                        join tbDetalleContrato in db.DETALLE_CONTRATO
                                        on oficiales.ID_OFICIAL equals tbDetalleContrato.ID_OFICIAL
                                        where tbDetalleContrato.ID_CONTRATO == idContrato
                                        select new
                                        {
                                            cedOficial = oficiales.CEDULA_OFICIAL,
                                            nombreOficial=oficiales.NOMBRE_COMPLETO,
                                          };
                        foreach (var item in resultado)
                        {
                            detalleContratoOficial.Add(new TBL_OFICIALES()
                            {
                                CEDULA_OFICIAL = item.cedOficial,
                                NOMBRE_COMPLETO = item.nombreOficial
                            });
                        }

                        tbClientes = db.TBL_CLIENTES.First(clientes => clientes.ID_CLIENTE== tbl)
                        return true;
                    }
                    else { return false; }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
