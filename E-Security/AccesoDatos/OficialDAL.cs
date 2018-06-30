using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class OficialDAL
    {
        public Array getOficialInventario()
        {
            using (var db=new DBEsparzaSeguridadEntities())
            {
                var consulta = from oficiales in db.TBL_OFICIALES
                               join inventariOficial in db.TBL_INVENTARIO_OFICIALES
                               on oficiales.ID_OFICIAL equals inventariOficial.ID_OFICIAL
                               join inventario in db.TBL_INVENTARIO
                               on inventariOficial.ID_INVENTARIO equals inventario.ID_INVENTARIO

                               select new
                               {
                                  Nombre_Oficial=oficiales.NOMBRE_COMPLETO,
                                  Cedula= oficiales.CEDULA_OFICIAL,
                                  Correo=oficiales.CORREO,
                                  Articulo=inventario.ARTICULO,


                               };
                return consulta.ToArray();
            }
        }
    }
}
