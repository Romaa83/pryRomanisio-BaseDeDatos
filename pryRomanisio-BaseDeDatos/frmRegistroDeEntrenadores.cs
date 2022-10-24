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
                conexionRegistroEntrenadores.Open();
                ComandoBD.Connection = conexionRegistroEntrenadores;

            ComandoBD.CommandText = "INSERT INTO ENTRENADORES ([CODIGO ENTRENADORES], [NOMBRE], APELLIDO, DIRECCION, PROVINCIA, DEPORTE)" +
            "VALUES (" + Convert.ToInt32(txtCodDeportista.Text) + ",'" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + txtProvincia.Text + "', '" + txtDeporte.Text + "')";
            //ComandoBD.CommandText = "INSERT INTO ENTRENADORES ([CODIGO DEPORTISTA], NOMBRE, APELLIDO, DIRECCION, PROVINCIA, DEPORTE)" +
            //"VALUES ('" + txtCodDeportista.Text + "' ,'" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + txtProvincia.Text + "', '" + txtDeporte.Text + "')";
            ComandoBD.ExecuteNonQuery();
                conexionRegistroEntrenadores.Close(); 
        }

        private void frmRegistroDeEntrenadores_Load(object sender, EventArgs e)
        {

        }
    }
}
