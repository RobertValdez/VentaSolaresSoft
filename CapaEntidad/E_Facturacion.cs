using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class E_Facturacion
    {
        private Int64 _Ced_Solar;
        private int _Cliente;
        private int _Vendedor;
        private int _Inicial;
        private int _SubTotal;
        private int _Descuento;
        private int _Total;
        private int _Cuotas;
        private int _Notario;
        private string _Abogado;
        private DateTime _Fecha;

        public int Cliente { get => _Cliente; set => _Cliente = value; }
        public int Vendedor { get => _Vendedor; set => _Vendedor = value; }
        public int SubTotal { get => _SubTotal; set => _SubTotal = value; }
        public int Descuento { get => _Descuento; set => _Descuento = value; }
        public int Total { get => _Total; set => _Total = value; }
        public int Notario { get => _Notario; set => _Notario = value; }
        public string Abogado { get => _Abogado; set => _Abogado = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public Int64 Ced_Solar { get => _Ced_Solar; set => _Ced_Solar = value; }
        public int Inicial { get => _Inicial; set => _Inicial = value; }
        public int Cuotas { get => _Cuotas; set => _Cuotas = value; }

        public E_Facturacion()
        {

        }

        public E_Facturacion(Int64 Ced_Solar, int Cliente, int Vendedor, int Inicial,
            int SubTotal, int Descuento, int Total, int Cuotas, int Notario, string Abogado, DateTime Fecha)
        {
            _Ced_Solar = Ced_Solar;
            _Cliente = Cliente;
            _Vendedor = Vendedor;
            _Inicial = Inicial;
            _SubTotal = SubTotal;
            _Descuento = Descuento;
            _Total = Total;
            _Cuotas = Cuotas;
            _Notario = Notario;
            _Abogado = Abogado;
            _Fecha = Fecha;
        }
    }
}