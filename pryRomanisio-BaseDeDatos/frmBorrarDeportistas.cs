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
    public partial class frmBorrarDeportistas : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();
        int edad = 0;

        public frmBorrarDeportistas()
        {
            InitializeComponent();
        }

        private void frmBorrarDeportistas_Load(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            try
            {
                Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
                Conexion.Open();
                SSEstado.BackColor = Color.Green;
                toolStripStatusLabel1.Text = "Conectado a la base de datos!";
                Conexion.Close();

            }
            catch (Exception errorConex)
            {
                SSEstado.BackColor = Color.DarkRed;
                toolStripStatusLabel1.Text = errorConex.Message;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            if (txtCodigoDeportista.Text != "")
            {
                string CodDeportista = txtCodigoDeportista.Text;
                Conexion.Open();
                ComandoBD.Connection = Conexion;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "DEPORTISTA";
                OleDbDataReader lector = ComandoBD.ExecuteReader();

                while (lector.Read() && lector.GetString(0) != CodDeportista)
                {
                }
                if (lector.GetString(0) == CodDeportista)
                {
                    txtNombre.Text = lector.GetString(1);
                    txtApellido.Text = lector.GetString(2);
                    txtDireccion.Text = lector.GetString(3);
                    txtTelefono.Text = lector.GetString(4);
                    edad = lector.GetInt32(5);
                    cboDeporte.Text = lector.GetString(6);
                    nudEdad.Text = Convert.ToString(edad);
                }
                btnBorrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese un codigo deportista");
            }
            Conexion.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string codigodeportista = txtCodigoDeportista.Text;
            Conexion.Open();
            ComandoBD.Connection = Conexion;
            using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                    "DELETE * FROM DEPORTISTA WHERE [CODIGO DEPORTISTA]=@Codigo", Conexion)) //creo comando, sentencia sql
            {
                commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Codigo", codigodeportista));
                commandUpdate.ExecuteNonQuery();
            }
            MessageBox.Show("Datos borrados correctamente");
        }
    }
}
