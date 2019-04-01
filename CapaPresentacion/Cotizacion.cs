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

namespace CapaPresentacion
{
    public partial class Cotizacion : MetroFramework.Forms.MetroForm
    {
        static string IdSolar, NumCerTit, CantMetros, Numero,
            Coor, Colind, IdSolarInfo, DescripAdd, InformProp,
            ImageTitulo, Precio, Estado, FechaRegistro;

        int count;

        public Cotizacion()
        {
            InitializeComponent();
            lblInicial.Visible = false;
            txtInicial.Visible = false;
        }

        public Cotizacion(string busIdSolar, string busNumCertTit, string busCantMetros,
            string busNumero, string busCoor, string busColind, string busIdSolarInfo,
            string busDescripAdd, string busInformProp, string busImagenTitulo, string busPrecio,
            string busEstado, string busFechaRegistro)
        {
            IdSolar = busIdSolar;
            NumCerTit = busNumCertTit;
            CantMetros = busCantMetros;
            Numero = busNumero;
            Coor = busCoor;
            Colind = busColind;
            IdSolarInfo = busIdSolar;
            DescripAdd = busDescripAdd;
            InformProp = busInformProp;
            ImageTitulo = busImagenTitulo;
            Precio = busPrecio;
            Estado = busEstado;
            FechaRegistro = busFechaRegistro;
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {

        }

        private void btnAnadirSolar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarSolar b = new BuscarSolar();
                E_Solares eSolar = new E_Solares();

                b.formCotizacion = true;
                b.ShowDialog();

                if (b.formCotizacion)
                {
                    dgvSolares.Rows.Add();
                    dgvSolares.Rows[count].Cells[0].Value = IdSolar;
                    dgvSolares.Rows[count].Cells[1].Value = NumCerTit;
                    dgvSolares.Rows[count].Cells[2].Value = CantMetros;
                    dgvSolares.Rows[count].Cells[3].Value = Numero;
                    dgvSolares.Rows[count].Cells[4].Value = Coor;
                    dgvSolares.Rows[count].Cells[5].Value = Colind;
                    dgvSolares.Rows[count].Cells[6].Value = IdSolarInfo;
                    dgvSolares.Rows[count].Cells[7].Value = DescripAdd;
                    dgvSolares.Rows[count].Cells[8].Value = InformProp;
                    dgvSolares.Rows[count].Cells[9].Value = ImageTitulo;
                    dgvSolares.Rows[count].Cells[10].Value = Precio;
                    dgvSolares.Rows[count].Cells[11].Value = Estado;
                    dgvSolares.Rows[count].Cells[12].Value = FechaRegistro;
                    count++;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            Cotizar();
        }
        private void Cotizar()
        {
            try
            {
                Int32 SubTotal = 0;
                foreach (DataGridViewRow row in dgvSolares.Rows)
                {
                    SubTotal += Convert.ToInt32(row.Cells[10].Value);
                }
                txtSubTotal.Text = SubTotal.ToString();
                txtTotal.Text = SubTotal.ToString();
                txtInicial.Text = CotizarInicial(SubTotal).ToString();
                float Cuotas = CotizarCuotas(Convert.ToSingle(txtTiempoAPagar.Text), SubTotal);
                txtCuotas.Text = Cuotas.ToString();
                txtMora.Text = CotizarMora(Cuotas).ToString();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private float CotizarInicial(Int32 subTotal)
        {
            float Inicial = (float)subTotal * 0.30f;
            return Inicial;
            //Esta formula es un valor que puede cambiar según las normas de cada lugar de ventas de solares
        }
        private float CotizarMora(float valorMes)
        {
            float Mora = (float)valorMes * 0.03f;
            return Mora;
        }
        private float CotizarCuotas(float tiempoPago, Int32 subTotal)
        {
            float Cuota = subTotal / tiempoPago;
            return Cuota;
        }

        private void chkInicial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInicial.Checked)
            {
                lblInicial.Visible = true;
                txtInicial.Visible = true;
            }
            else
            {
                lblInicial.Visible = false;
                txtInicial.Visible = false;
            }
        }
    }
}
