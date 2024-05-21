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
    public partial class FrmModifNotif : Form
    {
        public FrmModifNotif()
        {
            InitializeComponent();
        }

        private void FrmModifNotif_Load(object sender, EventArgs e)
        {
            CargarCBOCategorias();
        }

        private void cboCategorias_TextChanged(object sender, EventArgs e)
        {
            decimal? limite = LimitesNotif.GetLimite(Sesion.Instance.NumCuenta, CategoriaGasto.DevuelveIDCategoria(cboCategorias.Text));

            nudLimite.Value = limite == null ? 0 : limite.Value;
            btnModificar.Text = limite == null ? "Agregar" : "Modificar";
        }

        private void btnModificar_Click(object sender, EventArgs e)
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

            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCBOCategorias()
        {
            cboCategorias.DataSource = CategoriaGasto.DevuelveNombresCategorias();
        }        
    }
}
