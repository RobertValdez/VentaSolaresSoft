using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_AccesoUsuario
    {
        private D_AccesoUsuario D_AccespUsuario = new D_AccesoUsuario();

        public int N_rspAccesoUsuario(E_AccesoUsuario eAccUser)
        {
            return D_AccespUsuario.D_ConcederAcceso(eAccUser);
        }
        public string N_rspDatos_DatosEmpleado(E_AccesoUsuario eAccUser)
        {
          return  D_AccespUsuario.D_DatosEmpleado(eAccUser);
        }
    }
}
