using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class N_BuscarClientes
    {
        D_BuscarCliente D_BuscarCliente = new D_BuscarCliente();
        public DataTable N_MostrarClientes()
        {
           return D_BuscarCliente.D_BuscarClientes();
        }
    }
}
