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
        private List<String[]> oficialesContrato;
        private String[] consultaUsuario;
        private String[] tbClientes;

        public Boolean consultaContrataciones(int idContrato)
        {
            oficialesContrato = new List<String[]>();
            try
            {
                using (DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities())
                {
                    /*Contrato*/
                    consultaContrato = db.TBL_CONTRATOS.First(contrato => contrato.ID_CONTRATO == idContrato);
                    if (consultaContrato != null)
                    {
                        /*Oficiales dentro del contrato*/
                        var resultado = from oficiales in db.TBL_OFICIALES
                                        join tbDetalleContrato in db.DETALLE_CONTRATO
                                        on oficiales.ID_OFICIAL equals tbDetalleContrato.ID_OFICIAL
                                        where tbDetalleContrato.ID_CONTRATO == idContrato
                                        select new
                                        {
                                            idOficial= oficiales.ID_OFICIAL,
                                            nombreOficial=oficiales.NOMBRE_COMPLETO,
                                            montoOficial= tbDetalleContrato.MONTO_OFICIAL
                                          };
                        /*Recorre la informaciòn de los oficales del contrato para agregarlo a una tabla*/
                        foreach (var item in resultado)
                        {
                            oficialesContrato.Add(new String[]{item.idOficial.ToString(),item.nombreOficial,item.montoOficial.ToString()});
                        }
                        /**/
                
                        /*Cliente al que se le hizo el contrato*/
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
                        /*Se guarda la informaciòn de ese cliente en un arreglo para devolver la informaciòn*/
                        tbClientes = new String[] {algo[0].cedulaCliente.ToString(),algo[0].nombre,algo[0].direccion};

                        /*Usuario que hizo el contrato*/
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
                        /*Se guarda la informaciòn de ese usuario en un arreglo para devolver la informaciòn*/
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

        public string getConsecutivo()
        {
            try
            {
                using (var db=new DBEsparzaSeguridadEntities())
                {
                    return db.TBL_CONTRATOS.Max(contra=> contra.ID_CONTRATO)+1+"";
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Object[] getDatos()
        {
            return new Object[] {consultaContrato,oficialesContrato,consultaUsuario,tbClientes};
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

        public Boolean guardarContraro(TBL_CONTRATOS contrato)
        {
            Boolean exito = false;
            using (DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities())
            {
                db.TBL_CONTRATOS.Add(contrato);
                db.SaveChanges();
                exito = true;
            }
            return exito;
        }
        public Boolean guardarDetContraro(DETALLE_CONTRATO detContrato)
        {
            Boolean exito = false;
            using (DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities())
            {
                db.DETALLE_CONTRATO.Add(detContrato);
                db.SaveChanges();
                exito = true;
            }
            return exito;
        }

        public TBL_CLIENTES consultaCliente(string cedCliente)
        {
            using (DBEsparzaSeguridadEntities db = new DBEsparzaSeguridadEntities())
            {
                int ced = Convert.ToInt32(cedCliente);
                var consulta = (from cliente in db.TBL_CLIENTES join
                               tipoCed in db.TBL_TIPO_CEDULAS on
                               cliente.ID_CLIENTE equals tipoCed.ID_CLIENTE
                               where tipoCed.CEDULA == ced
                               select cliente).ToArray().GetValue(0);
                return (TBL_CLIENTES)consulta;
            }
                
                
        }
    }
}
