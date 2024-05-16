namespace Gestionis.Herramientas
{
    public class BarraLateral : FlowLayoutPanel
    {
        private static bool barraLateralExpandida = true;
        private static System.Windows.Forms.Timer transicionBarraLateral;

        public BarraLateral()
        {
            InitializePanelProperties();
            CreateButtons();
            AjustesTimer();
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
            CreateButton("Ahorros", Properties.Resources.ahorro, typeof(frmTablaClasificación));
            CreateButton("Deudas", Properties.Resources.deuda, typeof(FrmGestorDeudas));
            CreateButton("Patrimonio", Properties.Resources.patrimonio, typeof(frmTablaClasificación));
            CreateButton("Notas", Properties.Resources.notas, typeof(frmTablaClasificación));
            CreateButton("Clasificación", Properties.Resources.calsificacion, typeof(frmTablaClasificación));
            CreateButton("Historial", Properties.Resources.historial, typeof(frmHistorial));
            CreateButton("Notif.", Properties.Resources.notificacion, typeof(frmTablaClasificación));
            CreateButton("Página Web", Properties.Resources.web, typeof(frmTablaClasificación));
            CreateButton("Ayuda", Properties.Resources.ayuda, typeof(frmTablaClasificación));
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
            if (barraLateralExpandida)
            {
                Width -= 10;
                if (Width <= 65)
                {
                    barraLateralExpandida = false;
                    transicionBarraLateral.Stop();
                }
            }
            else
            {
                Width += 10;
                if (Width >= 231)
                {
                    barraLateralExpandida = true;
                    transicionBarraLateral.Stop();
                }
            }
        }

        private void CerrarAbrirFrm(Type formType)
        {
            Form frmActual = FindForm();
            if (frmActual != null)
            {
                frmActual.Hide();
                Form form = (Form)Activator.CreateInstance(formType);
                form.Closed += (s, args) => frmActual.Close();
                form.Show();
            }
        }

        static public bool ColapsarExpandir(object sender, EventArgs e)
        {
            transicionBarraLateral.Start();
            return barraLateralExpandida;
        }
    }
}
