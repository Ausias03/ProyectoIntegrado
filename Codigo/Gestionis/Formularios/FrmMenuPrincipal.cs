using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionis.Herramientas;
using Gestionis.Clases;

namespace Gestionis
{
    public partial class FrmMenuPrincipal : FrmBarraPrincipal
    {
        private readonly Usuario usuario;
        private readonly Cuenta cuentaUsuario;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            cuentaUsuario = usuario.GetCuenta();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            #region Botones
            btnIngreso.FlatStyle = FlatStyle.Flat;
            btnIngreso.FlatAppearance.BorderColor = Color.Black;
            btnIngreso.FlatAppearance.BorderSize = 2;

            btnGasto.FlatStyle = FlatStyle.Flat;
            btnGasto.FlatAppearance.BorderColor = Color.Black;
            btnGasto.FlatAppearance.BorderSize = 2;

            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 2;

            #endregion

            barraSecundaria1.Load();
            barraLateral1.Load();

            #region Labels
            RecargaLabelTotales();
            lblMes.Text = DateTime.Now.ToString("MMMM");
            lblNotasValor.Text = "";
            #endregion            
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            RecargaDGVGastos(cuentaUsuario.DevuelveGastos());
            RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos());
            RecargaLabelTotales();

            #region Configurar ComboBoxes
            ConfigurarComboBox(cmbTipoGasto, Gasto.TiposGasto);
            ConfigurarComboBox(cmbCategoriaGasto, CategoriaGasto.DevuelveNombresCategorias());
            ConfigurarComboBox(cmbTipoIngreso, Ingreso.TiposIngreso);

            List<String> nombresCategorias = CategoriaIngreso.DevuelveNombresCategorias();
            // Añado un elemento a la lista, ya que puede haber gastos sin categoría asignada
            nombresCategorias.Add(String.Empty);
            ConfigurarComboBox(cmbCategoriaIngreso, nombresCategorias);
            #endregion
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            frmAnyadirGasto fAG = new frmAnyadirGasto();
            fAG.ShowDialog();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            frmAnyadirIngreso fAI = new frmAnyadirIngreso();
            fAI.ShowDialog();
        }

        private void pbHamburger_Click(object sender, EventArgs e)
        {
            BarraLateral.ColapsarExpandir();
        }

        private void btnFiltrarGastos_Click(object sender, EventArgs e)
        {
            RecargaDGVGastos(cuentaUsuario.DevuelveGastos(txtNombreGasto.Text, cmbTipoGasto.Text, nudDineroGasto.Value, cmbCategoriaGasto.Text));
        }

        private void btnRestablecerGastos_Click(object sender, EventArgs e)
        {
            RecargaDGVGastos(cuentaUsuario.DevuelveGastos());
            RestableceControlesGasto();
        }

        private void btnFiltrarIngresos_Click(object sender, EventArgs e)
        {
            RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos(txtNombreIngreso.Text, cmbTipoIngreso.Text, nudDineroIngreso.Value, cmbCategoriaIngreso.Text));
        }

        private void btnRestablecerIngresos_Click(object sender, EventArgs e)
        {
            RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos());
            RestableceControlesIngreso();
        }

        private void ConfigurarComboBox(ComboBox comboBox, List<String> dataSource)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataSource;
            comboBox.DataSource = bs;
        }

        private void RecargaDGVGastos(List<Gasto> gastos)
        {
            dgvGastos.DataSource = gastos;
        }
        private void RecargaDGVIngresos(List<Ingreso> ingresos)
        {
            dgvIngresos.DataSource = ingresos;
        }
        private void RestableceControlesGasto()
        {
            txtNombreGasto.Text = String.Empty;
            cmbTipoGasto.SelectedIndex = 0;
            nudDineroGasto.Value = 0;
            cmbCategoriaGasto.SelectedIndex = 0;
        }
        private void RestableceControlesIngreso()
        {
            txtNombreIngreso.Text = String.Empty;
            cmbTipoIngreso.SelectedIndex = 0;
            nudDineroIngreso.Value = 0;
            cmbCategoriaIngreso.SelectedIndex = 0;
        }

        private void RecargaLabelTotales()
        {
            lblIngresosValor.Text = cuentaUsuario.TotalIngresos().ToString() + " €";
            lblGastosValor.Text = cuentaUsuario.TotalGastos().ToString() + " €";
            lblTotalValor.Text = cuentaUsuario.DineroTotal().ToString() + " €";
        }

        private void dgvGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1))
            {
                DialogResult eliminar = MessageBox.Show("Quieres eliminar el gasto seleccionado?", "Eliminar Gasto"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (eliminar == DialogResult.Yes)
                {
                    try
                    {
                        int idGasto = (int)dgvGastos.Rows[e.RowIndex].Cells[0].Value;
                        int idCategoria = CategoriaGasto.DevuelveIDCategoria(dgvGastos.Rows[e.RowIndex].Cells[3].Value?.ToString());
                        cuentaUsuario.EliminaGasto(idGasto);
                        cuentaUsuario.EliminaNotificacion(idCategoria);
                        RecargaDGVGastos(cuentaUsuario.DevuelveGastos());
                        RecargaLabelTotales();

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
            }
        }

        private void dgvIngresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1))
            {
                DialogResult eliminar = MessageBox.Show("Quieres eliminar el Ingreso seleccionado?", "Eliminar Ingreso"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (eliminar == DialogResult.Yes)
                {
                    try
                    {
                        int idIngreso = (int)dgvIngresos.Rows[e.RowIndex].Cells[0].Value;
                        cuentaUsuario.EliminaIngreso(idIngreso);
                        RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos());
                        RecargaLabelTotales();
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
            }
        }
    }
}
