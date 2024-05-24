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
using System.Drawing.Imaging;

namespace Gestionis
{
    public partial class frmUsuario : FrmBarraPrincipal
    {
        private Usuario usuario;
        string apodo = Sesion.Instance.ApodoUsuario;
        public frmUsuario()
        {
            try
            {
                InitializeComponent();
                ModificarBotones();
                usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            #region Controladores
            MemoryStream ms = new MemoryStream(usuario.Foto);
            Bitmap bm = new Bitmap(ms);
            pctFoto.Image = bm;
            txtNombre.Text = usuario.Nombre;
            txtApellidos.Text = usuario.Apellidos;
            txtApodo.Text = usuario.Apodo;
            txtCorreo.Text = usuario.Correo;
            txtDireccion.Text = usuario.Direccion;
            txtTelefono.Text = usuario.Telefono;
            #endregion

            try
            {
                barraSecundaria1.Load();
                barraLateral2.Load();
                SetExpNivel();
                if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                AplicarIdioma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            barraLateral2.AplicarIdiomas();
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
            try
            {
                OpenFileDialog ofdSeleccionar = new OpenFileDialog();
                ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
                ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofdSeleccionar.Title = "Seleccionar imagen";

                if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
                {
                    Image foto = Image.FromFile(ofdSeleccionar.FileName);
                    pctFoto.Image = foto;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        foto.Save(ms, ImageFormat.Jpeg);
                        byte[] fotoArrayBytes = ms.ToArray();
                        Usuario.CambiarCampo("foto", fotoArrayBytes);
                        SistemaNiveles.IncrementarExperiencia(Sesion.Instance.ApodoUsuario, 15);
                        SetExpNivel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }
        #endregion

        #region Botones Confirmar
        private void btnConfirmarNom_Click(object sender, EventArgs e)
        {
            if (ValidarNombre())
            {
                try
                {
                    usuario.Nombre = txtNombre.Text;
                    txtNombre.ReadOnly = true;
                    btnConfirmarNom.Hide();
                    btnCambiarNom.Show();
                    Usuario.CambiarCampo("nombre", txtNombre.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ConexionDB.CerrarConexion();
                }
            }
        }

        private void btnConfirmarApellidos_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.Apellidos = txtApellidos.Text;
                txtApellidos.ReadOnly = true;
                btnConfirmarApellidos.Hide();
                btnCambiarApellidos.Show();
                Usuario.CambiarCampo("apellidos", txtApellidos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void btnConfirmarApodo_Click(object sender, EventArgs e)
        {
            if (ValidarApodo())
            {
                try
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
                        Usuario.CambiarCampo("apodo", txtApodo.Text);
                        Sesion.Instance.ApodoUsuario = txtApodo.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ConexionDB.CerrarConexion();
                }
            }
        }

        private void btnConfirmarCorreo_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo())
            {
                try
                {
                    if (Usuario.CorreoExiste(txtCorreo.Text))
                    {
                        errorProvider1.SetError(txtCorreo, "El correo introducido ya esta en uso.");
                    }
                    else
                    {
                        usuario.Correo = txtCorreo.Text;
                        txtCorreo.ReadOnly = true;
                        btnConfirmarCorreo.Hide();
                        btnCambiarCorreo.Show();
                        Usuario.CambiarCampo("correo", txtCorreo.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirmarDir_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.Direccion = txtDireccion.Text;
                txtDireccion.ReadOnly = true;
                btnConfirmarDir.Hide();
                btnCambiarDir.Show();
                Usuario.CambiarCampo("direccion", txtDireccion.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void btnConfirmarTel_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.Telefono = txtTelefono.Text;
                txtTelefono.ReadOnly = true;
                btnConfirmarTel.Hide();
                btnCambiarTel.Show();
                Usuario.CambiarCampo("telefono", txtTelefono.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }
        #endregion

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmInicioSesion frmInicio = new frmInicioSesion();
            frmInicio.Closed += (s, args) => this.Close();
            frmInicio.Show();
        }

        #region Métodos de implementación
        private void SetExpNivel()
        {
            string apodo = Sesion.Instance.ApodoUsuario;
            var (experienciaActual, nivelActual, xpParaSiguienteNivel, xpParaNivelActual) = SistemaNiveles.GetNivelInfo(apodo);

            int progress = SistemaNiveles.GetExpProgress(apodo);

            prbExperiencia.Maximum = xpParaSiguienteNivel - xpParaNivelActual;

            prbExperiencia.Value = progress;

            lblNivel.Text = experienciaActual == 0 ? "0" : nivelActual.ToString();

            ActualizaMarco(nivelActual);
        }

        private void ActualizaMarco(int nivel)
        {
            if (nivel < 3)
            {
                pctMarco.Image = Properties.Resources.Marco1;
            }
            else if (nivel < 5)
            {
                pctMarco.Image = Properties.Resources.Marco2;
            }
            else
            {
                pctMarco.Image = Properties.Resources.Marco3;
            }
        }
        #endregion

        private void AplicarIdioma()
        {
            lblTuCuenta.Text = Resources.Idiomas.StringRecursosUsuario.lblTuCuenta;
            btnCerrarSesion.Text = Resources.Idiomas.StringRecursosUsuario.btnCerrarSesion;
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