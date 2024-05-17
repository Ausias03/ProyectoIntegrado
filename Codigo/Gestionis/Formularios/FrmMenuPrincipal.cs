using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionis.Herramientas;
using Gestionis.Clases;

namespace Gestionis
{
    public partial class FrmMenuPrincipal : FrmBarraPrincipal
    {
        private string apodoUsuario;

        public string ApodoUsuario { set { apodoUsuario = value; } }

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            #region Botones
            btnIngreso.FlatStyle = FlatStyle.Flat;
            btnIngreso.FlatAppearance.BorderColor = Color.Black;
            btnIngreso.FlatAppearance.BorderSize = 2;

            btnGasto.FlatStyle = FlatStyle.Flat;
            btnGasto.FlatAppearance.BorderColor = Color.Black;
            btnGasto.FlatAppearance.BorderSize = 2;

            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 2;

            #endregion

            #region Labels
            lblIngresosValor.Text = "0€";
            lblGastosValor.Text = "0€";
            lblTotalValor.Text = "0€";

            lblMes.Text = DateTime.Now.ToString("MMMM");
            lblNotasValor.Text = "";
            #endregion
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            frmAnyadirGasto fAG = new frmAnyadirGasto();
            fAG.NumCuenta = Cuenta.IDCuentaUsuario(apodoUsuario);
            fAG.ShowDialog();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            frmAnyadirIngreso fAI = new frmAnyadirIngreso();
            fAI.NumCuenta = Cuenta.IDCuentaUsuario(apodoUsuario);
            fAI.ShowDialog();
        }

        private void pbHamburger_Click(object sender, EventArgs e)
        {
            BarraLateral.ColapsarExpandir(sender, e);
        }
    }
}
