﻿using Gestionis.Clases;
using System.Globalization;

namespace Gestionis
{
    public partial class frmAddCategoria : Form
    {
        public frmAddCategoria()
        {
            InitializeComponent();
        }

        private void frmAddCategoria_Load(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
        }

        #region Validaciones
        private bool ValidarDatos()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (txtNombreCat.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtNombreCat, "Debes introducir un nombre para la categoría");
            }

            return ok;
        }
        #endregion

        private void btnColorCat_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColorCat.BackColor = colorDialog1.Color;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Revisa los datos introducidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (CategoriaGasto.ExisteNombre(txtNombreCat.Text))
                {
                    MessageBox.Show("Ya existe una categoría con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CategoriaGasto.ExisteColor(btnColorCat.BackColor.ToArgb()))
                {
                    MessageBox.Show("Ya existe una categoría con ese color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CategoriaGasto cg1 = new CategoriaGasto(
                    txtNombreCat.Text,
                    btnColorCat.BackColor.ToArgb()
                    );

                cg1.Add();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
                this.Close();
            }
        }

        private void AplicarIdioma()
        {
            lblColorCat.Text = Resources.Idiomas.StringRecursosAddCat.lblColorCat;
            lblNombreCat.Text = Resources.Idiomas.StringRecursosAddCat.lblNombreCat;
            btnAddCategoria.Text = Resources.Idiomas.StringRecursosAddCat.btnAddCategoria;
            btnVolver.Text = Resources.Idiomas.StringRecursosAddCat.btnVolver;
        }
    }
}
