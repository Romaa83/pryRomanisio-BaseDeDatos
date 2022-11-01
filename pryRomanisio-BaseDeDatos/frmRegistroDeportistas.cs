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
    public partial class frmRegistroDeportistas : Form
    {
        OleDbConnection conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();

        public frmRegistroDeportistas()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
         
        }

        private void nudTelefono_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistroDeportistas_Load(object sender, EventArgs e)
        {
            try
            {
                conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
                conexion.Open();
                SSEstado.BackColor = Color.Green;
                toolStripStatusLabel1.Text = "Conectado a la base de datos" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                toolStripStatusLabel1.Text = mensajito.Message;
                SSEstado.BackColor = Color.DarkRed;

            }
            conexion.Close();
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                ComandoBD.Connection = conexion;

                ComandoBD.CommandText = "INSERT INTO DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], APELLIDO, DIRECCION, TELEFONO, EDAD, DEPORTE)" +
                "VALUES ('" + txtCodDeportista.Text + "','" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + Convert.ToInt32(nudEdad.Text) + "', '" + cboDeporte.Text + "')";
                ComandoBD.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception mensajito)
            {
                SSEstado.BackColor = Color.DarkRed;
                toolStripStatusLabel1.Text = mensajito.Message;
            }
        }
    }
    
}
