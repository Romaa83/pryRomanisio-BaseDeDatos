namespace pryRomanisio_BaseDeDatos
{
    partial class frmConsultaEntrenadores
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
            this.SSEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.CodigoDeportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarEntrenadores = new System.Windows.Forms.Button();
            this.SSEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // SSEstado
            // 
            this.SSEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.SSEstado.Location = new System.Drawing.Point(0, 423);
            this.SSEstado.Name = "SSEstado";
            this.SSEstado.Size = new System.Drawing.Size(717, 22);
            this.SSEstado.TabIndex = 8;
            this.SSEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(8, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeportista,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Provicia,
            this.Deporte});
            this.dgvEntrenadores.Location = new System.Drawing.Point(8, 6);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.Size = new System.Drawing.Size(699, 374);
            this.dgvEntrenadores.TabIndex = 5;
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
            // Provicia
            // 
            this.Provicia.HeaderText = "Provincia";
            this.Provicia.Name = "Provicia";
            // 
            // Deporte
            // 
            this.Deporte.HeaderText = "Deporte";
            this.Deporte.Name = "Deporte";
            // 
            // btnConsultarEntrenadores
            // 
            this.btnConsultarEntrenadores.Location = new System.Drawing.Point(630, 386);
            this.btnConsultarEntrenadores.Name = "btnConsultarEntrenadores";
            this.btnConsultarEntrenadores.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEntrenadores.TabIndex = 9;
            this.btnConsultarEntrenadores.Text = "Consultar";
            this.btnConsultarEntrenadores.UseVisualStyleBackColor = true;
            this.btnConsultarEntrenadores.Click += new System.EventHandler(this.btnConsultarEntrenadores_Click);
            // 
            // frmConsultaEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 445);
            this.Controls.Add(this.btnConsultarEntrenadores);
            this.Controls.Add(this.SSEstado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvEntrenadores);
            this.Name = "frmConsultaEntrenadores";
            this.Text = "Consulta Entrenadores";
            this.SSEstado.ResumeLayout(false);
            this.SSEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SSEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvEntrenadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deporte;
        private System.Windows.Forms.Button btnConsultarEntrenadores;
    }
}