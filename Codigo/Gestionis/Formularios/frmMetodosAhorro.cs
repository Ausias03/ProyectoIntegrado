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
            #region Iconos flechas

            pbArrow.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow2.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow2.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow3.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow3.SizeMode = PictureBoxSizeMode.StretchImage;

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

            #endregion
            M503020Porcentajes();


            lblIngresoMesCont.Text = cuentaUsuario.TotalIngresos() + " €";
            ConfigurarComboBox(cmbCategorias, CategoriaGasto.DevuelveNombresCategorias());

            try
            {
                dgvGastosFijos.DataSource = Gasto.VisualizarDatosFijo();
                dgvGastosVariables.DataSource = Gasto.VisualizarDatosVariable();
                lblTotalValorFijo.Text = Gasto.TotalFijos() + " €";
                lblTotalGastosVariables.Text = Gasto.TotalVariable() + " €";
                lblDineroRest.Text = Gasto.DineroRestante((int)cuentaUsuario.TotalIngresos()) + " €";
                lblPorcentajeVariable.Text = PorcentajeTotalVariable().ToString("0.00") + " %";
                lblPorcentajeFijo.Text = PorcentajeTotalFijo().ToString("0.00") + " %";

                lblPorcentajeRest.Text =  PorcentajeTotalVariable() - PorcentajeTotalFijo() + " %";
            }
            catch (Exception ex) { }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }
        #region Calculo de los porcentajes totales
        private int PorcentajeTotalVariable()
        {
            double porcentajeTotal = 0;

            for (int i = 0; i < dgvGastosVariables.Rows.Count; i++)
            {
                porcentajeTotal += (double)dgvGastosVariables.Rows[i].Cells[2].Value;
            }
            return (int)porcentajeTotal;
        }
        private int PorcentajeTotalFijo()
        {
            double porcentajeTotal = 0;

            for (int i = 0; i < dgvGastosFijos.Rows.Count; i++)
            {
                porcentajeTotal += (double)dgvGastosFijos.Rows[i].Cells[2].Value;
            }
            return (int)porcentajeTotal;
        }

        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn503020_Click(object sender, EventArgs e)
        {
            pnl503020.Visible = true;
            pnlPersonalizado.Visible = false;
            btnPAgregar.Visible = false;
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            pnl503020.Visible = false;
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
            double ingresoMensual = Gasto.DineroRestante((int)cuentaUsuario.TotalIngresos());
            lblNecBasicasValor.Text = Gasto.M503020Necesidades(ingresoMensual).ToString() + " €";
            lblNecPresValor.Text = Gasto.M503020Presindibles(ingresoMensual).ToString() + " €";
            lblAhoValor.Text = Gasto.M503020Ahorro(ingresoMensual).ToString() + " €";
        }
        
    }
}
