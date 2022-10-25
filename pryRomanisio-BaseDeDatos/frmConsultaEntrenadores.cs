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
    public partial class frmConsultaEntrenadores : Form
    {
        OleDbConnection ConexionBase;
        OleDbCommand QueQuieroDeLaBase;
        OleDbDataReader LectorBase;

        string BaseDatosDeporte = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + "DEPORTE.accdb";

        public frmConsultaEntrenadores()
        {
            InitializeComponent();
        }

        private void btnConsultarEntrenadores_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEntrenadores.Rows.Clear();
                ConexionBase = new OleDbConnection(BaseDatosDeporte);
                ConexionBase.Open();
                QueQuieroDeLaBase = new OleDbCommand();
                QueQuieroDeLaBase.Connection = ConexionBase;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = "ENTRENADORES";

                LectorBase = QueQuieroDeLaBase.ExecuteReader();
                while (LectorBase.Read())
                {
                    dgvEntrenadores.Rows.Add(LectorBase["CODIGO ENTRENADORES"].ToString(), LectorBase["NOMBRE"].ToString(),
                        LectorBase["APELLIDO"].ToString(), LectorBase["DIRECCION"].ToString(),
                        LectorBase["PROVINCIA"].ToString(),LectorBase["DEPORTE"].ToString());
                }
                dgvEntrenadores.Sort(dgvEntrenadores.Columns["CodigoDeportista"], ListSortDirection.Ascending); //Ordena la grilla
                ConexionBase.Close();
            }
            catch (Exception error)
            {
                SSEstado.BackColor = Color.DarkRed;
                toolStripStatusLabel1.Text = error.Message;
            }
        }

        private void frmConsultaEntrenadores_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionBase = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
                ConexionBase.Open();
                SSEstado.BackColor = Color.Green;
                toolStripStatusLabel1.Text = "Conectado a la base de datos" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                toolStripStatusLabel2.Text = mensajito.Message;
                SSEstado.BackColor = Color.DarkRed;

            }
            ConexionBase.Close();
        }
    }
}
