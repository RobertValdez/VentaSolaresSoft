using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Facturacion : MetroFramework.Forms.MetroForm
    {
        N_Facturacion N_Facturacion = new N_Facturacion();
        E_Facturacion E_Facturacion = new E_Facturacion();

        public string CedulaEmpleado = "";

        static string IdSolar, NumCerTit, Coor, Numero, Precio;
        static string strBuscarCliente;
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
        public Facturacion(string buscarCliente)
        {
            strBuscarCliente = buscarCliente;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = CedulaEmpleado;

            txtTiempoAPagar.Visible = false;
            lblTiempoAPagar.Visible = false;
            lblMesesApagar.Visible = false;
            txtInicial.Visible = false;
            chkConInicial.Visible = false;
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
            BuscarClientes bc = new BuscarClientes();
            bc.frmFacturacion = true;
            bc.ShowDialog();

            txtCliente.Text = strBuscarCliente;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cotizacion c = new Cotizacion();
            c.Show(this);
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            //try
            //{
                InsertarCompra();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void rbActoDefinitivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActoDefinitivo.Checked)
            {
                txtTiempoAPagar.Visible = false;
                lblTiempoAPagar.Visible = false;
                lblMesesApagar.Visible = false;
                txtInicial.Visible = false;
                chkConInicial.Visible = false;
                chkConInicial.Checked = false;
            }
        }

        private void rbActoProvisional_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActoProvisional.Checked)
            {
                txtTiempoAPagar.Visible = true;
                lblTiempoAPagar.Visible = true;
                lblMesesApagar.Visible = true;
                txtInicial.Visible = true;
                chkConInicial.Visible = true;
            }
        }

        private void InsertarCompra()
        {
            E_Facturacion.Ced_Solar = Convert.ToInt64(lstvAgregarSolar.Items[0].SubItems[3].Text);
            E_Facturacion.Cliente = Convert.ToInt16(txtCliente.Text);
            E_Facturacion.Vendedor = Convert.ToInt32(txtVendedor.Text);
            E_Facturacion.Inicial = Convert.ToInt32(txtInicial.Text);
            E_Facturacion.SubTotal = Convert.ToInt32(txtSubtotal.Text);

            if (txtDescuento.Text.Equals(""))
            {
                E_Facturacion.Descuento = 0;// (txtDescuento.Text);
            }
            else
            {
                E_Facturacion.Descuento = Convert.ToInt16(txtDescuento.Text);
            }

            E_Facturacion.Total = Convert.ToInt32(txtTotal.Text);
            E_Facturacion.Cuotas = Convert.ToInt16(txtTiempoAPagar.Text);
            E_Facturacion.Notario = Convert.ToInt32(txtNotario.Text);
            E_Facturacion.Abogado = txtAbogado.Text;
            E_Facturacion.Fecha = DateTime.Today;


             MessageBox.Show(""+ N_Facturacion.N_InsertarCompra(E_Facturacion));
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
