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

        public bool finalizarContrato(TBL_CONTRATOS contrato,List<DETALLE_CONTRATO> detalleContrato)
        {
            try
            {
                contratoUsuario.guardarContraro(contrato);
                foreach (var item in detalleContrato)
                {
                    contratoUsuario.guardarDetContraro(item);
                   
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public TBL_CLIENTES retornaCliente(string ced)
        {
            try
            {
                return contratoUsuario.consultaCliente(ced);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string getConsecutivo()
        {
            try
            {
                return contratoUsuario.getConsecutivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            };
        }
    }  

}
