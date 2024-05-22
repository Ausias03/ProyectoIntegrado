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
using Gestionis.Clases;
using Gestionis.Formularios;
using Org.BouncyCastle.Crypto.Parameters;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace Gestionis
{
    public partial class frmNotas : FrmBarraPrincipal
    {
        public frmNotas()
        {
            InitializeComponent();
            ModificarBotones();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
            cmbFiltrarPor.DataSource = Notas.CargaFiltros();
            cmbFiltrarPor.DropDownStyle = ComboBoxStyle.DropDownList;

            barraSecundaria1.Load();
            barraLateral1.Load();
            #region Carga de datos en los dgv y lbl 

            dgvNotas.DataSource = Notas.RecargarTabla();
            dgvNotasDia.DataSource = Notas.NotasDia();
            lblNotasTotalesCount.Text = Notas.NotasTotales().ToString();
            lblNDTotales.Text = Notas.NotasTotalesDia().ToString();

            #endregion
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            barraLateral1.AplicarIdiomas();
            cmbFiltrarPor.DataSource = Notas.CargaFiltros();
        }

        private void btnNuevaNota_Click(object sender, EventArgs e)
        {
            frmAddNota addNota = new frmAddNota();
            addNota.ShowDialog();
            Notas.RecargarTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRestaurarFiltro_Click(object sender, EventArgs e)
        {
            dgvNotas.DataSource = Notas.RecargarTabla();
            txtFiltro.Text = "";
        }

        private void frmNotas_Activated(object sender, EventArgs e)
        {
            dgvNotas.DataSource = Notas.RecargarTabla();
        }

        private void cmbFiltrarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarPor.SelectedIndex == 1 || cmbFiltrarPor.SelectedIndex == 3) { txtFiltro.Visible = true; } else { txtFiltro.Visible = false; }
            if (cmbFiltrarPor.SelectedIndex == 4) { btnFiltroColor.Visible = true; } else { btnFiltroColor.Visible = false; }
            if (cmbFiltrarPor.SelectedIndex == 0) { dtpFiltrarFecha.Visible = true; } else { dtpFiltrarFecha.Visible = false; }
            if (cmbFiltrarPor.SelectedIndex == 2) { ckbAlarmaFiltro.Visible = true; } else { ckbAlarmaFiltro.Visible = false; }
            if (cmbFiltrarPor.SelectedIndex == 5) { ckbDeudaFiltro.Visible = true; } else { ckbDeudaFiltro.Visible = false; }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            bool? deuda = ckbDeudaFiltro.Checked;

            dgvNotas.DataSource = Notas.BuscarPorFiltro(cmbFiltrarPor.SelectedIndex, txtFiltro.Text, txtFiltro.Text, ckbAlarmaFiltro.Checked,
                btnFiltroColor.BackColor.ToArgb(), dtpFiltrarFecha.Value.ToString("yyyy-MM-dd"), deuda);
        }

        #region Colores aplicados en el dgv en la columna "Calendario"

        private void dgvNotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int colorValue;
            if (int.TryParse(dgvNotas.Rows[e.RowIndex].Cells["Color"].Value?.ToString(), out colorValue))
            {
                dgvNotas.Rows[e.RowIndex].Cells["Color"].Style.BackColor = Color.FromArgb(colorValue);
            }
            else
            {
                dgvNotas.Rows[e.RowIndex].Cells["Color"].Style.BackColor = Color.White;
            }
        }

        private void btnFiltroColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.btnFiltroColor.BackColor = colorDialog1.Color;
            }
        }
        #endregion

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNotas.Rows.Count > 0)
            {
                string tituloeNota = dgvNotas.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Notas.BorrarNota(tituloeNota);
                    dgvNotas.Rows.RemoveAt(e.RowIndex);
                    Notas.EliminarNotaCalendario(tituloeNota);
                }
            }
        }

        private void AplicarIdioma()
        {
            lblFiltrarPor.Text = Resources.Idiomas.StringRecursosNotas.lblFiltrarPor;
            lblNotasDia.Text = Resources.Idiomas.StringRecursosNotas.lblNotasDia;
            lblNotasTotales.Text = Resources.Idiomas.StringRecursosNotas.lblNotasTotales;
            lblNotasTotalesDia.Text = Resources.Idiomas.StringRecursosNotas.lblNotasTotalesDia;
            btnFiltrar.Text = Resources.Idiomas.StringRecursosNotas.btnFiltrar;
            btnNuevaNota.Text = Resources.Idiomas.StringRecursosNotas.btnNuevaNota;
            btnRestaurarFiltro.Text = Resources.Idiomas.StringRecursosNotas.btnRestaurarFiltro;
            btnSalir.Text = Resources.Idiomas.StringRecursosNotas.btnSalir;
        }
    }
}
