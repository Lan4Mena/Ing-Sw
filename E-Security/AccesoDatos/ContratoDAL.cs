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
        private TBL_CONTRATOS consultaContrato;
        private List<TBL_OFICIALES> tblDetOficial;
        private String[] consultaUsuario;
        private String[] tbClientes;
        private DETALLE_CONTRATO detalleContrato;

        public Boolean consultaContrataciones(int idContrato)
        {
            tblDetOficial = new List<TBL_OFICIALES>();
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
                            tblDetOficial.Add(new TBL_OFICIALES()
                            {
                                CEDULA_OFICIAL = item.cedOficial,
                                NOMBRE_COMPLETO = item.nombreOficial
                            });
                        }
                        detalleContrato = db.DETALLE_CONTRATO.First(detContra => detContra.ID_CONTRATO == idContrato);

                        var algo = (from cliente in db.TBL_CLIENTES join
                                    contrato in db.TBL_CONTRATOS on
                                    cliente.ID_CLIENTE equals contrato.ID_CLIENTE join 
                                     tipoCedula in db.TBL_TIPO_CEDULAS on
                                     cliente.ID_CLIENTE equals tipoCedula.ID_CLIENTE
                                     where contrato.ID_CONTRATO == idContrato
                                     select new
                                     {
                                         cedulaCliente = tipoCedula.CEDULA,
                                         nombre = cliente.NOMBRE,
                                         direccion= cliente.UBICACION
                                     }).ToArray();

                        tbClientes = new String[] {algo[0].cedulaCliente.ToString(),algo[0].nombre,algo[0].direccion};

                        var algomas2 = (from usuarios in db.TBL_USUARIOS join
                                         contratos in db.TBL_CONTRATOS on
                                         usuarios.ID_Usuario equals contratos.ID_USUARIO
                                          where contratos.ID_CONTRATO == idContrato
                                          select new
                                          {
                                              cedUsuario= usuarios.identificacion,
                                              nombreUsuario= usuarios.Nombre_Usuario,
                                              nombreCompleto= usuarios.nombre_completo
                                          }).ToArray();
                        consultaUsuario = new String[] { algomas2[0].cedUsuario, algomas2[0].nombreUsuario, algomas2[0].nombreCompleto };
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Object[] getDatos()
        {
            return new Object[] {consultaContrato,tblDetOficial,consultaUsuario,tbClientes, detalleContrato };
        }

        public List<TBL_OFICIALES> getOficiales()
        {
            try
            {
                using (var db = new DBEsparzaSeguridadEntities())
                {
                    return db.TBL_OFICIALES.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
