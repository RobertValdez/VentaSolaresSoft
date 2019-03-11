namespace CapaPresentacion
{
    partial class RegistroUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCedulaEmpl = new System.Windows.Forms.TextBox();
            this.txtRepetirContrasena = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCedulaEmpleado = new System.Windows.Forms.Label();
            this.lblRepetContra = new System.Windows.Forms.Label();
            this.lblComprobarContra = new System.Windows.Forms.Label();
            this.lblComprobarNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtCedulaEmpl);
            this.groupBox1.Controls.Add(this.txtRepetirContrasena);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCedulaEmpleado);
            this.groupBox1.Controls.Add(this.lblRepetContra);
            this.groupBox1.Controls.Add(this.lblComprobarContra);
            this.groupBox1.Controls.Add(this.lblComprobarNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(286, 254);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(105, 25);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(30, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 25);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCedulaEmpl
            // 
            this.txtCedulaEmpl.Location = new System.Drawing.Point(224, 183);
            this.txtCedulaEmpl.Name = "txtCedulaEmpl";
            this.txtCedulaEmpl.Size = new System.Drawing.Size(276, 26);
            this.txtCedulaEmpl.TabIndex = 3;
            this.txtCedulaEmpl.Leave += new System.EventHandler(this.txtCedulaEmpl_Leave);
            // 
            // txtRepetirContrasena
            // 
            this.txtRepetirContrasena.Location = new System.Drawing.Point(224, 133);
            this.txtRepetirContrasena.Name = "txtRepetirContrasena";
            this.txtRepetirContrasena.PasswordChar = '●';
            this.txtRepetirContrasena.Size = new System.Drawing.Size(276, 26);
            this.txtRepetirContrasena.TabIndex = 2;
            this.txtRepetirContrasena.Leave += new System.EventHandler(this.txtRepetirContrasena_Leave);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(224, 86);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '●';
            this.txtContrasena.Size = new System.Drawing.Size(276, 26);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContrasena_KeyUp);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(224, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 26);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "CEDULA EMPLEADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "REPETIR CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "CONTRASEÑA";
            // 
            // lblCedulaEmpleado
            // 
            this.lblCedulaEmpleado.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaEmpleado.Location = new System.Drawing.Point(221, 212);
            this.lblCedulaEmpleado.Name = "lblCedulaEmpleado";
            this.lblCedulaEmpleado.Size = new System.Drawing.Size(279, 39);
            this.lblCedulaEmpleado.TabIndex = 1;
            this.lblCedulaEmpleado.Text = "0";
            // 
            // lblRepetContra
            // 
            this.lblRepetContra.AutoSize = true;
            this.lblRepetContra.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetContra.Location = new System.Drawing.Point(221, 164);
            this.lblRepetContra.Name = "lblRepetContra";
            this.lblRepetContra.Size = new System.Drawing.Size(16, 16);
            this.lblRepetContra.TabIndex = 1;
            this.lblRepetContra.Text = "0";
            // 
            // lblComprobarContra
            // 
            this.lblComprobarContra.AutoSize = true;
            this.lblComprobarContra.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobarContra.Location = new System.Drawing.Point(221, 115);
            this.lblComprobarContra.Name = "lblComprobarContra";
            this.lblComprobarContra.Size = new System.Drawing.Size(16, 16);
            this.lblComprobarContra.TabIndex = 1;
            this.lblComprobarContra.Text = "0";
            // 
            // lblComprobarNombre
            // 
            this.lblComprobarNombre.AutoSize = true;
            this.lblComprobarNombre.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobarNombre.Location = new System.Drawing.Point(221, 69);
            this.lblComprobarNombre.Name = "lblComprobarNombre";
            this.lblComprobarNombre.Size = new System.Drawing.Size(16, 16);
            this.lblComprobarNombre.TabIndex = 1;
            this.lblComprobarNombre.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistroUsuario";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCedulaEmpl;
        private System.Windows.Forms.TextBox txtRepetirContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCedulaEmpleado;
        private System.Windows.Forms.Label lblRepetContra;
        private System.Windows.Forms.Label lblComprobarContra;
        private System.Windows.Forms.Label lblComprobarNombre;
    }
}

