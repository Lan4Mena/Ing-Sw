using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class OficialLN
    {

        public Array getOficialInventario()
        {
            return new OficialDAL().getOficialInventario();
        }
    }
}
