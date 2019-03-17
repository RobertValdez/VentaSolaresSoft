using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_MenuPrincipal // En desuso
    {
        private string _CedulaEmpleado;

        public string CedulaEmpleado { get => _CedulaEmpleado; set => _CedulaEmpleado = value; }

        public E_MenuPrincipal()
        {

        }
        public E_MenuPrincipal(string CedulaEmpleado)
        {
            _CedulaEmpleado = CedulaEmpleado;
        }
    }
}
