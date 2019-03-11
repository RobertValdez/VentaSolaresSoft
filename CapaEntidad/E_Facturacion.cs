using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class E_Facturacion
    {

        private int _IdSolar;
        private int _Cliente;
        private int _Vendedor;
        private int _SubTotal;
        private int _Descuento;
        private int _Total;
        private int _Notario;
        private string _Abogado;
        private DateTime _Fecha;

        public int IdSolar { get => _IdSolar; set => _IdSolar = value; }
        public int Cliente { get => _Cliente; set => _Cliente = value; }
        public int Vendedor { get => _Vendedor; set => _Vendedor = value; }
        public int SubTotal { get => _SubTotal; set => _SubTotal = value; }
        public int Descuento { get => _Descuento; set => _Descuento = value; }
        public int Total { get => _Total; set => _Total = value; }
        public int Notario { get => _Notario; set => _Notario = value; }
        public string Abogado { get => _Abogado; set => _Abogado = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }

        public E_Facturacion()
        {

        }

        public E_Facturacion(int IdSolar, int Cliente, int Vendedor, int SubTotal, int Descuento, int Total, int Notario, string Abogado, DateTime Fecha)
        {
            _IdSolar = IdSolar;
            _Cliente = Cliente;
            _Vendedor = Vendedor;
            _SubTotal = SubTotal;
            _Descuento = Descuento;
            _Total = Total;
            _Notario = Notario;
            _Abogado = Abogado;
            _Fecha = Fecha;
        }
    }
}