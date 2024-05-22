using Gestionis.Clases;
using Gestionis.Formularios;

namespace Gestionis.Herramientas
{
    public class BarraLateral : FlowLayoutPanel
    {
        private static System.Windows.Forms.Timer transicionBarraLateral;

        public Button BtnInicio { get; private set; }
        public Button BtnInversiones { get; private set; }
        public Button BtnAhorros { get; private set; }
        public Button BtnDeudas { get; private set; }
        public Button BtnPatrimonio { get; private set; }
        public Button BtnNotas { get; private set; }
        public Button BtnClasificacion { get; private set; }
        public Button BtnHistorial { get; private set; }
        public Button BtnNotificaciones { get; private set; }
        public Button BtnPaginaWeb { get; private set; }

        public BarraLateral()
        {
            InitializePanelProperties();
            CreateButtons();
            AjustesTimer();
            Load();
            CheckUserLevel();
        }

        public void Load()
        {
            if (!Sesion.Instance.BarraExpandida)
            {
                Width = 65;
            }
            else
            {
                Width = 231;
            }

            AplicarIdiomas();
        }

        private void InitializePanelProperties()
        {
            Size = new Size(231, 967);
            Dock = DockStyle.Left;
            BackColor = Color.FromArgb(205, 213, 221);
        }

        private void CreateButtons()
        {
            BtnInicio = CreateButton("Inicio", Properties.Resources.inicio, typeof(FrmMenuPrincipal));
            BtnInversiones = CreateButton("Inversiones", Properties.Resources.inversiones, typeof(frmTablaClasificación));
            BtnAhorros = CreateButton("Ahorros", Properties.Resources.ahorro, typeof(frmMetodosAhorro));
            BtnDeudas = CreateButton("Deudas", Properties.Resources.deuda, typeof(FrmGestorDeudas));
            BtnPatrimonio = CreateButton("Patrimonio", Properties.Resources.patrimonio, typeof(frmTablaClasificación));
            BtnNotas = CreateButton("Notas", Properties.Resources.notas, typeof(frmNotas));
            BtnClasificacion = CreateButton("Clasificación", Properties.Resources.calsificacion, typeof(frmTablaClasificación));
            BtnHistorial = CreateButton("Historial", Properties.Resources.historial, typeof(frmHistorial));
            BtnNotificaciones = CreateButton("Modif. Notif.", Properties.Resources.notificacion, typeof(FrmModifNotif));
            BtnPaginaWeb = CreateButton("Página Web", Properties.Resources.web, typeof(frmTablaClasificación));
        }

        private Button CreateButton(string text, Image image, Type formType)
        {
            Button button = new Button
            {
                Text = text,
                Image = image,
                ImageAlign = ContentAlignment.MiddleLeft,
                Font = new Font(FontFamily.GenericSansSerif, 14),
                Size = new Size(255, 69),
                Padding = new Padding(5),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            button.Click += (sender, e) => CerrarAbrirFrm(formType);
            Controls.Add(button);
            return button;
        }

        private void AjustesTimer()
        {
            transicionBarraLateral = new System.Windows.Forms.Timer
            {
                Interval = 10
            };
            transicionBarraLateral.Tick += TransicionBarraLateral_Tick;
        }

        private void TransicionBarraLateral_Tick(object sender, EventArgs e)
        {
            if (Sesion.Instance.BarraExpandida)
            {
                Width -= 10;
                if (Width <= 65)
                {
                    Sesion.Instance.BarraExpandida = false;
                    transicionBarraLateral.Stop();
                }
            }
            else
            {
                Width += 10;
                if (Width >= 231)
                {
                    Sesion.Instance.BarraExpandida = true;
                    transicionBarraLateral.Stop();
                }
            }
        }

        private void CerrarAbrirFrm(Type formType)
        {
            Form form = (Form)Activator.CreateInstance(formType);
            if (form.GetType() == typeof(FrmModifNotif))
            {
                form.ShowDialog();
            }
            else
            {
                Form frmActual = FindForm();
                if (frmActual != null)
                {
                    frmActual.Hide();
                    form.Closed += (s, args) => frmActual.Close();
                    form.Show();
                }
            }
        }

        public static bool ColapsarExpandir()
        {
            transicionBarraLateral.Start();
            return Sesion.Instance.BarraExpandida;
        }

        public void AplicarIdiomas()
        {
            BtnInicio.Text = Resources.Idiomas.StringRecursosLateral.btnInicio;
            BtnInversiones.Text = Resources.Idiomas.StringRecursosLateral.btnInversiones;
            BtnAhorros.Text = Resources.Idiomas.StringRecursosLateral.btnAhorros;
            BtnDeudas.Text = Resources.Idiomas.StringRecursosLateral.btnDeudas;
            BtnPatrimonio.Text = Resources.Idiomas.StringRecursosLateral.btnPatriono;
            BtnNotas.Text = Resources.Idiomas.StringRecursosLateral.btnNotas;
            BtnClasificacion.Text = Resources.Idiomas.StringRecursosLateral.btnClasificacion;
            BtnHistorial.Text = Resources.Idiomas.StringRecursosLateral.btnHistorial;
            BtnNotificaciones.Text = Resources.Idiomas.StringRecursosLateral.btnNotif;
            BtnPaginaWeb.Text = Resources.Idiomas.StringRecursosLateral.btnWeb;
        }

        private void CheckUserLevel()
        {
            int nivel = SistemaNiveles.GetNivel(Sesion.Instance.ApodoUsuario);

            if (nivel < 3)
            {
                BtnClasificacion.Enabled = false;
            }
            else
            {
                BtnClasificacion.Enabled = true;
            }

            if (nivel < 5)
            {
                BtnInversiones.Enabled = false;
                BtnPatrimonio.Enabled = false;
            }
            else
            {
                BtnInversiones.Enabled = true;
                BtnPatrimonio.Enabled = true;
            }
        }
    }
}
