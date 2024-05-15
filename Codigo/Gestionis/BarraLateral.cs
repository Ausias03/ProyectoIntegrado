using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionis
{
    public class BarraLateral : FlowLayoutPanel
    {
        private bool barraLateralExpandida = true;
        static private System.Windows.Forms.Timer transicionBarraLateral; // Specify System.Windows.Forms.Timer

        public BarraLateral()
        {
            InitializePanelProperties();
            CreateButtons();
            InitializeSidebarTransition();
        }

        private void InitializePanelProperties()
        {
            this.Size = new Size(265, 967);
            this.Dock = DockStyle.Left;
            this.BackColor = Color.FromArgb(205, 213, 221);
        }

        private void CreateButtons()
        {
            // Create buttons
            CreateButton("Inicio", Properties.Resources.inicio);
            CreateButton("Inversiones", Properties.Resources.inversiones);
            CreateButton("Ahorros", Properties.Resources.ahorro);
            CreateButton("Deudas", Properties.Resources.deuda);
            CreateButton("Patrimonio", Properties.Resources.patrimonio);
            CreateButton("Notas", Properties.Resources.notas);
            CreateButton("Clasificación", Properties.Resources.calsificacion);
            CreateButton("Historial", Properties.Resources.historial);
            CreateButton("Notif.", Properties.Resources.notificacion);
            CreateButton("Página Web", Properties.Resources.web);
            CreateButton("Ayuda", Properties.Resources.ayuda);
        }

        private void CreateButton(string text, Image image)
        {
            Button button = new Button();
            button.Text = text;
            button.Image = image;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Font = new Font(button.Font.FontFamily, 14); // Set font size to 14
            button.Size = new Size(255, 69); // Set button size
            button.Padding = new Padding(5);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            this.Controls.Add(button);
        }

        private void InitializeSidebarTransition()
        {
            transicionBarraLateral = new System.Windows.Forms.Timer(); // Use System.Windows.Forms.Timer
            transicionBarraLateral.Interval = 10;
            transicionBarraLateral.Tick += transicionBarraLateral_Tick;
        }

        private void transicionBarraLateral_Tick(object sender, EventArgs e)
        {
            if (barraLateralExpandida)
            {
                this.Width -= 10;
                if (this.Width <= 65)
                {
                    barraLateralExpandida = false;
                    transicionBarraLateral.Stop();
                }
            }
            else
            {
                this.Width += 10;
                if (this.Width >= 231)
                {
                    barraLateralExpandida = true;
                    transicionBarraLateral.Stop();
                }
            }
        }
        public static void ColapsarExpandir(object sender, EventArgs e)
        {
            transicionBarraLateral.Start();
        }
    }
}
