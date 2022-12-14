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
    public partial class frmActualizarEntrenadores : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();

        public frmActualizarEntrenadores()
        {
            InitializeComponent();
        }

        private void frmActualizarEntrenadores_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigoDeportista.Text != "")
            {
                string CodDeportista = txtCodigoDeportista.Text;
                Conexion.Open();
                ComandoBD.Connection = Conexion;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "ENTRENADORES";
                OleDbDataReader lector = ComandoBD.ExecuteReader();

                while (lector.Read() && lector.GetString(0) != CodDeportista)
                {
                }
                if (lector.GetString(0) == CodDeportista)
                {
                    txtNombre.Text = lector.GetString(1);
                    txtApellido.Text = lector.GetString(2);
                    txtDireccion.Text = lector.GetString(3);
                    txtProvincia.Text = lector.GetString(4);
                    cboDeporte.Text = lector.GetString(5);
                }
                else
                {
                    MessageBox.Show("Ese codigo de deportista no existe");
                }
                btnActualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese un codigo deportista");
            }
            Conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCodigoDeportista.Text != "")
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string direccion = txtDireccion.Text;
                string provincia = txtProvincia.Text;
                string deporte = cboDeporte.Text;
                string codigodeportista = txtCodigoDeportista.Text;

                Conexion.Open();
                ComandoBD.Connection = Conexion;

                using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                        "UPDATE ENTRENADORES SET NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, DIRECCION=@DIRECCION," +
                        "PROVINCIA=@PROVINCIA,DEPORTE=@DEPORTE WHERE [CODIGO ENTRENADORES]=@Codigo", Conexion)) //creo comando, sentencia sql
                {
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@NOMBRE", nombre));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@APELLIDO", apellido));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DIRECCION", direccion));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@PROVINCIA", provincia));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DEPORTE", deporte));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Codigo", codigodeportista));
                    commandUpdate.ExecuteNonQuery();
                }
                MessageBox.Show("Actualizado con exito!!");
                Conexion.Close();
            }
            else
            {
                MessageBox.Show("Ingrese un codigo valido");
            }
        }
    }
}
