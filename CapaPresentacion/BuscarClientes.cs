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
    public partial class BuscarClientes : MetroFramework.Forms.MetroForm
    {
        N_BuscarClientes N_BuscarClientes = new N_BuscarClientes();

        public bool frmFacturacion = false;

        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
          dgvClientes.DataSource = N_BuscarClientes.N_MostrarClientes();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmFacturacion == true)
            {
                var rowIdCliente = dgvClientes.CurrentRow;
                Facturacion f  = new Facturacion(rowIdCliente.Cells[3].Value.ToString());
                this.Close();
            }
        }
    }
}
