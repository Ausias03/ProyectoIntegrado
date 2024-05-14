using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gestionis
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        #region Validación de datos

        private bool ValidarNombre()
        {
            bool valido = true;
            if (txtNombre.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "Es necesario proporcionar un nombre.");
            }
            else
            {
                errorProvider1.Clear();
            }
            return valido;
        }

        private bool ValidarApodo()
        {
            bool valido = true;
            if (txtApodo.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtApodo, "Es necesario proporcionar un apodo.");
            }
            else
            {
                errorProvider1.Clear();
            }
            return valido;
        }

        private bool ValidarCorreo()
        {
            bool valido = true;
            if (txtCorreo.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtCorreo, "Es necesario proporcionar un correo electrónico.");
            }
            else
            {
                errorProvider1.Clear();
            }
            return valido;
        }

        #endregion

        private void btnCambiarNom_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            btnCambiarNom.Hide();
            btnConfirmarNom.Show();
        }

        private void btnCambiarApellidos_Click(object sender, EventArgs e)
        {
            txtApellidos.ReadOnly = false;
            btnCambiarApellidos.Hide();
            btnConfirmarApellidos.Show();
        }

        private void btnCambiarApodo_Click(object sender, EventArgs e)
        {
            txtApodo.ReadOnly = false;
            btnCambiarApodo.Hide();
            btnConfirmarApodo.Show();
        }

        private void btnCambiarCorreo_Click(object sender, EventArgs e)
        {
            txtCorreo.ReadOnly = false;
            btnCambiarCorreo.Hide();
            btnConfirmarCorreo.Show();
        }

        private void btnCambiarDir_Click(object sender, EventArgs e)
        {
            txtDireccion.ReadOnly = false;
            btnCambiarDir.Hide();
            btnConfirmarDir.Show();
        }

        private void btnCambiarTel_Click(object sender, EventArgs e)
        {
            txtTelefono.ReadOnly = false;
            btnCambiarTel.Hide();
            btnConfirmarTel.Show();
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            btnCambiarFoto.Hide();
            btnConfirmarFoto.Show();
        }

        private void btnConfirmarNom_Click(object sender, EventArgs e)
        {
            if (ValidarNombre())
            {
                txtNombre.ReadOnly = true;
                btnConfirmarNom.Hide();
                btnCambiarNom.Show();
            }
        }

        private void btnConfirmarApellidos_Click(object sender, EventArgs e)
        {
            txtApellidos.ReadOnly = true;
            btnConfirmarApellidos.Hide();
            btnCambiarApellidos.Show();
        }

        private void btnConfirmarApodo_Click(object sender, EventArgs e)
        {
            if (ValidarApodo())
            {
                txtApodo.ReadOnly = true;
                btnConfirmarApodo.Hide();
                btnCambiarApodo.Show();
            }
        }

        private void btnConfirmarCorreo_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo())
            {
                txtCorreo.ReadOnly = true;
                btnConfirmarCorreo.Hide();
                btnCambiarCorreo.Show();
            }
        }

        private void btnConfirmarDir_Click(object sender, EventArgs e)
        {
            txtDireccion.ReadOnly = true;
            btnConfirmarDir.Hide();
            btnCambiarDir.Show();
        }

        private void btnConfirmarTel_Click(object sender, EventArgs e)
        {
            txtTelefono.ReadOnly = true;
            btnConfirmarTel.Hide();
            btnCambiarTel.Show();
        }

        private void btnConfirmarFoto_Click(object sender, EventArgs e)
        {
            btnConfirmarFoto.Hide();
            btnCambiarFoto.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlBarra_Paint(object sender, PaintEventArgs e)
        {
            pbHamburger.Image = Properties.Resources.hamburger.ToBitmap();
            pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;

            pbAyuda.Image = Properties.Resources.question.ToBitmap();
            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;

            pbEnglish.Image = Properties.Resources.england.ToBitmap();
            pbEnglish.SizeMode = PictureBoxSizeMode.StretchImage;

            pbSpain.Image = Properties.Resources.eapanya.ToBitmap();
            pbSpain.SizeMode = PictureBoxSizeMode.StretchImage;

            p.Image = Properties.Resources.newspaper.ToBitmap();
            p.SizeMode = PictureBoxSizeMode.StretchImage;

            a.Image = Properties.Resources.bell.ToBitmap();
            a.SizeMode = PictureBoxSizeMode.StretchImage;

            u.Image = Properties.Resources.user.ToBitmap();
            u.SizeMode = PictureBoxSizeMode.StretchImage;

            pbTema.Image = Properties.Resources.dark.ToBitmap();
            pbTema.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}