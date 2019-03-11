using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuarios
    {
        private string _ComprobarNomUser;
        private string _NombreUser;
        private string _Contrasena;
        private string _CedulaEmpleado;
        private string _ComprobarCedula;

        public string ComprobarNomUser { get => _ComprobarNomUser; set => _ComprobarNomUser = value; }
        public string NombreUser { get => _NombreUser; set => _NombreUser = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
        public string CedulaEmpleado { get => _CedulaEmpleado; set => _CedulaEmpleado = value; }
        public string ComprobarCedula { get => _ComprobarCedula; set => _ComprobarCedula = value; }
        
        public E_Usuarios()
        {

        }

        public E_Usuarios(string CompNomUser, string Nombre, string Contrasena, string CedulaEmpleado, string ComprobarCedula)
        {
            _ComprobarNomUser = CompNomUser;
            _NombreUser = Nombre;
            _Contrasena = Contrasena;
            _CedulaEmpleado = CedulaEmpleado;
            _ComprobarCedula = ComprobarCedula;
        }
    }
}
