using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionis.Clases;
using MySqlX.XDevAPI;

namespace Gestionis
{
    public partial class frmMetodosAhorro : FrmBarraPrincipal
    {
        private readonly Usuario usuario;
        private readonly Cuenta cuentaUsuario;

        public frmMetodosAhorro()
        {
            InitializeComponent();
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            cuentaUsuario = usuario.GetCuenta();
        }

        private void MetodosAhorro_Load(object sender, EventArgs e)
        {
            #region Iconos flechas / puntos

            pbDot.Image = Properties.Resources.check.ToBitmap();
            pbDot.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow2.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow2.SizeMode = PictureBoxSizeMode.StretchImage;

            pbDot2.Image = Properties.Resources.check.ToBitmap();
            pbDot2.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow4.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow4.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow5.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow5.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow6.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow6.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow7.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow7.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow8.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow8.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow9.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow9.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow10.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow10.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow11.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow11.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow12.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow12.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow13.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow13.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow14.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow14.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow15.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow15.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow16.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow16.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow17.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow17.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion
            M503020Porcentajes();

            lblIngresoMesCont.Text = cuentaUsuario.TotalIngresos() + " €";
            ConfigurarComboBox(cmbCategorias, CategoriaGasto.DevuelveNombresCategorias());

            try
            {
                dgvGastosFijos.DataSource = Gasto.VisualizarDatosFijo();
                dgvGastosVariables.DataSource = Gasto.VisualizarDatosVariable();

                lblTotalGastosVariables.Text = Gasto.TotalVariable() + " €";
                lblTotalValorFijo.Text = Gasto.TotalFijos() + " €";
                lblDineroRest.Text = Gasto.DineroRestante((int)cuentaUsuario.TotalIngresos()) + " €";


                lblPorcentajeVariable.Text = Gasto.PorcentajeTotalVariable().ToString("0") + " %";
                lblPorcentajeFijo.Text = Gasto.PorcentajeTotalFijo().ToString("0") + " %";
                lblPorcentajeRest.Text = Gasto.PorcentajeRestante((int)cuentaUsuario.TotalIngresos()).Value.ToString("0") + " %";

            }
            catch (Exception) { }
            finally
            {
                ConexionDB.CerrarConexion();
            }
            barraLateral2.Load();
            barraSecundaria1.Load();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn503020_Click(object sender, EventArgs e)
        {
            pnl503020.Visible = true;
            pnlHarvEker.Visible = false;
            pnlPersonalizado.Visible = false;
            btnPAgregar.Visible = false;
        }

        private void btnHarvEker_Click(object sender, EventArgs e)
        {
            pnl503020.Visible = false;
            pnlHarvEker.Visible = true;
            pnlPersonalizado.Visible = false;
            btnPAgregar.Visible = false;
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            pnl503020.Visible = false;
            pnlHarvEker.Visible = false;
            pnlPersonalizado.Visible = true;
            btnPAgregar.Visible = true;
        }

        private void ConfigurarComboBox(ComboBox comboBox, List<String> dataSource)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataSource;
            comboBox.DataSource = bs;
        }

        private void btnPAgregar_Click(object sender, EventArgs e)
        {

        }

        private void M503020Porcentajes()
        {
            double? ingresoMensual = (int?)cuentaUsuario.TotalIngresos();
            lblNecBasicasValor.Text = Gasto.M503020Necesidades(ingresoMensual) + " €";
            lblNecPresValor.Text = Gasto.M503020Presindibles(ingresoMensual) + " €";
            lblAhoValor.Text = Gasto.M503020Ahorro(ingresoMensual).ToString() + " €";

            lblGMNecValor.Text = Gasto.TotalFijos() + " €";
            lblGPresValor.Text = Gasto.TotalVariable() + " €";
            lblAhorroDinValor.Text = Gasto.DineroRestante((double)ingresoMensual) + " €";

            lblGMNecPorDin.Text = Gasto.PorcentajeTotalFijo().ToString("0") + " %";
            lblGPPorDin.Text = Gasto.PorcentajeTotalVariable().ToString("0") + " %";

            lblAhorroPorDin.Text = Gasto.PorcentajeRestante((double)ingresoMensual).Value.ToString("0") + " %";
        }
    }
}
