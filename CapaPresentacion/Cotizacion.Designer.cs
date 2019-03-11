namespace CapaPresentacion
{
    partial class Cotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInicial = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescuento2 = new System.Windows.Forms.TextBox();
            this.lblInicial = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTiempoAPagar = new System.Windows.Forms.TextBox();
            this.dgvSolares = new System.Windows.Forms.DataGridView();
            this.columnIdSolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNumCertTitu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantMetros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCoor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnColind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdSolarInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescrAddProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnInfoProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnImagenTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.btnDescontar = new System.Windows.Forms.Button();
            this.btnAnadirSolar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescuento1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolares)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkInicial);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTiempoAPagar);
            this.groupBox1.Controls.Add(this.dgvSolares);
            this.groupBox1.Controls.Add(this.btnCotizar);
            this.groupBox1.Controls.Add(this.btnDescontar);
            this.groupBox1.Controls.Add(this.btnAnadirSolar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescuento1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkInicial
            // 
            this.chkInicial.AutoSize = true;
            this.chkInicial.Location = new System.Drawing.Point(54, 119);
            this.chkInicial.Name = "chkInicial";
            this.chkInicial.Size = new System.Drawing.Size(114, 22);
            this.chkInicial.TabIndex = 10;
            this.chkInicial.Text = "Con Inicial";
            this.chkInicial.UseVisualStyleBackColor = true;
            this.chkInicial.CheckedChanged += new System.EventHandler(this.chkInicial_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtInicial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMora);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCuotas);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDescuento2);
            this.groupBox2.Controls.Add(this.lblInicial);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Location = new System.Drawing.Point(561, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 134);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "SUBTOTAL";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(429, 87);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.ReadOnly = true;
            this.txtInicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInicial.Size = new System.Drawing.Size(176, 26);
            this.txtInicial.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "CUOTAS";
            // 
            // txtMora
            // 
            this.txtMora.Location = new System.Drawing.Point(429, 51);
            this.txtMora.Name = "txtMora";
            this.txtMora.ReadOnly = true;
            this.txtMora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMora.Size = new System.Drawing.Size(176, 26);
            this.txtMora.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "MORA";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(429, 19);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.ReadOnly = true;
            this.txtCuotas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCuotas.Size = new System.Drawing.Size(176, 26);
            this.txtCuotas.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "DESCUENTO";
            // 
            // txtDescuento2
            // 
            this.txtDescuento2.Location = new System.Drawing.Point(120, 51);
            this.txtDescuento2.Name = "txtDescuento2";
            this.txtDescuento2.ReadOnly = true;
            this.txtDescuento2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescuento2.Size = new System.Drawing.Size(176, 26);
            this.txtDescuento2.TabIndex = 8;
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(348, 90);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(69, 18);
            this.lblInicial.TabIndex = 6;
            this.lblInicial.Text = "INICIAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(120, 86);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(176, 26);
            this.txtTotal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOTAL";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(120, 19);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotal.Size = new System.Drawing.Size(176, 26);
            this.txtSubTotal.TabIndex = 8;
            // 
            // txtTiempoAPagar
            // 
            this.txtTiempoAPagar.Location = new System.Drawing.Point(270, 34);
            this.txtTiempoAPagar.Name = "txtTiempoAPagar";
            this.txtTiempoAPagar.Size = new System.Drawing.Size(148, 26);
            this.txtTiempoAPagar.TabIndex = 4;
            // 
            // dgvSolares
            // 
            this.dgvSolares.AllowUserToAddRows = false;
            this.dgvSolares.AllowUserToDeleteRows = false;
            this.dgvSolares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdSolar,
            this.columNumCertTitu,
            this.columnCantMetros,
            this.columnNum,
            this.columnCoor,
            this.columnColind,
            this.columnIdSolarInfo,
            this.columnDescrAddProp,
            this.columnInfoProp,
            this.columnImagenTitulo,
            this.columnPrecio,
            this.columnEstado,
            this.columnFecha});
            this.dgvSolares.Location = new System.Drawing.Point(12, 154);
            this.dgvSolares.Name = "dgvSolares";
            this.dgvSolares.ReadOnly = true;
            this.dgvSolares.Size = new System.Drawing.Size(1190, 355);
            this.dgvSolares.TabIndex = 2;
            // 
            // columnIdSolar
            // 
            this.columnIdSolar.HeaderText = "IdSolar";
            this.columnIdSolar.Name = "columnIdSolar";
            this.columnIdSolar.ReadOnly = true;
            // 
            // columNumCertTitu
            // 
            this.columNumCertTitu.HeaderText = "Número de Certificado de Titulo";
            this.columNumCertTitu.Name = "columNumCertTitu";
            this.columNumCertTitu.ReadOnly = true;
            // 
            // columnCantMetros
            // 
            this.columnCantMetros.HeaderText = "Cantidad de Metros";
            this.columnCantMetros.Name = "columnCantMetros";
            this.columnCantMetros.ReadOnly = true;
            // 
            // columnNum
            // 
            this.columnNum.HeaderText = "Número";
            this.columnNum.Name = "columnNum";
            this.columnNum.ReadOnly = true;
            // 
            // columnCoor
            // 
            this.columnCoor.HeaderText = "Coordenadas";
            this.columnCoor.Name = "columnCoor";
            this.columnCoor.ReadOnly = true;
            // 
            // columnColind
            // 
            this.columnColind.HeaderText = "Colindantes del Solar";
            this.columnColind.Name = "columnColind";
            this.columnColind.ReadOnly = true;
            // 
            // columnIdSolarInfo
            // 
            this.columnIdSolarInfo.HeaderText = "IdSolar";
            this.columnIdSolarInfo.Name = "columnIdSolarInfo";
            this.columnIdSolarInfo.ReadOnly = true;
            // 
            // columnDescrAddProp
            // 
            this.columnDescrAddProp.HeaderText = "Descripción de adquisición de la propiedad";
            this.columnDescrAddProp.Name = "columnDescrAddProp";
            this.columnDescrAddProp.ReadOnly = true;
            // 
            // columnInfoProp
            // 
            this.columnInfoProp.HeaderText = "Información del propietario";
            this.columnInfoProp.Name = "columnInfoProp";
            this.columnInfoProp.ReadOnly = true;
            // 
            // columnImagenTitulo
            // 
            this.columnImagenTitulo.HeaderText = "Imagen de Titulo";
            this.columnImagenTitulo.Name = "columnImagenTitulo";
            this.columnImagenTitulo.ReadOnly = true;
            this.columnImagenTitulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnImagenTitulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnPrecio
            // 
            this.columnPrecio.HeaderText = "Precio";
            this.columnPrecio.Name = "columnPrecio";
            this.columnPrecio.ReadOnly = true;
            // 
            // columnEstado
            // 
            this.columnEstado.HeaderText = "Estado";
            this.columnEstado.Name = "columnEstado";
            this.columnEstado.ReadOnly = true;
            // 
            // columnFecha
            // 
            this.columnFecha.HeaderText = "Fecha de Registro";
            this.columnFecha.Name = "columnFecha";
            this.columnFecha.ReadOnly = true;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(414, 112);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(141, 34);
            this.btnCotizar.TabIndex = 1;
            this.btnCotizar.Text = "COTIZAR";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // btnDescontar
            // 
            this.btnDescontar.Font = new System.Drawing.Font("Lucida Fax", 9F);
            this.btnDescontar.Location = new System.Drawing.Point(424, 68);
            this.btnDescontar.Name = "btnDescontar";
            this.btnDescontar.Size = new System.Drawing.Size(93, 23);
            this.btnDescontar.TabIndex = 1;
            this.btnDescontar.Text = "DESCONTAR";
            this.btnDescontar.UseVisualStyleBackColor = true;
            // 
            // btnAnadirSolar
            // 
            this.btnAnadirSolar.Location = new System.Drawing.Point(267, 112);
            this.btnAnadirSolar.Name = "btnAnadirSolar";
            this.btnAnadirSolar.Size = new System.Drawing.Size(141, 34);
            this.btnAnadirSolar.TabIndex = 1;
            this.btnAnadirSolar.Text = "AÑADIR SOLAR";
            this.btnAnadirSolar.UseVisualStyleBackColor = true;
            this.btnAnadirSolar.Click += new System.EventHandler(this.btnAnadirSolar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "TIEMPO DE PAGO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.label10.Location = new System.Drawing.Point(199, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 14);
            this.label10.TabIndex = 5;
            this.label10.Text = "(por meses)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.label9.Location = new System.Drawing.Point(239, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "(opcional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESCUENTO";
            // 
            // txtDescuento1
            // 
            this.txtDescuento1.Location = new System.Drawing.Point(305, 66);
            this.txtDescuento1.Name = "txtDescuento1";
            this.txtDescuento1.Size = new System.Drawing.Size(113, 26);
            this.txtDescuento1.TabIndex = 8;
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cotizacion";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescuento1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTiempoAPagar;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Button btnAnadirSolar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvSolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdSolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columNumCertTitu;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantMetros;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCoor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnColind;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdSolarInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescrAddProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnInfoProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnImagenTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescuento2;
        private System.Windows.Forms.Button btnDescontar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkInicial;
    }
}