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
        #endregion

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }


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
            this.Size = new Size(1600, 800);

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
            closeButton.Location = new Point(this.Width - 42, 0);
            closeButton.Click += CloseButton_Click;
            titleBarPanel.Controls.Add(closeButton);

            Button minimizeButton = new Button();
            minimizeButton.Text = "-";
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = Color.White;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.Size = new Size(40, 40);
            minimizeButton.Location = new Point(this.Width - 90, 0);
            minimizeButton.Click += MinimizeButton_Click;
            titleBarPanel.Controls.Add(minimizeButton);

            // Add the custom title bar to the form
            this.Controls.Add(titleBarPanel);
            #endregion

            #region Barra Lateral
            btnInicio.Image = Properties.Resources.inicio;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.FlatAppearance.BorderSize = 0;

            btnInversiones.Image = Properties.Resources.inversiones;
            btnInversiones.ImageAlign = ContentAlignment.MiddleLeft;
            btnInversiones.FlatAppearance.BorderSize = 0;

            btnMetodoAhorro.Image = Properties.Resources.ahorro;
            btnMetodoAhorro.ImageAlign = ContentAlignment.MiddleLeft;
            btnMetodoAhorro.FlatAppearance.BorderSize = 0;

            btnDeudas.Image = Properties.Resources.deuda;
            btnDeudas.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeudas.FlatAppearance.BorderSize = 0;

            btnPatrimonio.Image = Properties.Resources.patrimonio;
            btnPatrimonio.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatrimonio.FlatAppearance.BorderSize = 0;

            btnNotas.Image = Properties.Resources.notas;
            btnNotas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotas.FlatAppearance.BorderSize = 0;

            btnTabalClasif.Image = Properties.Resources.calsificacion;
            btnTabalClasif.ImageAlign = ContentAlignment.MiddleLeft;
            btnTabalClasif.FlatAppearance.BorderSize = 0;

            btnHistorial.Image = Properties.Resources.historial;
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.FlatAppearance.BorderSize = 0;

            btnNotificaciones.Image = Properties.Resources.notificacion;
            btnNotificaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotificaciones.FlatAppearance.BorderSize = 0;

            btnPaginaWeb.Image = Properties.Resources.web;
            btnPaginaWeb.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaginaWeb.FlatAppearance.BorderSize = 0;

            btnAyuda.Image = Properties.Resources.ayuda;
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.FlatAppearance.BorderSize = 0;
            #endregion
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

        #region Barra Secundaria
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
        #endregion

        private void btnGasto_Click(object sender, EventArgs e)
        {
            frmAnyadirGasto fAG = new frmAnyadirGasto();
            fAG.ShowDialog();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            frmAnyadirIngreso fAI = new frmAnyadirIngreso();
            fAI.ShowDialog();
        }

        #region Barra Lateral
        private void pbHamburger_Click(object sender, EventArgs e)
        {
            transicionBarraLateral.Start();
        }

        bool barraLateralExpandida = true;
        private void transicionBarraLateral_Tick(object sender, EventArgs e)
        {
            if (barraLateralExpandida)
            {
                flpBarraLateral.Width -= 10;
                if (flpBarraLateral.Width <= 65)
                {
                    barraLateralExpandida = false;
                    transicionBarraLateral.Stop();
                }
            }
            else
            {
                flpBarraLateral.Width += 10;
                if (flpBarraLateral.Width >= 231)
                {
                    barraLateralExpandida = true;
                    transicionBarraLateral.Stop();
                }
            }
        }
        #endregion
    }
}
