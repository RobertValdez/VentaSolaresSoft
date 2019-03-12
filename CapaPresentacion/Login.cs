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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        E_AccesoUsuario E_AccesoUsuario = new E_AccesoUsuario();
        N_AccesoUsuario N_AccesoUsuario = new N_AccesoUsuario();
        public Login()
        {
            InitializeComponent();
        }

        public void Acceso()
        {
            E_AccesoUsuario.Usuario = txtUsuario.Text;
            E_AccesoUsuario.Contrasena = txtContrasena.Text;

            if (N_AccesoUsuario.N_rspAccesoUsuario(E_AccesoUsuario).Equals(1))
            {
                MenuPrincipal mP = new MenuPrincipal();
                mP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos. Vuelva a intentarlo.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                Acceso();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
