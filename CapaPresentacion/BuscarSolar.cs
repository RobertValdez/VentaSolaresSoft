using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class BuscarSolar : MetroFramework.Forms.MetroForm
    {
        private N_Solares N_solares = new N_Solares();

        public bool formCotizacion = false;
        bool formCotizacionClosed = true;
        public bool formFacturacion = false;
        public bool formMantenimientoS = false;
            
        public BuscarSolar()
        {
            InitializeComponent();
        }

        private void BuscarSolar_Load(object sender, EventArgs e)
        {
            dgvSolares.DataSource = N_solares.N_MostrarSolares();
        }

        private void dgvSolares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvSolares.CurrentRow;
                byte[] image = (byte[])(row.Cells[9].Value);
                MemoryStream ms = new MemoryStream(image);
                picTitulo.Image = Image.FromStream(ms);
            }
            catch (Exception) {  }
        }

        private void dgvSolares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (formCotizacion)
                {
                    Cotizacion C = new Cotizacion(this.dgvSolares.CurrentRow.Cells[0].Value.ToString(), this.dgvSolares.CurrentRow.Cells[1].Value.ToString(),
                        this.dgvSolares.CurrentRow.Cells[2].Value.ToString(), this.dgvSolares.CurrentRow.Cells[3].Value.ToString(), this.dgvSolares.CurrentRow.Cells[4].Value.ToString(), this.dgvSolares.CurrentRow.Cells[5].Value.ToString(),
                        this.dgvSolares.CurrentRow.Cells[6].Value.ToString(), this.dgvSolares.CurrentRow.Cells[7].Value.ToString(), this.dgvSolares.CurrentRow.Cells[8].Value.ToString(), this.dgvSolares.CurrentRow.Cells[9].Value.ToString(), this.dgvSolares.CurrentRow.Cells[10].Value.ToString(),
                        this.dgvSolares.CurrentRow.Cells[11].Value.ToString(), this.dgvSolares.CurrentRow.Cells[12].Value.ToString());

                    formCotizacionClosed = false;
                    this.Close();
                }
                if (formFacturacion)
                {
                    Facturacion F = new Facturacion(this.dgvSolares.CurrentRow.Cells[0].Value.ToString(),
                        this.dgvSolares.CurrentRow.Cells[1].Value.ToString(),
                       this.dgvSolares.CurrentRow.Cells[3].Value.ToString(),
                       this.dgvSolares.CurrentRow.Cells[4].Value.ToString(),
                       this.dgvSolares.CurrentRow.Cells[10].Value.ToString());

                    formCotizacionClosed = false;
                    this.Close();
                }
                if (formMantenimientoS)
                {
                    MantenimientoSolares M = new MantenimientoSolares(this.dgvSolares.CurrentRow.Cells[0].Value.ToString(), this.dgvSolares.CurrentRow.Cells[1].Value.ToString(),
                        this.dgvSolares.CurrentRow.Cells[2].Value.ToString(), this.dgvSolares.CurrentRow.Cells[3].Value.ToString(), this.dgvSolares.CurrentRow.Cells[4].Value.ToString(), this.dgvSolares.CurrentRow.Cells[5].Value.ToString(),
                        this.dgvSolares.CurrentRow.Cells[6].Value.ToString(), this.dgvSolares.CurrentRow.Cells[7].Value.ToString(), this.dgvSolares.CurrentRow.Cells[8].Value.ToString(), (byte[])this.dgvSolares.CurrentRow.Cells[9].Value, this.dgvSolares.CurrentRow.Cells[10].Value.ToString(),
                        this.dgvSolares.CurrentRow.Cells[11].Value.ToString(), this.dgvSolares.CurrentRow.Cells[12].Value.ToString());

                    var row = dgvSolares.CurrentRow;
                    byte[] image = (byte[])(row.Cells[9].Value);
                    MemoryStream ms = new MemoryStream(image);
                    picTitulo.Image = Image.FromStream(ms);


                    formCotizacionClosed = false;
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BuscarSolar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formCotizacionClosed)
            {
                formCotizacion = false;
            }
        }
    }
}

