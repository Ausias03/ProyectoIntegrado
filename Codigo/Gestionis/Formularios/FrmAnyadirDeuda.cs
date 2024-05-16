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
    public partial class FrmAnyadirDeuda : Form
    {
        public FrmAnyadirDeuda()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int numCuenta = 0;
            Deuda deuda = new Deuda(numCuenta, txtTitulo.Text, rtbDescrip.Text, rdbDebo.Checked, (float)nudCantidadAdeudada.Value, dtpDeuda.Value, dtpVencimiento.Value, chkRecordatorio.Checked);
            deuda.Add();

            txtTitulo.Text = string.Empty;
            nudCantidadAdeudada.Text = string.Empty;
            rtbDescrip.Text = string.Empty;
            dtpDeuda.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now;
            chkRecordatorio.Checked = false;
            rdbDeben.Checked = false;
            rdbDebo.Checked = true;
        }

        private void FrmAnyadirDeuda_Load(object sender, EventArgs e)
        {
            dtpDeuda.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now;
            rdbDebo.Checked = true;
        }
    }
}
