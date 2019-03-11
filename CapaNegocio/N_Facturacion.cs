using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_Facturacion
    {
        E_Facturacion E_Facturacion = new E_Facturacion();
        D_Facturacion D_Facturacion = new D_Facturacion();

        public int N_InsertarCompra(E_Facturacion eFact)
        {
            int rsp = D_Facturacion.InsertarCompra(eFact);
            return rsp;
        }
    }
}
