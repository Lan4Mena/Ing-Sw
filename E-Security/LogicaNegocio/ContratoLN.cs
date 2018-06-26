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
        ContratoDAL contratoUsuario=new ContratoDAL();
        public List<Object> consultaContrataciones(String idContrato)
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
    }
}
