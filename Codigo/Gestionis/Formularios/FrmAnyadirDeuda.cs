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

        private void FrmAnyadirDeuda_Load(object sender, EventArgs e)
        {
            ResetearFrm();
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
            if(ValidaDatos())
            {
                if (!Deuda.ExisteDeuda(txtTitulo.Text))
                {
                    int numCuenta = 2;
                    Deuda deuda = new Deuda(numCuenta, txtTitulo.Text, rtbDescrip.Text, rdbDebo.Checked, nudCantidadAdeudada.Value, dtpDeuda.Value, dtpVencimiento.Value, chkRecordatorio.Checked);
                    if (deuda.Add() > 0)
                    {
                        if(chkRecordatorio.Checked)
                        {
                            frmAddNota frmAddNota = new frmAddNota();
                            frmAddNota.ShowDialog();
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
