using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionis.Herramientas;

namespace Gestionis
{
    public partial class FrmGestorDeudas : Form
    {
        #region Barra Principal
        private Panel titleBarPanel;
        private PictureBox logoPictureBox;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public FrmGestorDeudas()
        {
            InitializeComponent();
        }
        private void FrmGestorDeudas_Load(object sender, EventArgs e)
        {
            #region Barra Principal
            this.Size = new Size(1700, 1000);

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
        #endregion

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

        private void pbHamburger_Click(object sender, EventArgs e)
        {
            BarraLateral.ColapsarExpandir(sender, e);
        }
    }
}
