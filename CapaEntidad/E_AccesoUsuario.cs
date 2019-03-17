using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_AccesoUsuario
    {

        private string _Usuario;
        private string _Contrasena;
        private string _Cedula;

        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }

        public E_AccesoUsuario()
        {

        }

        public E_AccesoUsuario(string Usuario, string Contrasena, string Cedula)
        {
            _Usuario = Usuario;
            _Contrasena = Contrasena;
            _Cedula = Cedula;
        } 
    }
}
