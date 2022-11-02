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
    public partial class frmMenu : Form
    {
        OleDbConnection conexionBase;

        public string RutaBaseDatos = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                conexionBase = new OleDbConnection(RutaBaseDatos);
                conexionBase.Open();
                statusStrip1.BackColor = Color.Green;
                toolStripStatusLabel1.Text = "Conectado a la base de datos" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                toolStripStatusLabel1.Text = mensajito.Message;
                statusStrip1.BackColor= Color.DarkRed;
                
            }
            conexionBase.Close();
        }

        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDeportistas frmConsultaDeportistas = new frmConsultaDeportistas();
            frmConsultaDeportistas.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenadores frmConsultaEntrenadores = new frmConsultaEntrenadores();
            frmConsultaEntrenadores.ShowDialog();
        }

        private void deportistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroDeEntrenadores frmRegistroDeEntrenadores = new frmRegistroDeEntrenadores();
            frmRegistroDeEntrenadores.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroDeportistas frmRegistroDeportistas = new frmRegistroDeportistas();
            frmRegistroDeportistas.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmActualizarEntrenadores frmActualizarEntrenadores = new frmActualizarEntrenadores();
            frmActualizarEntrenadores.ShowDialog();
        }

        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarDeportista frmActualizarDeportista = new frmActualizarDeportista();
            frmActualizarDeportista.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmBorrarEntrenadores frmBorrarEntrenadores = new frmBorrarEntrenadores();
            frmBorrarEntrenadores.ShowDialog();
        }

        private void deportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBorrarDeportistas frmBorrarDeportistas = new frmBorrarDeportistas();
            frmBorrarDeportistas.ShowDialog();
        }
    }
}
