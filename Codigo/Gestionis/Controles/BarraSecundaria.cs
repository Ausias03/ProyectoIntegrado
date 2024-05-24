using Gestionis.Clases;
using System.Globalization;

namespace Gestionis.Herramientas
{
    public class BarraSecundaria : Panel
    {
        public Button BtnHamburger { get; private set; }
        public Button BtnAyuda { get; private set; }
        public Button BtnLanguage { get; private set; }
        public Button BtnNoticias { get; private set; }
        public Button BtnNotificaciones { get; private set; }
        public Button BtnUsuario { get; private set; }
        public Button BtnTema { get; private set; }

        private bool temaOscuro = Sesion.Instance.TemaOscuro;

        public BarraSecundaria()
        {
            InitializePanelProperties();
            CreateButtons();
            Load();
        }
        public void Load()
        {
            Tema();
            BtnHamburger.Image = Sesion.Instance.BarraExpandida ? Properties.Resources.hamburgerUp : Properties.Resources.hamburgerLeft;
            Espanyol();
        }

        private void InitializePanelProperties()
        {
            this.Dock = DockStyle.Top;
            this.Size = new Size(Width, 35);
            this.BackColor = Color.FromArgb(211, 208, 242);
        }

        private void CreateButtons()
        {
            BtnHamburger = CreateButton(Properties.Resources.hamburgerUp, "Hamburger");
            BtnAyuda = CreateButton(Properties.Resources.ayuda, "Ayuda");
            BtnLanguage = CreateButton(Properties.Resources.england, "Language");
            BtnNoticias = CreateButton(Properties.Resources.news, "Noticias");
            BtnNotificaciones = CreateButton(Properties.Resources.notif, "Notificaciones");
            BtnUsuario = CreateButton(Properties.Resources.user, "Usuario");
            BtnTema = CreateButton(Properties.Resources.darkTheme, "Tema");

            BtnNoticias.Dock = DockStyle.Right;
            BtnNotificaciones.Dock = DockStyle.Right;
            BtnUsuario.Dock = DockStyle.Right;

            BtnAyuda.Dock = DockStyle.Left;
            BtnTema.Dock = DockStyle.Left;
            BtnLanguage.Dock = DockStyle.Left;
            BtnHamburger.Dock = DockStyle.Left;

            Controls.AddRange(new Control[] { BtnTema, BtnNoticias, BtnNotificaciones, BtnUsuario, BtnLanguage, BtnAyuda, BtnHamburger });
        }

        private Button CreateButton(Image image, string name)
        {
            Button button = new Button();
            button.Name = "btn" + name;
            button.Size = new Size(50, 30);
            button.Image = image;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Click += Button_Click;
            return button;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonName = clickedButton.Name;
                switch (buttonName)
                {
                    case "btnHamburger":
                        BtnHamburger.Image = BarraLateral.ColapsarExpandir() ? Properties.Resources.hamburgerLeft : Properties.Resources.hamburgerUp;
                        break;
                    case "btnAyuda":

                        break;
                    case "btnLanguage":                        
                        if(Sesion.Instance.Espanyol) Sesion.Instance.Espanyol = false;
                        else Sesion.Instance.Espanyol = true;
                        Espanyol();
                        break;
                    case "btnNoticias":

                        break;
                    case "btnNotificaciones":
                        ShowFrmNotificaciones();
                        break;
                    case "btnUsuario":
                        Form frmActual = FindForm();
                        frmActual.Hide();
                        frmUsuario frmUsuario = new frmUsuario();
                        frmUsuario.Closed += (s, args) => frmActual.Close();
                        frmUsuario.ShowDialog();                        
                        break;
                    case "btnTema":
                        temaOscuro = !temaOscuro;
                        Sesion.Instance.TemaOscuro = temaOscuro;
                        Tema();
                        break;
                }
            }
        }

        private void Espanyol()
        {
            if(Sesion.Instance.Espanyol)
            {
                BtnLanguage.Image = Properties.Resources.spain;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            }
            else
            {
                BtnLanguage.Image = Properties.Resources.england;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            }
        }

        private void ShowFrmNotificaciones()
        {
            FrmNotificaciones fN = new FrmNotificaciones();

            Point btnLocation = BtnNotificaciones.PointToScreen(Point.Empty);

            int formX = btnLocation.X + BtnNotificaciones.Width - fN.Width;
            int formY = btnLocation.Y + BtnNotificaciones.Height;

            fN.StartPosition = FormStartPosition.Manual;
            fN.Location = new Point(formX, formY);

            fN.ShowDialog();
        }


        #region Cambiar Tema
        private void Tema()
        {
            Color fondo = temaOscuro ? Color.FromArgb(22, 22, 22) : Color.FromArgb(233, 236, 239);
            Color cajas = temaOscuro ? Color.FromArgb(0, 115, 148) : Color.FromArgb(205, 213, 221);
            Color texto = temaOscuro ? Color.White : Color.Black;

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.BackColor = fondo;

                CambiarTextoBotones(parentForm.Controls, texto);
                CambiarColorBarraLateral(parentForm.Controls, cajas);
            }
        }

        private void CambiarTextoBotones(Control.ControlCollection controls, Color color)
        {
            foreach (Control control in controls)
            {
                if (control is Label || control is CheckBox || control is RadioButton)
                {
                    control.ForeColor = color;
                }

                if (control.HasChildren)
                {
                    CambiarTextoBotones(control.Controls, color);
                }
            }
        }

        private void CambiarColorBarraLateral(Control.ControlCollection controls, Color color)
        {
            foreach (Control control in controls)
            {
                if (control is BarraLateral || control is RoundGroupBox)
                {
                    control.BackColor = color;
                }

                if (control.HasChildren)
                {
                    CambiarColorBarraLateral(control.Controls, color);
                }
            }
        }
        #endregion
    }
}

