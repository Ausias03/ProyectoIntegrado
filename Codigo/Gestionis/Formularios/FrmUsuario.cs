using Gestionis.Clases;
using Gestionis;

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
using Gestionis.Formularios;
using Gestionis.Properties;
using Gestionis.Herramientas;
namespace Gestionis
{
    public partial class frmUsuario : FrmBarraPrincipal
    {
        private Usuario usuario;
        string apodo = Sesion.Instance.ApodoUsuario;
        public frmUsuario()
        {
            InitializeComponent();
            ModificarBotones();
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
            barraSecundaria1.Load();
            barraLateral1.Load();
            SetExpNivel();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void SetExpNivel()
        {
            string apodo = Sesion.Instance.ApodoUsuario;
            var (experienciaActual, nivelActual, xpParaSiguienteNivel, xpParaNivelActual) = SistemaNiveles.GetNivelInfo(apodo);

            int progress = SistemaNiveles.GetExpProgress(apodo);

            prbExperiencia.Maximum = xpParaSiguienteNivel - xpParaNivelActual;

            prbExperiencia.Value = progress;

            lblNivel.Text = experienciaActual == 0 ? "0" : nivelActual.ToString();
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
            this.Hide();

            frmInicioSesion frmInicio = new frmInicioSesion();
            frmInicio.Closed += (s, args) => this.Close();
            frmInicio.Show();
        }
        
        private void AplicarIdioma()
        {
            lblTuCuenta.Text = Resources.Idiomas.StringRecursosUsuario.lblTuCuenta;
            btnCerrarSesion.Text = Resources.Idiomas.StringRecursosUsuario.btnCerrarSesion;
            btnConfirmarFoto.Text = Resources.Idiomas.StringRecursosUsuario.btnConfirmarFoto;
            btnConfirmarApellidos.Text = Resources.Idiomas.StringRecursosUsuario.btnConfirmarApellidos;
            btnCambiarApellidos.Text = Resources.Idiomas.StringRecursosUsuario.btnCambiarApellidos;
            lblApellidos.Text = Resources.Idiomas.StringRecursosUsuario.lblApellidos;
            btnConfirmarTel.Text = Resources.Idiomas.StringRecursosUsuario.btnConfirmarTel;
            btnConfirmarDir.Text = Resources.Idiomas.StringRecursosUsuario.btnConfirmarDir;
            btnConfirmarCorreo.Text = Resources.Idiomas.StringRecursosUsuario.btnConfirmarCorreo;
            btnConfirmarApodo.Text = Resources.Idiomas.StringRecursosUsuario.btnConfirmarApodo;
            btnConfirmarNom.Text = Resources.Idiomas.StringRecursosUsuario.btnConfirmarNom;
            btnCambiarFoto.Text = Resources.Idiomas.StringRecursosUsuario.btnCambiarFoto;
            btnCambiarTel.Text = Resources.Idiomas.StringRecursosUsuario.btnCambiarTel;
            btnCambiarDir.Text = Resources.Idiomas.StringRecursosUsuario.btnCambiarDir;
            btnCambiarCorreo.Text = Resources.Idiomas.StringRecursosUsuario.btnCambiarCorreo;
            btnCambiarApodo.Text = Resources.Idiomas.StringRecursosUsuario.btnCambiarApodo;
            btnCambiarNom.Text = Resources.Idiomas.StringRecursosUsuario.btnCambiarNom;
            lblTelefono.Text = Resources.Idiomas.StringRecursosUsuario.lblTelefono;
            lblDireccion.Text = Resources.Idiomas.StringRecursosUsuario.lblDireccion;
            lblCorreo.Text = Resources.Idiomas.StringRecursosUsuario.lblCorreo;
            lblApodo.Text = Resources.Idiomas.StringRecursosUsuario.lblApodo;
            lblNombre.Text = Resources.Idiomas.StringRecursosUsuario.lblNombre;
        }
        

    }
}