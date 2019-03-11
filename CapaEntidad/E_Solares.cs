using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Solares
    {
        private float _Id;
        private float _NumeroCertTitulo;
        private float _CantidadMetros;
        private float _Numero;
        private string _Coordenadas;
        private string _ColindSolar;
        private string _DescAddPropiedad;
        private float _InfoPropietario;
        private byte[] _ImagenTitulo;
        private string _Precio;
        private string _Estado;
        private DateTime _FechaRegistro;

        public float Id { get => _Id; set => _Id = value; }
        public float NumeroCertTitulo { get => _NumeroCertTitulo; set => _NumeroCertTitulo = value; }
        public float CantidadMetros { get => _CantidadMetros; set => _CantidadMetros = value; }
        public float Numero { get => _Numero; set => _Numero = value; }
        public string Coordenadas { get => _Coordenadas; set => _Coordenadas = value; }
        public string ColindSolar { get => _ColindSolar; set => _ColindSolar = value; }
        public string DescAddPropiedad { get => _DescAddPropiedad; set => _DescAddPropiedad = value; }
        public float InfoPropietario { get => _InfoPropietario; set => _InfoPropietario = value; }
        public byte[] ImagenTitulo { get => _ImagenTitulo; set => _ImagenTitulo = value; }
        public string Precio { get => _Precio; set => _Precio = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public DateTime FechaRegistro { get => _FechaRegistro; set => _FechaRegistro = value; }
       

        public E_Solares()
        {

        }

        public E_Solares(float Id, float numCertTitulo, float CantidadM, float Num, string Coor, string Colind, string DescAddProp, float InforProp, byte[]ImagenTitulo, string Precio, string Estado, DateTime FechaR)
        {
            _Id = Id;
            _NumeroCertTitulo = numCertTitulo;
            _CantidadMetros = CantidadM;
            _Numero = Num;
            _Coordenadas = Coor;
            _ColindSolar = Colind;
            _DescAddPropiedad = DescAddProp;
            _InfoPropietario = InforProp;
            _ImagenTitulo = ImagenTitulo;
            _Precio = Precio;
            _Estado = Estado;
            _FechaRegistro = FechaR;
        }
    }
}
