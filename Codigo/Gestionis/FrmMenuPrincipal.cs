using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionis
{
    public partial class FrmMenuPrincipal : Form
    {
        #region Barra Principal
        private Panel titleBarPanel;
        private PictureBox logoPictureBox;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            #region Botones
            btnIngreso.FlatStyle = FlatStyle.Flat;
            btnIngreso.FlatAppearance.BorderColor = Color.Black;
            btnIngreso.FlatAppearance.BorderSize = 2;

            btnGasto.FlatStyle = FlatStyle.Flat;
            btnGasto.FlatAppearance.BorderColor = Color.Black;
            btnGasto.FlatAppearance.BorderSize = 2;

            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 2;

            #endregion

            #region Labels
            lblIngresosValor.Text = "0€";
            lblGastosValor.Text = "0€";
            lblTotalValor.Text = "0€";

            lblMes.Text = DateTime.Now.ToString("MMMM");
            lblNotasValor.Text = "";
            #endregion

            #region Barra Principal
            this.Size = new Size(1600, 900);

            this.FormBorderStyle = FormBorderStyle.None;

            // Create and customize the custom title bar
            titleBarPanel = new Panel();
            titleBarPanel.Dock = DockStyle.Top;
            titleBarPanel.BackColor = Color.FromArgb(108, 104, 137);
            titleBarPanel.Height = 40; // Adjust the height as needed
            titleBarPanel.MouseDown += TitleBarPanel_MouseDown;

            // Add logo to the left side of the title bar
            logoPictureBox = new PictureBox();
            logoPictureBox.Image = Properties.Resources.logo.ToBitmap(); // Assign your logo image here
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.Size = new Size(40, 40);
            logoPictureBox.Location = new Point(0, 0);
            titleBarPanel.Controls.Add(logoPictureBox);

            // Add minimize, maximize, and close buttons to the custom title bar
            Button closeButton = new Button();
            closeButton.Text = "X";
            closeButton.BackColor = Color.Transparent;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Size = new Size(40, 40);
            closeButton.Location = new Point(this.Width - 50, 0);
            closeButton.Click += CloseButton_Click;
            titleBarPanel.Controls.Add(closeButton);

            Button maximizeButton = new Button();
            maximizeButton.Text = "+";
            maximizeButton.BackColor = Color.Transparent;
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.ForeColor = Color.White;
            maximizeButton.FlatAppearance.BorderSize = 0;
            maximizeButton.Size = new Size(40, 40);
            maximizeButton.Location = new Point(this.Width - 100, 0);
            maximizeButton.Click += MaximizeButton_Click;
            titleBarPanel.Controls.Add(maximizeButton);

            Button minimizeButton = new Button();
            minimizeButton.Text = "-";
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = Color.White;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.Size = new Size(40, 40);
            minimizeButton.Location = new Point(this.Width - 150, 0);
            minimizeButton.Click += MinimizeButton_Click;
            titleBarPanel.Controls.Add(minimizeButton);

            // Add the custom title bar to the form
            this.Controls.Add(titleBarPanel);
            #endregion

            pbSpain.Visible = false;
        }

        #region Controles Barra Principal
        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbHamburger_Click(object sender, EventArgs e)
        {

        }

        private void pbSpain_Click(object sender, EventArgs e)
        {
            pbEnglish.Visible = true;
            pbEnglish.Enabled = true;
            pbSpain.Visible = false;
            pbSpain.Enabled = false;
        }

        private void pbEnglish_Click(object sender, EventArgs e)
        {
            pbEnglish.Visible = false;
            pbEnglish.Enabled = false;
            pbSpain.Visible = true;
            pbSpain.Enabled = true;
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

            pbNoticias.Image = Properties.Resources.newspaper.ToBitmap();
            pbNoticias.SizeMode = PictureBoxSizeMode.StretchImage;

            pbNotificaciones.Image = Properties.Resources.bell.ToBitmap();
            pbNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;

            pbUsuario.Image = Properties.Resources.user.ToBitmap();
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;

            pbTema.Image = Properties.Resources.dark.ToBitmap();
            pbTema.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
