using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Facturacion : MetroFramework.Forms.MetroForm
    {
        static string IdSolar, NumCerTit, Coor, Numero, Precio;
        Int32 precio = 0;
        public Facturacion()
        {
            InitializeComponent();
            tmpFechaHora.Start();
        }

        public Facturacion(string busIdSolar, string busNumCerTit,
            string busCoor, string busNumero, string busPrecio)
        {
            IdSolar = busIdSolar;
            NumCerTit = busNumCerTit;
            Coor = busCoor;
            Numero = busNumero;
            Precio = busPrecio;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void tmpFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvAgregarSolar.Items.Count > 0)
                {
                    foreach (ListViewItem eachItem in lstvAgregarSolar.SelectedItems)
                    {
                        RestPrecio(Convert.ToInt32(eachItem.SubItems[4].Text));
                        lstvAgregarSolar.Items.Remove(eachItem);
                    }
                    txtTotal.Text = precio.ToString();
                    txtSubtotal.Text = precio.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cotizacion c = new Cotizacion();
            c.Show(this);
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            
        }
        private void InsertarCompra()
        {
            
        }

        private void btnBuscarSolar_Click(object sender, EventArgs e)
        {
            BuscarSolar B = new BuscarSolar();

            B.formFacturacion = true;
            B.ShowDialog(this);

            
            ListViewItem item = new ListViewItem(IdSolar);
            item.SubItems.Add(NumCerTit);
            item.SubItems.Add(Coor);
            item.SubItems.Add(Numero);
            item.SubItems.Add(Precio);
            lstvAgregarSolar.Items.Add(item);
            
            precio = SumPrecio();
            txtTotal.Text = precio.ToString();
            txtSubtotal.Text = precio.ToString();
        }

        
        private Int32 SumPrecio()
        {
            precio = precio + Convert.ToInt32(Precio);
            return precio;
        }
        private Int32 RestPrecio(Int32 restarPrecio)
        {
            precio = precio - restarPrecio;
            return precio;
        }
    }
}
