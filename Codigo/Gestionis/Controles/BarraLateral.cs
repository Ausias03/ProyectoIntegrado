using Gestionis.Clases;

namespace Gestionis.Herramientas
{
    public class BarraLateral : FlowLayoutPanel
    {

        private static System.Windows.Forms.Timer transicionBarraLateral;

        public BarraLateral()
        {
            InitializePanelProperties();
            CreateButtons();
            AjustesTimer();
            Load();
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
            CreateButton("Inicio", Properties.Resources.inicio, typeof(FrmMenuPrincipal));
            CreateButton("Inversiones", Properties.Resources.inversiones, typeof(frmTablaClasificación));
            CreateButton("Ahorros", Properties.Resources.ahorro, typeof(frmMetodosAhorro));
            CreateButton("Deudas", Properties.Resources.deuda, typeof(FrmGestorDeudas));
            CreateButton("Patrimonio", Properties.Resources.patrimonio, typeof(frmTablaClasificación));
            CreateButton("Notas", Properties.Resources.notas, typeof(frmNotas));
            CreateButton("Clasificación", Properties.Resources.calsificacion, typeof(frmTablaClasificación));
            CreateButton("Historial", Properties.Resources.historial, typeof(frmHistorial));
            CreateButton("Notif.", Properties.Resources.notificacion, typeof(FrmNotificaciones));
            CreateButton("Página Web", Properties.Resources.web, typeof(frmTablaClasificación));
        }

        private void CreateButton(string text, Image image, Type formType)
        {
            Button button = new Button();
            button.Text = text;
            button.Image = image;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Font = new Font(button.Font.FontFamily, 14);
            button.Size = new Size(255, 69);
            button.Padding = new Padding(5);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Click += (sender, e) => CerrarAbrirFrm(formType);
            Controls.Add(button);
        }

        private void AjustesTimer()
        {
            transicionBarraLateral = new System.Windows.Forms.Timer();
            transicionBarraLateral.Interval = 10;
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
            if (form.GetType() == typeof(FrmNotificaciones))
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
            if (Sesion.Instance.Espanyol)
            {
                //MessageBox.Show("Hola");
            }
            else
            {
                //MessageBox.Show("Hello");
            }
        }
    }
}
