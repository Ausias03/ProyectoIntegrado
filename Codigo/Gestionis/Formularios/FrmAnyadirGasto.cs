using Gestionis.Clases;
using System.Globalization;

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
            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
            try
            {
                CargaCategoriasCBO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
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

            try
            {
                Gasto g1 = new Gasto(
                    this.numCuenta,
                    txtNombreGasto.Text,
                    (float)nudCantidad.Value,
                    CategoriaGasto.DevuelveIDCategoria(cboCategoria.Text),
                    rdbFijo.Checked ? "Fijo" : "Variable",
                    txtComentarios.Text == String.Empty ? null : txtComentarios.Text
                );

                g1.Add();

                SistemaNiveles.IncrementarExperiencia(Sesion.Instance.ApodoUsuario, 15);

                Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario).GetCuenta().AddNotificacion(g1.GetNumericCategoria());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
                this.Close();
            }
        }

        private void frmAnyadirGasto_Activated(object sender, EventArgs e)
        {
            try
            {
                CargaCategoriasCBO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void AplicarIdioma()
        {
            lblNombreGasto.Text = Resources.Idiomas.StringRecursosAddGasto.lblNombreGasto;
            lblCantidad.Text = Resources.Idiomas.StringRecursosAddGasto.lblCantidad;
            lblCategoria.Text = Resources.Idiomas.StringRecursosAddGasto.lblCategoria;
            lklAddCat.Text = Resources.Idiomas.StringRecursosAddGasto.lklAddCat;
            lblTipo.Text = Resources.Idiomas.StringRecursosAddGasto.lblTipo;
            rdbFijo.Text = Resources.Idiomas.StringRecursosAddGasto.rdbFijo;
            rdbVariable.Text = Resources.Idiomas.StringRecursosAddGasto.rdbVariable;
            lblComentarios.Text = Resources.Idiomas.StringRecursosAddGasto.lblComentarios;
            btnVolver.Text = Resources.Idiomas.StringRecursosAddGasto.btnVolver;
            btnAddGasto.Text = Resources.Idiomas.StringRecursosAddGasto.btnAddGasto;
            this.Text = Resources.Idiomas.StringRecursosAddGasto.frmAnyadirGasto;
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
