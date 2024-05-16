using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gestionis
{
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            lblFecha.Hide();
            dtpBuscaFecha.Value = DateTime.Now;
            txtBuscar.Text = "";
        }

        private void picBuscaFecha_Click(object sender, EventArgs e)
        {
            lblFecha.Show();
            lblFecha.Text = dtpBuscaFecha.Value.ToString("D");
            dtpBuscaFecha.Value = DateTime.Now;
            txtBuscar.Text = "";
        }
    }
}