using System;
using Gestionis.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionis.Formularios;

namespace Gestionis
{
    public partial class FrmGestorDeudas : FrmBarraPrincipal
    {

        public FrmGestorDeudas()
        {
            InitializeComponent();
        }

        private void FrmGestorDeudas_Load(object sender, EventArgs e)
        {
            string[] filtros = Deuda.Filtros();
            for (int i = 0; i < filtros.Length; i++)
            {
                cmbCategoria.Items.Add(filtros[i]);
            }
            cmbCategoria.SelectedIndex = 0;
            Titulo();

            lblDeudasTotalesValor.Text = Deuda.DeudasTotales(2).ToString();
            ProximaDeuda();

            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            int numCuenta = 2;
            string consulta = $"SELECT titulo, descripcion, cantidad, fechaCreacion, fechaVencimiento  FROM deuda WHERE numCuenta = {numCuenta}";

            dgvGastosIngresos.DataSource = Utilidades.RellenarDatos(consulta);
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
                lblTitulo.Enabled = false;
                txtTitulo.Enabled = false;
            }
        }
        private void ProximaDeuda()
        {
            Deuda deuda = new Deuda();
            deuda.GetProximaDeuda(2, deuda);

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
        }

        private void btnAnyadirDeuda_Click(object sender, EventArgs e)
        {
            FrmAnyadirDeuda frmAnyadirDeuda = new FrmAnyadirDeuda();
            frmAnyadirDeuda.ShowDialog();
            lblDeudasTotalesValor.Text = Deuda.DeudasTotales(2).ToString();
            ProximaDeuda();
        }

        private void btnEliminarDeuda_Click(object sender, EventArgs e)
        {
            FrmEliminarDeuda frmEliminarDeuda = new FrmEliminarDeuda();
            frmEliminarDeuda.ShowDialog();
            lblDeudasTotalesValor.Text = Deuda.DeudasTotales(2).ToString();
            ProximaDeuda();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Titulo();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Titulo();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
