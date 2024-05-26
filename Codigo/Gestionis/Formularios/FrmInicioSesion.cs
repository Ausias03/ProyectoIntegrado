using Gestionis.Clases;
using System.Diagnostics;

namespace Gestionis
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        #region Validaciones
        private bool ValidaDatos()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (txtNombreUsuario.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtNombreUsuario, "Introduce un nombre");
            }

            if (txtContrasenya.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(pctVerContrasenya, "Introduce una contraseña");
            }

            return ok;
        }
        #endregion

        private void lklFaq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://borokalashnika.github.io/GestionisWeb/Preguntas.html") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace. Error: " + ex.Message);
            }
        }

        private void lklRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegistro fR = new frmRegistro();
            fR.Closed += (s, args) => this.Close();
            fR.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            RestablecerControlesVisuales();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
            {
                MessageBox.Show("Revisa los datos introducidos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string apodoUsuario = txtNombreUsuario.Text.ToLower();
                if (!Usuario.Existe(apodoUsuario))
                {
                    MessageBox.Show("No existe un usuario con ese apodo / nombre", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario usuario = Usuario.BuscaUsuario(apodoUsuario);

                if (!usuario.CompruebaCredenciales(txtContrasenya.Text))
                {
                    MessageBox.Show("Contraseña Incorrecta", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Sesion.Instance.ApodoUsuario = apodoUsuario;

                this.Hide();
                FrmMenuPrincipal fMP = new FrmMenuPrincipal();
                fMP.Closed += (s, args) => this.Close();
                fMP.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtContrasenya.PasswordChar == '*')
            {
                txtContrasenya.PasswordChar = '\0';
            }
            else
            {
                txtContrasenya.PasswordChar = '*';
            }
        }

        #region Metodos de implementacion
        private void RestablecerControlesVisuales()
        {
            txtNombreUsuario.Text = String.Empty;
            txtContrasenya.Text = String.Empty;
        }
        #endregion        
    }
}
