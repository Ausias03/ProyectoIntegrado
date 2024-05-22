using Gestionis.Clases;
using Gestionis.Formularios;
using Gestionis.Herramientas;
using System.Globalization;

namespace Gestionis
{
    public partial class FrmGestorDeudas : FrmBarraPrincipal
    {

        public FrmGestorDeudas()
        {
            InitializeComponent();
            ModificarBotones();
        }

        private void FrmGestorDeudas_Load(object sender, EventArgs e)
        {
            #region Botones
            btnAnyadirDeuda.FlatStyle = FlatStyle.Flat;
            btnAnyadirDeuda.FlatAppearance.BorderColor = Color.Black;
            btnAnyadirDeuda.FlatAppearance.BorderSize = 2;

            btnEliminarDeuda.FlatStyle = FlatStyle.Flat;
            btnEliminarDeuda.FlatAppearance.BorderColor = Color.Black;
            btnEliminarDeuda.FlatAppearance.BorderSize = 2;

            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatAppearance.BorderSize = 2;

            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.FlatAppearance.BorderColor = Color.Black;
            btnRestaurar.FlatAppearance.BorderSize = 2;
            #endregion

            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();

            cmbCategoria.Items.AddRange(Deuda.Filtros());
            cmbCategoria.SelectedIndex = 0;

            SetGrafico();
            vpbDebo.ForeColor = Color.IndianRed;
            Titulo();

            //lblSaldoValor.Text = 
            lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
            ProximaDeuda();

            dgvGastosIngresos.DataSource = Deuda.RecargarTabla();

            barraSecundaria.Load();
            barraLateral1.Load();
        }

        private void ModificarBotones()
        {
            barraSecundaria.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            barraLateral1.AplicarIdiomas();
        }

        private void Titulo()
        {
            if (cmbCategoria.SelectedIndex == 0)
            {
                lblTitulo.Enabled = true;
                txtTitulo.Enabled = true;
            }
            else
            {
                txtTitulo.Clear();
                lblTitulo.Enabled = false;
                txtTitulo.Enabled = false;
            }
        }
        private void ProximaDeuda()
        {
            Deuda deuda = new Deuda();
            deuda.GetProximaDeuda(deuda);

            if (deuda.Titulo != null)
            {
                lblProximaDeudaValor.Text = deuda.Titulo.ToString();
                lblFechaLimiteValor.Text = deuda.FechaVencimiento.ToShortDateString();
                if (deuda.Debo) lblTipoValor.Text = "Debo"; else lblTipoValor.Text = "Me deben";
            }
            else
            {
                lblProximaDeudaValor.Text = string.Empty;
                lblFechaLimiteValor.Text = string.Empty;
                lblTipoValor.Text = string.Empty;
            }
            SetGrafico();
        }

        private void btnAnyadirDeuda_Click(object sender, EventArgs e)
        {
            FrmAnyadirDeuda frmAnyadirDeuda = new FrmAnyadirDeuda();
            frmAnyadirDeuda.ShowDialog();
            lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
            ProximaDeuda();
            dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
        }

        private void btnEliminarDeuda_Click(object sender, EventArgs e)
        {
            FrmEliminarDeuda frmEliminarDeuda = new FrmEliminarDeuda();
            frmEliminarDeuda.ShowDialog();
            lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
            ProximaDeuda();
            dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvGastosIngresos.DataSource = Deuda.CargarFiltro(cmbCategoria.Text, chkDebo.Checked, txtTitulo.Text);
            Titulo();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Titulo();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            dgvGastosIngresos.DataSource = Deuda.RecargarTabla();
        }

        private void chkDebo_CheckedChanged(object sender, EventArgs e)
        {
            dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
        }

        private void SetGrafico()
        {
            double debo = Deuda.CalcularTotalDeuda(true), meDeben = Deuda.CalcularTotalDeuda(false);

            int valorMax = Utilidades.ProgramarGrafico(debo, meDeben);
            vpbDebo.Maximum = valorMax;
            vpbMeDeben.Maximum = valorMax;

            vpbDebo.Value = (int)debo;
            vpbMeDeben.Value = (int)meDeben;
        }

        private void AplicarIdioma()
        {
            lblDeboBarra.Text = Resources.Idiomas.StringRecursosGestor.lblDeboBarra;
            lblDeudasTotales.Text = Resources.Idiomas.StringRecursosGestor.lblDeudasTotales;
            lblProximaDeuda.Text = Resources.Idiomas.StringRecursosGestor.lblProximaDeuda;
            lblFechaLimite.Text = Resources.Idiomas.StringRecursosGestor.lblFechaLimite;
            lblMeDeben.Text = Resources.Idiomas.StringRecursosGestor.lblMeDeben;
            lblProximaDeuda.Text = Resources.Idiomas.StringRecursosGestor.lblProximaDeuda;
            lblResumen.Text = Resources.Idiomas.StringRecursosGestor.lblResumen;
            lblSaldo.Text = Resources.Idiomas.StringRecursosGestor.lblSaldo;
            lblTipo.Text = Resources.Idiomas.StringRecursosGestor.lblTipo;
            lblTitulo.Text = Resources.Idiomas.StringRecursosGestor.lblTitulo;
            btnAnyadirDeuda.Text = Resources.Idiomas.StringRecursosGestor.btnAnyadirDeuda;
            btnBuscar.Text = Resources.Idiomas.StringRecursosGestor.btnBuscar;
            btnEliminarDeuda.Text = Resources.Idiomas.StringRecursosGestor.btnEliminarDeuda;
            btnRestaurar.Text = Resources.Idiomas.StringRecursosGestor.btnRestaurar;
            chkDebo.Text = Resources.Idiomas.StringRecursosGestor.chkDebo;
        }
    }
}
