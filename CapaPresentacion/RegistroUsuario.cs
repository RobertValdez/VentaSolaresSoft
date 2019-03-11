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
    public partial class RegistroUsuario : MetroFramework.Forms.MetroForm
    {
        //Clases
        private N_Usuarios N_Usuarios = new N_Usuarios();
        private E_Usuarios E_Usuarios = new E_Usuarios();

        //Variables
        bool vNomUser = false;
        bool vCedEmpl = false;

        public RegistroUsuario()
        {
            InitializeComponent();
        }

        public void ComprobarCedula(E_Usuarios CompCed)
        {
           if (N_Usuarios.N_rptComprobar(CompCed) == "0")
            {
                lblCedulaEmpleado.Text = "El número de cédula no es un empleado registrado.";
                lblCedulaEmpleado.ForeColor = Color.Red;
            }
            else
            {
                vCedEmpl = true;
                lblCedulaEmpleado.Text = "*";
                lblCedulaEmpleado.ForeColor = Color.Green;
            }
        }

        public void ComprobarNomUser(E_Usuarios eUser)
        {
            try
            {
                if (N_Usuarios.N_rptCompNombUser(eUser) == "0")
                {
                    lblComprobarNombre.Text = "Nombre disponible";
                    lblComprobarNombre.ForeColor = Color.Green;
                    vNomUser = true;
                }
                else
                {
                    lblComprobarNombre.Text = "El nombre de usuario en uso. Intente con otro.";
                    lblComprobarNombre.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            try
            {
                E_Usuarios.ComprobarNomUser = txtNombre.Text;
                ComprobarNomUser(E_Usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCedulaEmpl_Leave(object sender, EventArgs e)
        {
            try
            {
                E_Usuarios.ComprobarCedula = txtCedulaEmpl.Text;
                ComprobarCedula(E_Usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRepetirContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text != txtRepetirContrasena.Text && txtRepetirContrasena.Text != "")
            {
                lblRepetContra.Text = "La contraseña no coincide. Vuelva a intentarlo.";
                lblRepetContra.ForeColor = Color.Red;
                txtRepetirContrasena.Clear();
                txtRepetirContrasena.Focus();
            }
            else
            {
                lblRepetContra.Text = "*";
                lblRepetContra.ForeColor = Color.Green;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtContrasena.Text);
        }

        private void txtContrasena_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtContrasena.TextLength <= 5)
            {
                lblComprobarContra.Text = "La contraseña debe tener más de 5 caractéres.";
                lblComprobarContra.ForeColor = Color.Red;
            }
            else
            {
                lblComprobarContra.Text = "*";
                lblComprobarContra.ForeColor = Color.Green;
            }
        }
    }
}
