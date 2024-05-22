using Gestionis.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionis
{
    public partial class frmAnyadirIngreso : Form
    {
        private readonly int numCuenta;

        public frmAnyadirIngreso()
        {
            InitializeComponent();
            numCuenta = Sesion.Instance.NumCuenta;
        }

        private void frmAnyadirIngreso_Load(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
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
                if (Sesion.Instance.Espanyol) errorProvider1.SetError(txtNombreIngreso, "Introduce un nombre para el gasto");
                else errorProvider1.SetError(txtNombreIngreso, "Insert a name for the expense");
            }

            if (nudCantidad.Value < 0 || nudCantidad.Value > 100000000)
            {
                ok = false;
                if (Sesion.Instance.Espanyol) errorProvider1.SetError(nudCantidad, "Introduce una cantidad válida");
                else errorProvider1.SetError(nudCantidad, "Insert a valid amount");
            }

            if (rdbExtra.Checked)
            {
                if (cboCategoria.Text == "")
                {
                    ok = false;
                    if (Sesion.Instance.Espanyol) errorProvider1.SetError(cboCategoria, "Elige una categoría");
                    else errorProvider1.SetError(cboCategoria, "Choose a category");
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
                rdbSalario.Checked ? "Salario" : "Extra",
                rdbSalario.Checked ? null : CategoriaIngreso.DevuelveIDCategoria(cboCategoria.Text),
                txtComentarios.Text == String.Empty ? null : txtComentarios.Text
            );

            i1.Add();

            this.Close();
        }

        private void AplicarIdioma()
        {
            btnAddIngreso.Text = Resources.Idiomas.StringRecursosAddIngreso.btnAddIngreso;
            btnVolver.Text = Resources.Idiomas.StringRecursosAddIngreso.btnVolver;
            lblComentarios.Text = Resources.Idiomas.StringRecursosAddIngreso.lblComentarios;
            lblTipo.Text = Resources.Idiomas.StringRecursosAddIngreso.lblTipo;
            lblCategoria.Text = Resources.Idiomas.StringRecursosAddIngreso.lblCategoria;
            lblCantidad.Text = Resources.Idiomas.StringRecursosAddIngreso.lblCantidad;
            lblNombreIngreso.Text = Resources.Idiomas.StringRecursosAddIngreso.lblNombreIngreso;
            rdbSalario.Text = Resources.Idiomas.StringRecursosAddIngreso.rdbSalario;
            rdbExtra.Text = Resources.Idiomas.StringRecursosAddIngreso.rdbExtra;
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
