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
    public partial class frmConsultaDeportistas : Form
    {
        OleDbConnection ConexionBase;
        OleDbCommand QueQuieroDeLaBase;
        OleDbDataReader LectorBase;

        string BaseDatosDeporte = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";

        public frmConsultaDeportistas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarDeportista_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDeportistas.Rows.Clear();
                ConexionBase = new OleDbConnection(BaseDatosDeporte);
                ConexionBase.Open();
                QueQuieroDeLaBase = new OleDbCommand();
                QueQuieroDeLaBase.Connection = ConexionBase;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = "DEPORTISTA";

                LectorBase = QueQuieroDeLaBase.ExecuteReader();

                while (LectorBase.Read())
                {
                    dgvDeportistas.Rows.Add(LectorBase["CODIGO DEPORTISTA"].ToString(), LectorBase["NOMBRE"].ToString(),
                        LectorBase["APELLIDO"].ToString(), LectorBase["DIRECCION"].ToString(),
                        LectorBase["TELEFONO"].ToString(), LectorBase["EDAD"].ToString(), LectorBase["DEPORTE"].ToString());
                }
                dgvDeportistas.Sort(dgvDeportistas.Columns["CodigoDeportista"], ListSortDirection.Ascending); //Ordena
                ConexionBase.Close();
            }
            catch (Exception error)
            {
                SSEstado.BackColor = Color.DarkRed;
                toolStripStatusLabel1.Text = error.Message;
            }

        }
    }
}
