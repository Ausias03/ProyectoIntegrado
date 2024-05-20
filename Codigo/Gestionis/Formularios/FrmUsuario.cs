using Gestionis.Clases;
//using Gestionis.Idiomas;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gestionis
{
    public partial class frmUsuario : FrmBarraPrincipal
    {
        private Usuario usuario;
        public frmUsuario()
        {
            InitializeComponent();
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            #region Controladores
            // Convertir un array de bytes (byte[]) a foto
            //picFoto.Image = usuario.Foto;
            txtNombre.Text = usuario.Nombre;
            txtApellidos.Text = usuario.Apellidos;
            txtApodo.Text = usuario.Apodo;
            txtCorreo.Text = usuario.Correo;
            txtDireccion.Text = usuario.Direccion;
            txtTelefono.Text = usuario.Telefono;
            #endregion
            barraSecundaria1.BarraSecundaria_Load();
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
            if (txtApodo.Text == "" || Usuario.Existe(txtApodo.Text))
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

        #region Botones Cambiar
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
        #endregion

        #region Botones Confirmar
        private void btnConfirmarNom_Click(object sender, EventArgs e)
        {
            if (ValidarNombre())
            {
                usuario.Nombre = txtNombre.Text;
                txtNombre.ReadOnly = true;
                btnConfirmarNom.Hide();
                btnCambiarNom.Show();
            }
        }

        private void btnConfirmarApellidos_Click(object sender, EventArgs e)
        {
            usuario.Apellidos = txtApellidos.Text;
            txtApellidos.ReadOnly = true;
            btnConfirmarApellidos.Hide();
            btnCambiarApellidos.Show();
        }

        private void btnConfirmarApodo_Click(object sender, EventArgs e)
        {
            if (ValidarApodo())
            {
                if (Usuario.Existe(txtApodo.Text))
                {
                    errorProvider1.SetError(txtApodo, "El apodo introducido ya esta en uso.");
                }
                else
                {
                    errorProvider1.Clear();
                    usuario.Apodo = txtApodo.Text;
                    txtApodo.ReadOnly = true;
                    btnConfirmarApodo.Hide();
                    btnCambiarApodo.Show();
                }
            }
        }

        private void btnConfirmarCorreo_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo())
            {
                usuario.Correo = txtCorreo.Text;
                txtCorreo.ReadOnly = true;
                btnConfirmarCorreo.Hide();
                btnCambiarCorreo.Show();
            }
        }

        private void btnConfirmarDir_Click(object sender, EventArgs e)
        {
            usuario.Direccion = txtDireccion.Text;
            txtDireccion.ReadOnly = true;
            btnConfirmarDir.Hide();
            btnCambiarDir.Show();
        }

        private void btnConfirmarTel_Click(object sender, EventArgs e)
        {
            usuario.Telefono = txtTelefono.Text;
            txtTelefono.ReadOnly = true;
            btnConfirmarTel.Hide();
            btnCambiarTel.Show();
        }

        private void btnConfirmarFoto_Click(object sender, EventArgs e)
        {
            // Convertir un array de bytes (byte[]) a foto
            //usuario.Foto = picFoto.Image;
            btnConfirmarFoto.Hide();
            btnCambiarFoto.Show();
        }
        #endregion

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        private void AplicarIdioma()
        {
            lblApodo.Text = StringRecursos.Nombre2;
        }
        */
    }
}