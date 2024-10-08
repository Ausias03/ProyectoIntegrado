using Gestionis.Clases;
using System.Drawing.Imaging;
using System.Globalization;

namespace Gestionis
{
    public partial class frmUsuario : FrmBarraPrincipal
    {
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer tooltipTimer;
        private Queue<KeyValuePair<Control, string>> tooltipQueue;
        private int tooltipDuration = 2000;
        private Usuario usuario;
        private readonly Cuenta cuentaUsuario;
        public frmUsuario()
        {
            try
            {
                InitializeComponent();
                ModificarBotones();

                toolTip = new System.Windows.Forms.ToolTip();
                tooltipQueue = new Queue<KeyValuePair<Control, string>>();
                tooltipTimer = new System.Windows.Forms.Timer();
                tooltipTimer.Interval = tooltipDuration;
                tooltipTimer.Tick += TooltipTimer_Tick;
                usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
                cuentaUsuario = usuario.GetCuenta();
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
            barraSecundaria1.BtnAyuda.Click += BtnAyuda_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            barraLateral2.AplicarIdiomas();
        }

        #region ToolTips
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol)
            {
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarFoto, "Haz clic aqu� para cambiar tu foto de perfil."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(prbExperiencia, "Aqu� se muestra tu progreso de experiencia."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarNom, "Haz clic aqu� para cambiar tu nombre."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarApellidos, "Haz clic aqu� para cambiar tus apellidos."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarApodo, "Haz clic aqu� para cambiar tu apodo."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarCorreo, "Haz clic aqu� para cambiar tu correo electr�nico."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarDir, "Haz clic aqu� para cambiar tu direcci�n."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarTel, "Haz clic aqu� para cambiar tu n�mero de tel�fono."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCerrarSesion, "Haz clic aqu� para cerrar sesi�n."));
            }
            else
            {
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarFoto, "Click here to change your profile picture."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(prbExperiencia, "Your experience progress is displayed here."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarNom, "Click here to change your name."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarApellidos, "Click here to change your last name."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarApodo, "Click here to change your nickname."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarCorreo, "Click here to change your email."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarDir, "Click here to change your address."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCambiarTel, "Click here to change your phone number."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnCerrarSesion, "Click here to log out."));
            }

            SiguienteTooltip();
        }

        private void SiguienteTooltip()
        {
            if (tooltipQueue.Count > 0)
            {
                var tooltipItem = tooltipQueue.Dequeue();
                ShowTooltip(tooltipItem.Key, tooltipItem.Value);
                tooltipTimer.Start();
            }
            else
            {
                tooltipTimer.Stop();
            }
        }

        private void TooltipTimer_Tick(object sender, EventArgs e)
        {
            toolTip.Hide(this);
            SiguienteTooltip();
        }

        private void ShowTooltip(Control control, string message)
        {
            toolTip.SetToolTip(control, message);
            toolTip.Show(message, control, control.Width / 2, control.Height / 2);
        }
        #endregion

        private void SetExpNivel()
        {
            try
            {
                string apodo = Sesion.Instance.ApodoUsuario;
                var (experienciaActual, nivelActual, xpParaSiguienteNivel, xpParaNivelActual) = SistemaNiveles.GetNivelInfo(apodo);

                int progress = SistemaNiveles.GetExpProgress(apodo);

                prbExperiencia.Maximum = xpParaSiguienteNivel - xpParaNivelActual;

                prbExperiencia.Value = progress;

                lblNivel.Text = experienciaActual == 0 ? "0" : nivelActual.ToString();

                ActualizaMarco(nivelActual);
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

        #region Validaci�n de datos

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
                errorProvider1.SetError(txtCorreo, "Es necesario proporcionar un correo electr�nico.");
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
                finally
                {
                    ConexionDB.CerrarConexion();
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

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                double? ingresoMensual = cuentaUsuario.TotalIngresos();
                double? gastoMensual = cuentaUsuario.TotalGastos();
                List<Gasto> infoGastos = cuentaUsuario.DevuelveGastos();
                List<Ingreso> infoIngresos = cuentaUsuario.DevuelveIngresos();
                double? debo = Deuda.CalcularTotalDeuda(true);
                double? meDeben = Deuda.CalcularTotalDeuda(false);
                double? deudasTotales = Deuda.DeudasTotales();

                Cuenta.GenerarPDF(usuario.Nombre, usuario.Apellidos, usuario.Apodo, usuario.Correo, usuario.Telefono, usuario.Direccion,
                    ingresoMensual, gastoMensual, infoGastos, infoIngresos, debo, meDeben, deudasTotales);
                MessageBox.Show("El pdf se ha creado correctamente", "Generaci�n del PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { }
            finally { ConexionDB.CerrarConexion(); }
        }

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