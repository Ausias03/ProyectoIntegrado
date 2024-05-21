using System.Runtime.InteropServices;

namespace Gestionis.Clases
{
    public class FrmBarraPrincipal : Form
    {
        private Panel titleBarPanel;
        private PictureBox logoPictureBox;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmBarraPrincipal()
        {
            InitializeComponent();            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Dock = DockStyle.Top;
            this.Size = new Size(1600, 900);
            InitializeTitleBar();
        }
        private void InitializeComponent()
        {
            this.Icon = Properties.Resources.logo;
        }
        private void InitializeTitleBar()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            titleBarPanel = new Panel();
            titleBarPanel.Dock = DockStyle.Top;
            titleBarPanel.BackColor = Color.FromArgb(108, 104, 137);
            titleBarPanel.Height = 40;
            titleBarPanel.MouseDown += TitleBarPanel_MouseDown;

            logoPictureBox = new PictureBox();
            logoPictureBox.Image = Properties.Resources.gestionis;
            logoPictureBox.Size = new Size(40, 40);
            logoPictureBox.Location = new Point(0, 0);
            titleBarPanel.Controls.Add(logoPictureBox);

            Label lblTitulo = new Label();
            lblTitulo.Text = "Ge$tioni$";
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, 14);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(logoPictureBox.Right + 5);
            titleBarPanel.Controls.Add(lblTitulo);


            Button minimizeButton = new Button();
            minimizeButton.Text = "_";
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = Color.White;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.Size = new Size(40, 40);
            minimizeButton.Click += MinimizeButton_Click;
            titleBarPanel.Controls.Add(minimizeButton);

            Button maximizeButton = new Button();
            maximizeButton.Text = "⬜";
            maximizeButton.BackColor = Color.Transparent;
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.ForeColor = Color.White;
            maximizeButton.FlatAppearance.BorderSize = 0;
            maximizeButton.Dock = DockStyle.Right;
            maximizeButton.Size = new Size(40, 40);
            maximizeButton.Click += MaximizeButton_Click;
            titleBarPanel.Controls.Add(maximizeButton);

            Button closeButton = new Button();
            closeButton.Text = "X";
            closeButton.BackColor = Color.Transparent;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Dock = DockStyle.Right;
            closeButton.Size = new Size(40, 40);
            closeButton.Click += CloseButton_Click;
            closeButton.MouseEnter += CloseButton_MouseEnter;
            closeButton.MouseLeave += CloseButton_MouseLeave;
            titleBarPanel.Controls.Add(closeButton);

            this.Controls.Add(titleBarPanel);
        }

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
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            Button closeButton = sender as Button;
            if (closeButton != null)
            {
                closeButton.BackColor = Color.Red;
            }
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            Button closeButton = sender as Button;
            if (closeButton != null)
            {
                closeButton.BackColor = Color.Transparent;
            }
        }
    }
}
