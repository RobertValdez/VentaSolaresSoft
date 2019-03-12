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

        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }

        public E_AccesoUsuario()
        {

        }

        public E_AccesoUsuario(string Usuario, string Contrasena)
        {
            _Usuario = Usuario;
            _Contrasena = Contrasena;
        }

        
    }
}
