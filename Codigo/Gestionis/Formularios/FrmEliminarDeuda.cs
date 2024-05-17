using Gestionis.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionis.Formularios
{
    public partial class FrmEliminarDeuda : Form
    {
        public FrmEliminarDeuda()
        {
            InitializeComponent();
        }

        private void FrmEliminarDeuda_Load(object sender, EventArgs e)
        {
            ResetearFrm();
        }

        private void ResetearFrm()
        {
            lblCantidadAdeudadaValor.Text = string.Empty;
            lblFechaVencimientoValor.Text = string.Empty;
            lblFechaDeudaValor.Text = string.Empty;
            rtbDescrip.Text = string.Empty;
            lblTipoValor.Text = string.Empty;
            txtTitulo.ReadOnly = false;
            txtTitulo.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtTitulo.Text != string.Empty)
            {
                if (Deuda.ExisteDeuda(txtTitulo.Text))
                {
                    Deuda deuda = new Deuda();
                    Deuda.GetDeuda(txtTitulo.Text, deuda);
                    txtTitulo.ReadOnly = true;

                    lblCantidadAdeudadaValor.Text = deuda.Cantidad.ToString() + "€";
                    rtbDescrip.Text = deuda.Descripcion;
                    if (deuda.Debo) lblTipoValor.Text = "Debo"; 
                    else lblTipoValor.Text = "Me deben";
                    lblFechaDeudaValor.Text = deuda.FechaCreacion.ToShortDateString();
                    lblFechaVencimientoValor.Text = deuda.FechaVencimiento.ToShortDateString();
                }
                else
                {
                    MessageBox.Show($"No existe una deuda llamada: {txtTitulo.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetearFrm();
                }
            }
            else
            {
                MessageBox.Show("Introduce el título de la deuda primero!","",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int res = Deuda.EliminarDeuda(txtTitulo.Text);

            if(res > 0)
            {
                MessageBox.Show("Deuda eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetearFrm();
            }
            else
            {
                MessageBox.Show("Error al eliminar la deuda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            ResetearFrm();
        }
    }
}
