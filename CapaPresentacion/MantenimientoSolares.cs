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

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantenimientoSolares : MetroFramework.Forms.MetroForm
    {
        private N_Solares N_Solares = new N_Solares();
        private E_Solares E_Solares = new E_Solares();

        static string IdSolar, NumCerTit, CantMetros, Numero,
            Coor, Colind, IdSolarInfo, DescripAdd, InformProp,
            Precio, Estado;
        static byte[] ImageTitulo;

        string ImagLoc = "";
        public MantenimientoSolares()
        {
            InitializeComponent();
        }
        public MantenimientoSolares(string busIdSolar, string busNumCertTit, string busCantMetros,
            string busNumero, string busCoor, string busColind, string busIdSolarInfo,
            string busDescripAdd, string busInformProp, byte[] busImagenTitulo, string busPrecio,
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
        }

        private void MantenimientoSolares_Load(object sender, EventArgs e)
        {
            rbNuevo.Checked = true;
            lblSolar.Visible = false;
            txtIdSolar.Visible = false;
            btnBuscar.Visible = false;
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            lblSolar.Visible = true;
            txtIdSolar.Visible = true;
            btnBuscar.Visible = true;
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            lblSolar.Visible = true;
            txtIdSolar.Visible = true;
            btnBuscar.Visible = true;
        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            lblSolar.Visible = false;
            txtIdSolar.Visible = false;
            btnBuscar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarSolar B = new BuscarSolar();

            B.formMantenimientoS = true;
            B.ShowDialog();

            if (B.formMantenimientoS)
            {
                txtIdSolar.Text = IdSolar;
                txtNumero.Text = Numero;
                txtCoordenadas.Text = Coor;
                txtNumCertTitulo.Text = NumCerTit;
                txtDescAddTitulo.Text = DescripAdd;
                txtMetros.Text = CantMetros;
                txtPropietario.Text = InformProp;
                txtColindSolar.Text = Colind;
                txtPrecio.Text = Precio;
                txtEstado.Text = Estado;
                
                MemoryStream ms = new MemoryStream(ImageTitulo);
                picImagenTitulo.Image = Image.FromStream(ms);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (rbNuevo.Checked)
            {
                InsertarSolar();
            }
            else if (rbModificar.Checked)
            {
                ModificarSolar();
            }else if (rbEliminar.Checked)
            {
                EliminarSolar();
            }
        }

        private void InsertarSolar()
        {
            try
            {
                E_Solares.Numero = Convert.ToSingle(txtNumero.Text);
                E_Solares.Coordenadas = txtCoordenadas.Text;
                E_Solares.NumeroCertTitulo = Convert.ToSingle(txtNumCertTitulo.Text);
                E_Solares.DescAddPropiedad = txtDescAddTitulo.Text;
                E_Solares.CantidadMetros = Convert.ToSingle(txtMetros.Text);
                E_Solares.InfoPropietario = Convert.ToSingle(txtPropietario.Text);
                E_Solares.ColindSolar = txtColindSolar.Text;
                E_Solares.Precio = txtPrecio.Text;
                E_Solares.Estado = txtEstado.Text;
                E_Solares.FechaRegistro = DateTime.Now.Date;
                ImageTituloConvert();

                if (N_Solares.N_InsertarSolar(E_Solares) == 2)
                {
                    MessageBox.Show("Se ha guardado el Solar satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            }

        private void ModificarSolar()
        {
            try
            {
                E_Solares.Id = Convert.ToSingle(txtIdSolar.Text);
                E_Solares.Numero = Convert.ToSingle(txtNumero.Text);
                E_Solares.Coordenadas = txtCoordenadas.Text;
                E_Solares.NumeroCertTitulo = Convert.ToSingle(txtNumCertTitulo.Text);
                E_Solares.DescAddPropiedad = txtDescAddTitulo.Text;
                E_Solares.CantidadMetros = Convert.ToSingle(txtMetros.Text);
                E_Solares.InfoPropietario = Convert.ToSingle(txtPropietario.Text);
                E_Solares.ColindSolar = txtColindSolar.Text;
                E_Solares.Precio = txtPrecio.Text;
                E_Solares.Estado = txtEstado.Text;
                E_Solares.FechaRegistro = DateTime.Now.Date;
                ImageTituloConvert();

               if(N_Solares.N_ModificarSolar(E_Solares) == 2)
                {
                    MessageBox.Show("Se ha modificado el Solar satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void EliminarSolar()
        {
            try {
                E_Solares.Id = Convert.ToSingle(txtIdSolar.Text);
                if (N_Solares.N_EliminarSolar(E_Solares) == 2)
                {
                    MessageBox.Show("Se ha eliminado el Solar satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnAgImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";
                ofd.Title = "Seleccione imagen de titulo";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImagLoc = ofd.FileName.ToString();
                    picImagenTitulo.ImageLocation = ImagLoc;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void ImageTituloConvert()
        {
            byte[] img = null;
            FileStream fs = new FileStream(ImagLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            E_Solares.ImagenTitulo = img;
        }
    }
}
