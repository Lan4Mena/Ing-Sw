using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class ContratoLN
    {
        ContratoDAL contratoUsuario = new ContratoDAL();

        public bool consultaContrataciones(String idContrato)
        {

            try
            {
                return contratoUsuario.consultaContrataciones(Convert.ToInt32(idContrato));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Object[] getDataContratacion()
        {
            try
            {
                return contratoUsuario.getDatos();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<TBL_OFICIALES> getOficiales()
        {
            try
            {
                return contratoUsuario.getOficiales();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }  

}
