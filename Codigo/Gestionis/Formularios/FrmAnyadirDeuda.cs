using Gestionis.Clases;

namespace Gestionis.Formularios
{
    public partial class FrmAnyadirDeuda : Form
    {
        public FrmAnyadirDeuda()
        {
            InitializeComponent();
        }

        private void FrmAnyadirDeuda_Load(object sender, EventArgs e)
        {
            ResetearFrm();
            dtpDeuda.MinDate = DateTime.Now;
            dtpVencimiento.MinDate = DateTime.Now;
        }

        #region Validaciones
        private bool ValidaDatos()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (txtTitulo.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtTitulo, "Introduce un nombre");
            }

            if (nudCantidadAdeudada.Value == 0)
            {
                ok = false;
                errorProvider1.SetError(nudCantidadAdeudada, "Introduce una contraseña");
            }

            return ok;
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                if (!Deuda.ExisteDeuda(txtTitulo.Text))
                {
                    Deuda deuda = new Deuda(txtTitulo.Text, rtbDescrip.Text, rdbDebo.Checked, nudCantidadAdeudada.Value, dtpDeuda.Value, dtpVencimiento.Value, chkRecordatorio.Checked);
                    if (deuda.Add() > 0)
                    {
                        if (chkRecordatorio.Checked)
                        {
                            //frmAddNota frmAddNota = new frmAddNota(deuda.GetIdDeuda(deuda));
                            //frmAddNota.ShowDialog();
                        }
                        MessageBox.Show("Deuda agregada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la deuda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una deuda con ese título", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ResetearFrm();
            }
        }

        private void ResetearFrm()
        {
            txtTitulo.Text = string.Empty;
            nudCantidadAdeudada.Text = string.Empty;
            rtbDescrip.Text = string.Empty;
            dtpDeuda.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now;
            chkRecordatorio.Checked = false;
            rdbDeben.Checked = false;
            rdbDebo.Checked = true;

            dtpDeuda.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now;
            rdbDebo.Checked = true;
        }
    }
}
