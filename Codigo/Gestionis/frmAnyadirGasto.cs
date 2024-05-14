using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionis
{
    public partial class frmAnyadirGasto : Form
    {
        public frmAnyadirGasto()
        {
            InitializeComponent();
        }

        #region Validaciones
        private bool ValidaDatos()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (txtNombreGasto.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtNombreGasto, "Introduce un nombre para el gasto");
            }

            if (nudCantidad.Value < 0 || nudCantidad.Value > 100000000)
            {
                ok = false;
                errorProvider1.SetError(nudCantidad, "Introduce una cantidad válida");
            }

            if (cboCategoria.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboCategoria, "Elige una categoría");
            }

            return ok;
        }
        #endregion

        private void lklAddCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddCategoria frmAC = new frmAddCategoria();
            frmAC.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddGasto_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
            {
                MessageBox.Show("Comprueba los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }
    }
}
