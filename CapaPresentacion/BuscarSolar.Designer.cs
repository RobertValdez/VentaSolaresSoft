namespace CapaPresentacion
{
    partial class BuscarSolar
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
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.dgvSolares = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolares)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTitulo);
            this.groupBox1.Controls.Add(this.dgvSolares);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1261, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // picTitulo
            // 
            this.picTitulo.Location = new System.Drawing.Point(977, 57);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(312, 536);
            this.picTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitulo.TabIndex = 9;
            this.picTitulo.TabStop = false;
            // 
            // dgvSolares
            // 
            this.dgvSolares.AllowUserToAddRows = false;
            this.dgvSolares.AllowUserToDeleteRows = false;
            this.dgvSolares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolares.Location = new System.Drawing.Point(12, 57);
            this.dgvSolares.Name = "dgvSolares";
            this.dgvSolares.ReadOnly = true;
            this.dgvSolares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolares.Size = new System.Drawing.Size(959, 542);
            this.dgvSolares.TabIndex = 8;
            this.dgvSolares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolares_CellClick);
            this.dgvSolares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolares_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1118, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "TITULO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "BUSCAR";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(298, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(533, 26);
            this.txtBuscar.TabIndex = 6;
            // 
            // BuscarSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 605);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarSolar";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "BUSCAR SOLAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarSolar_FormClosing);
            this.Load += new System.EventHandler(this.BuscarSolar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSolares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Label label2;
    }
}