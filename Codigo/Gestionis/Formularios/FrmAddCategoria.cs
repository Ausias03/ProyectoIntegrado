using Gestionis.Clases;
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
    public partial class frmAddCategoria : Form
    {
        public frmAddCategoria()
        {
            InitializeComponent();
        }

        #region Validaciones
        private bool ValidarDatos()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (txtNombreCat.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtNombreCat, "Debes introducir un nombre para la categoría");
            }

            return ok;
        }
        #endregion

        private void btnColorCat_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColorCat.BackColor = colorDialog1.Color;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Revisa los datos introducidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CategoriaGasto.ExisteNombre(txtNombreCat.Text))
            {
                MessageBox.Show("Ya existe una categoría con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CategoriaGasto.ExisteColor(btnColorCat.BackColor.ToArgb()))
            {
                MessageBox.Show("Ya existe una categoría con ese color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoriaGasto cg1 = new CategoriaGasto(
                txtNombreCat.Text,
                btnColorCat.BackColor.ToArgb()
                );

            cg1.Add();

            this.Close();
        }
    }
}
