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
    public class N_Solares
    {
        private D_Solares D_Solares = new D_Solares();
        private E_Solares E_Solares = new E_Solares();

        public DataTable N_MostrarSolares()
        {
            DataTable dt = new DataTable();
            dt = D_Solares.D_MostrarSolares();
            return dt;
        }

        public int N_InsertarSolar(E_Solares eSolares)
        {
            int rsp = D_Solares.InsertarSolar(eSolares);
            return rsp;
        }
        public int N_ModificarSolar(E_Solares eSolares)
        {
            int rsp = D_Solares.ModificarSolar(eSolares);
            return rsp;
        }
        public int N_EliminarSolar(E_Solares eSolares)
        {
            int rsp = D_Solares.EliminarSolar(eSolares);
            return rsp;
        }
    }
}
