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
    public partial class frmAnyadirIngreso : Form
    {
        private int numCuenta;

        public int NumCuenta { set { numCuenta = value; } }

        public frmAnyadirIngreso()
        {
            InitializeComponent();
        }

        private void frmAnyadirIngreso_Load(object sender, EventArgs e)
        {
            CargaCategoriasCBO();
        }

        #region Validaciones
        private bool ValidaDatos()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (txtNombreIngreso.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtNombreIngreso, "Introduce un nombre para el gasto");
            }

            if (nudCantidad.Value < 0 || nudCantidad.Value > 100000000)
            {
                ok = false;
                errorProvider1.SetError(nudCantidad, "Introduce una cantidad válida");
            }

            if (rdbExtra.Checked)
            {
                if (cboCategoria.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(cboCategoria, "Elige una categoría");
                }
            }

            return ok;
        }
        #endregion

        private void rdbExtra_CheckedChanged(object sender, EventArgs e)
        {
            cboCategoria.Enabled = rdbExtra.Checked;
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddIngreso_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
            {
                MessageBox.Show("Comprueba los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ingreso i1 = new Ingreso(
                numCuenta,
                txtNombreIngreso.Text,
                (float)nudCantidad.Value,
                rdbSalario.Checked ? "Salario" : "Fijo",
                rdbSalario.Checked ? null : CategoriaIngreso.DevuelveIDCategoria(cboCategoria.Text),
                txtComentarios.Text == String.Empty ? null : txtComentarios.Text
            );

            i1.Add();

            this.Close();
        }

        #region Métodos de Implementaión
        private void CargaCategoriasCBO()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = CategoriaIngreso.DevuelveNombresCategorias();
            cboCategoria.DataSource = bs;
        }
        #endregion
    }
}
