using Gestionis.Clases;
using System.Globalization;

namespace Gestionis.Formularios
{
    public partial class FrmModifNotif : Form
    {
        public FrmModifNotif()
        {
            InitializeComponent();
        }

        private void FrmModifNotif_Load(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
            try
            {
                CargarCBOCategorias();
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

        private void cboCategorias_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal? limite = LimitesNotif.GetLimite(Sesion.Instance.NumCuenta, CategoriaGasto.DevuelveIDCategoria(cboCategorias.Text));
                nudLimite.Value = limite == null ? 0 : limite.Value;
                btnModificar.Text = limite == null ? Resources.Idiomas.StringRecursosModNotif.btnAgregar : Resources.Idiomas.StringRecursosModNotif.btnModificar;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal? limite = LimitesNotif.GetLimite(Sesion.Instance.NumCuenta, CategoriaGasto.DevuelveIDCategoria(cboCategorias.Text));

                if (limite == null)
                {
                    LimitesNotif lim = new LimitesNotif(
                        Sesion.Instance.NumCuenta,
                        CategoriaGasto.DevuelveIDCategoria(cboCategorias.Text),
                        nudLimite.Value
                    );
                    lim.Add();
                }
                else
                {
                    LimitesNotif.EditarLimite(Sesion.Instance.NumCuenta, CategoriaGasto.DevuelveIDCategoria(cboCategorias.Text), limite);
                }

                SistemaNiveles.IncrementarExperiencia(Sesion.Instance.ApodoUsuario, 10);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Métodos de Implementación
        private void CargarCBOCategorias()
        {
            cboCategorias.DataSource = CategoriaGasto.DevuelveNombresCategorias();
        }
        #endregion

        #region Idiomas
        private void AplicarIdioma()
        {
            lblCategoria.Text = Resources.Idiomas.StringRecursosModNotif.lblCategoria;
            lblLimiteCategoria.Text = Resources.Idiomas.StringRecursosModNotif.lblLimiteCategoria;
            lblTitulo.Text = Resources.Idiomas.StringRecursosModNotif.lblTitulo;
            btnVolver.Text = Resources.Idiomas.StringRecursosModNotif.btnVolver;
        }
        #endregion
    }
}
