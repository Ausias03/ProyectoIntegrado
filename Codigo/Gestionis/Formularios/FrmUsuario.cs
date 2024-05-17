using Gestionis.Clases;
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
        Usuario usuario;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            #region Controladores
            // Convertir un array de bytes (byte[]) a foto
            //picFoto.Image = usuario.Foto;
            txtNombre.Text = usuario.Nombre;
            if (usuario.Apellidos != "")
            {
                txtApellidos.Text = usuario.Apellidos;
            }
            txtApodo.Text = usuario.Apodo;
            txtCorreo.Text = usuario.Correo;
            if (usuario.Direccion != "")
            {
                txtDireccion.Text = usuario.Direccion;
            }
            if (usuario.Telefono != "")
            {
                txtTelefono.Text = usuario.Telefono;
            }
            #endregion
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            helpProvider1.SetHelpString(btnCambiarNom, "Pulsando en los botones de 'Cambiar' se desbloquedara la caja de texto adyacente para poder modificar el atributo correnpondiente. Tras modificar el texto, pulsa en el botón 'Confirmar que aparecera en el lugar del botón 'Cambiar' para confirmar el cambio");
            helpProvider1.SetShowHelp(btnCambiarNom, true);
            helpProvider1.SetHelpString(btnCambiarFoto, "Pulsando en este botón de 'Cambiar' se permitira la subida de un archivo para que haga la función de foto de usuario.");
            helpProvider1.SetShowHelp(btnCambiarFoto, true);
        }
    }
}