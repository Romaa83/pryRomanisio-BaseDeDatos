using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryRomanisio_BaseDeDatos
{
    public partial class frmRegistroDeEntrenadores : Form
    {
        OleDbConnection conexionRegistroEntrenadores = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();

        public frmRegistroDeEntrenadores()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionRegistroEntrenadores.Open();
                ComandoBD.Connection = conexionRegistroEntrenadores;

                ComandoBD.CommandText = "INSERT INTO ENTRENADORES ([CODIGO ENTRENADORES], [NOMBRE], APELLIDO, DIRECCION, PROVINCIA, DEPORTE)" +
                "VALUES ('" + txtCodDeportista.Text + "','" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + txtProvincia.Text + "', '" + cboDeporte.Text + "')";
                ComandoBD.ExecuteNonQuery();
                conexionRegistroEntrenadores.Close();
                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception mensajito)
            {
                MessageBox.Show(mensajito.Message);
                throw;
            }
        }

        private void frmRegistroDeEntrenadores_Load(object sender, EventArgs e)
        {
            try
            {
                conexionRegistroEntrenadores = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
                conexionRegistroEntrenadores.Open();
                SSEstado.BackColor = Color.Green;
                toolStripStatusLabel2.Text = "Conectado a la base de datos" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                toolStripStatusLabel1.Text = mensajito.Message;
                SSEstado.BackColor = Color.DarkRed;

            }
            conexionRegistroEntrenadores.Close();
        }
    }
}
