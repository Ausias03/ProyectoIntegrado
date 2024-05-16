namespace Gestionis.Herramientas
{
    public class BarraSecundaria : Panel
    {
        private Button btnHamburger;
        private Button btnAyuda;
        private Button btnLanguage;
        private Button btnNoticias;
        private Button btnNotificaciones;
        private Button btnUsuario;
        private Button btnTema;

        public BarraSecundaria()
        {
            InitializePanelProperties();
            CreateButtons();
        }

        private void InitializePanelProperties()
        {
            this.Dock = DockStyle.Top;
            this.Size = new Size(Width, 35);
            this.BackColor = Color.FromArgb(211, 208, 242);
        }

        private void CreateButtons()
        {
            btnHamburger = CreateButton(Properties.Resources.hamburgerUp, "Hamburger");
            btnAyuda = CreateButton(Properties.Resources.ayuda, "Ayuda");
            btnLanguage = CreateButton(Properties.Resources.england, "Language");
            btnNoticias = CreateButton(Properties.Resources.news, "Noticias");
            btnNotificaciones = CreateButton(Properties.Resources.notif, "Notificaciones");
            btnUsuario = CreateButton(Properties.Resources.user, "Usuario");
            btnTema = CreateButton(Properties.Resources.darkTheme, "Tema");

            btnNoticias.Dock = DockStyle.Right;
            btnNotificaciones.Dock = DockStyle.Right;
            btnUsuario.Dock = DockStyle.Right;

            btnAyuda.Dock = DockStyle.Left;
            btnTema.Dock = DockStyle.Left;
            btnLanguage.Dock = DockStyle.Left;
            btnHamburger.Dock = DockStyle.Left;


            Controls.AddRange(new Control[] { btnTema, btnNoticias, btnNotificaciones, btnUsuario, btnLanguage, btnAyuda, btnHamburger });
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
                        btnHamburger.Image = BarraLateral.ColapsarExpandir(sender, e) ? Properties.Resources.hamburgerLeft : Properties.Resources.hamburgerUp;
                        break;
                    case "btnAyuda":

                        break;
                    case "btnLanguage":

                        break;
                    case "btnNoticias":

                        break;
                    case "btnNotificaciones":

                        break;
                    case "btnUsuario":
                        Form frmActual = FindForm();
                        frmActual.Hide();
                        frmUsuario frmUsuario = new frmUsuario();
                        frmUsuario.Closed += (s, args) => frmActual.Close();
                        frmUsuario.Show();
                        BarraLateral.ColapsarExpandir(sender, e);
                        break;
                    case "btnTema":

                        break;
                }
            }
        }
    }
}

