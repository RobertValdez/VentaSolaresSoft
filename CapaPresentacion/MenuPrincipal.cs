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
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public string CedulaEmpleado = "";

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            Facturacion f = new Facturacion();
            f.CedulaEmpleado = CedulaEmpleado;
            f.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            RegistroUsuario rs = new RegistroUsuario();
            rs.ShowDialog();
        }

        private void btnRegistroCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSolares_Click(object sender, EventArgs e)
        {
            MantenimientoSolares ms = new MantenimientoSolares();
            ms.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            RegistroEmpleado re = new RegistroEmpleado();
            re.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {

        }
    }
}
