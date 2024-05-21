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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestionis
{
    public partial class frmAnyadirGasto : Form
    {
        private readonly int numCuenta;

        public frmAnyadirGasto()
        {
            InitializeComponent();
            numCuenta = Sesion.Instance.NumCuenta;
        }

        private void frmAnyadirGasto_Load(object sender, EventArgs e)
        {
            CargaCategoriasCBO();            
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

            Gasto g1 = new Gasto(
                this.numCuenta,
                txtNombreGasto.Text,
                (float)nudCantidad.Value,
                CategoriaGasto.DevuelveIDCategoria(cboCategoria.Text),
                rdbFijo.Checked ? "Fijo" : "Variable",
                txtComentarios.Text == String.Empty ? null : txtComentarios.Text
            );

            g1.Add();

            Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario).GetCuenta().AddNotificacion(g1.GetNumericCategoria());

            this.Close();
        }

        private void frmAnyadirGasto_Activated(object sender, EventArgs e)
        {
            CargaCategoriasCBO();
        }

        #region Métodos de Implementaión
        private void CargaCategoriasCBO()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = CategoriaGasto.DevuelveNombresCategorias();
            cboCategoria.DataSource = bs;
        }
        #endregion
    }
}
