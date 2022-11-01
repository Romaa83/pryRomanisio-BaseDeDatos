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
    public partial class frmActualizarDeportista : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbConnection conexion2 = new OleDbConnection();
        OleDbCommand ComandoBD = new OleDbCommand();
        int edad = 0;
        string cadena = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";

        public frmActualizarDeportista()
        {
            InitializeComponent();
        }

        private void frmActualizarDeportista_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
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
                btnActualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese un codigo deportista");
            }
            Conexion.Close();
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            int EdadActualizar = edad;
            string deporte = cboDeporte.Text;
            string codigodeportista = txtCodigoDeportista.Text;
            edad = Convert.ToInt32(nudEdad.Text);
            conexion2 = new OleDbConnection(cadena);
            conexion2.Open();
            ComandoBD.Connection = conexion2;
            using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                    "UPDATE DEPORTISTA SET NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, DIRECCION=@DIRECCION," +
                    "TELEFONO=@TELEFONO, EDAD=@EDAD, DEPORTE=@DEPORTE WHERE [CODIGO DEPORTISTA]=@Codigo", conexion2)) //creo comando, sentencia sql
            {
                commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@NOMBRE", nombre));
                commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@APELLIDO", apellido));
                commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DIRECCION", direccion));
                commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@TELEFONO", telefono));
                commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@EDAD", edad));
                commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DEPORTE", deporte));
                commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Codigo", codigodeportista));
                commandUpdate.ExecuteNonQuery();
            }
            MessageBox.Show("Actualizado con exito!!");
            //ComandoBD.CommandText = "UPDATE DEPORTISTA SET NOMBRE= '" + nombre + "'," + "APELLIDO='" + apellido
            //+ "'," + "DIRECCION ='" + direccion + "'," + "TELEFONO='" + telefono + "'," + "EDAD=" + EdadActualizar + "," +
            //"DEPORTE='" + deporte + "'WHERE [CODIGO DEPORTISTA] =" + codigodeportista;
            //ComandoBD.ExecuteNonQuery();
        }
    }
}
