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
    public class N_Usuarios
    {
        private D_Usuarios D_Usuarios = new D_Usuarios();
        private E_Usuarios E_Usuarios = new E_Usuarios();

        public string N_rptComprobar(E_Usuarios eCompCed)
        {
            string CompCed = D_Usuarios.D_ComprobarCed(eCompCed);
            return CompCed;
        }

        public string N_rptCompNombUser(E_Usuarios eUser)
        {
            string userComp = D_Usuarios.D_ComprobarNombreUser(eUser);
            return userComp;
        }
    }
}
