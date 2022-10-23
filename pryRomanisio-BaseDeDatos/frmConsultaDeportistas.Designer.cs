namespace pryRomanisio_BaseDeDatos
{
    partial class frmConsultaDeportistas
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
            this.dgvDeportistas = new System.Windows.Forms.DataGridView();
            this.CodigoDeportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultarDeportista = new System.Windows.Forms.Button();
            this.SSEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistas)).BeginInit();
            this.SSEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeportistas
            // 
            this.dgvDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeportista,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Edad,
            this.Deporte});
            this.dgvDeportistas.Location = new System.Drawing.Point(12, 12);
            this.dgvDeportistas.Name = "dgvDeportistas";
            this.dgvDeportistas.Size = new System.Drawing.Size(796, 374);
            this.dgvDeportistas.TabIndex = 0;
            // 
            // CodigoDeportista
            // 
            this.CodigoDeportista.HeaderText = "Codigo Deportista";
            this.CodigoDeportista.Name = "CodigoDeportista";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Deporte
            // 
            this.Deporte.HeaderText = "Deporte";
            this.Deporte.Name = "Deporte";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultarDeportista
            // 
            this.btnConsultarDeportista.Location = new System.Drawing.Point(731, 397);
            this.btnConsultarDeportista.Name = "btnConsultarDeportista";
            this.btnConsultarDeportista.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarDeportista.TabIndex = 3;
            this.btnConsultarDeportista.Text = "Consultar";
            this.btnConsultarDeportista.UseVisualStyleBackColor = true;
            this.btnConsultarDeportista.Click += new System.EventHandler(this.btnConsultarDeportista_Click);
            // 
            // SSEstado
            // 
            this.SSEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.SSEstado.Location = new System.Drawing.Point(0, 436);
            this.SSEstado.Name = "SSEstado";
            this.SSEstado.Size = new System.Drawing.Size(818, 22);
            this.SSEstado.TabIndex = 4;
            this.SSEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmConsultaDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.SSEstado);
            this.Controls.Add(this.btnConsultarDeportista);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDeportistas);
            this.Name = "frmConsultaDeportistas";
            this.Text = "Consulta Deportistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistas)).EndInit();
            this.SSEstado.ResumeLayout(false);
            this.SSEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeportistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultarDeportista;
        private System.Windows.Forms.StatusStrip SSEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}