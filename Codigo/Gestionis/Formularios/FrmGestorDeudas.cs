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

        }

        private void btnAnyadirDeuda_Click(object sender, EventArgs e)
        {
            FrmAnyadirDeuda frmAnyadirDeuda = new FrmAnyadirDeuda();
            frmAnyadirDeuda.ShowDialog();
        }

        private void btnEliminarDeuda_Click(object sender, EventArgs e)
        {
            FrmEliminarDeuda frmEliminarDeuda = new FrmEliminarDeuda();
            frmEliminarDeuda.ShowDialog();
        }
    }
}
