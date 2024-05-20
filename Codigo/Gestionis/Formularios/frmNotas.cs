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

            dgvNotas.DataSource = Notas.RecargarTabla();
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

        private void cmbFiltrarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarPor.Text == "Titulo" || cmbFiltrarPor.Text == "Descripcion") { txtFiltro.Visible = true; } else { txtFiltro.Visible = false; }
            if (cmbFiltrarPor.Text == "Color") { btnFiltroColor.Visible = true; } else { btnFiltroColor.Visible = false; }
            if (cmbFiltrarPor.Text == "Fecha") { dtpFiltrarFecha.Visible = true; } else { dtpFiltrarFecha.Visible = false; }
            if (ckbAlarmaFiltro.Checked == true) { ckbAlarmaFiltro.Visible = true; } else { ckbAlarmaFiltro.Visible = false; }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvNotas.DataSource = Notas.BuscarFiltro(cmbFiltrarPor.Text, txtFiltro.Text, txtFiltro.Text, ckbAlarmaFiltro.Checked, btnFiltroColor.BackColor.ToArgb(), dtpFiltrarFecha.Value);
        }

        private void btnRestaurarFiltro_Click(object sender, EventArgs e)
        {
            dgvNotas.DataSource = Notas.RecargarTabla();
        }

        private void btnFiltroColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.btnFiltroColor.BackColor = colorDialog1.Color;
            }
        }

        private void frmNotas_Activated(object sender, EventArgs e)
        {
            dgvNotas.DataSource = Notas.RecargarTabla();
        }
    }
}
