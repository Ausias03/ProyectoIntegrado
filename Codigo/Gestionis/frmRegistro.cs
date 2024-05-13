using System.Diagnostics;

namespace Gestionis
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
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

            if (txtCorreo.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtCorreo, "Introduce un correo");
            }

            if (txtNombre.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Introduce un nombre");
            }

            if (txtContrasenya.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtContrasenya, "Introduce una contraseña");
            }

            return ok;
        }
        #endregion

        private void lklFaq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "firefox";
            process.StartInfo.Arguments = "www.wikipedia.org";
            process.Start();
        }

        private void lklInicioSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmInicioSesion fIS = new frmInicioSesion();
            fIS.Closed += (s, args) => this.Close();
            fIS.Show();
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
        }

        #region Metodos de implementacion
        private void RestablecerControlesVisuales()
        {
            txtNombreUsuario.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            txtContrasenya.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
        }
        #endregion        
    }
}
