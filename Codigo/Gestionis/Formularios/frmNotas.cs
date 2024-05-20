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
using Gestionis.Formularios;
using Org.BouncyCastle.Crypto.Parameters;

namespace Gestionis
{
    public partial class frmNotas : FrmBarraPrincipal
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            cmbFiltrarPor.Items.AddRange(Notas.CargaFiltros());
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
            if (cmbFiltrarPor.Text == "Titulo" || cmbFiltrarPor.Text == "Descripcion") { txtFiltro.Visible = true; } else { txtFiltro.Visible = false; }
            if (cmbFiltrarPor.Text == "Color") { btnFiltroColor.Visible = true; } else { btnFiltroColor.Visible = false; }
            if (cmbFiltrarPor.Text == "Fecha") { dtpFiltrarFecha.Visible = true; } else { dtpFiltrarFecha.Visible = false; }
            if (cmbFiltrarPor.Text == "Alarma") { ckbAlarmaFiltro.Visible = true; } else { ckbAlarmaFiltro.Visible = false; }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvNotas.DataSource = Notas.BuscarPorFiltro(cmbFiltrarPor.Text, txtFiltro.Text, txtFiltro.Text, ckbAlarmaFiltro.Checked,
                btnFiltroColor.BackColor.ToArgb(), dtpFiltrarFecha.Value.ToString("yyyy-MM-dd"));
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
            if(e.RowIndex > 0)
            {
                string tituloeNota = dgvNotas.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    Notas.BorrarNota(tituloeNota);
                    dgvNotas.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
