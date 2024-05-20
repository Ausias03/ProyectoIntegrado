using Gestionis.Clases;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionis
{
    public partial class FrmNotificaciones : Form
    {
        private FlowLayoutPanel flpNotificaciones;
        private Panel panelContainer;
        private Label lblTitulo;
        private Button btnVolver;

        public FrmNotificaciones()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Initialize the title label
            lblTitulo = new Label();
            lblTitulo.Text = "Notificaciones";
            lblTitulo.Font = new Font("Arial", 24, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(211, 208, 242);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Height = 50;

            // Initialize the Volver button
            btnVolver = new Button();
            btnVolver.Text = "Volver";
            btnVolver.Font = new Font("Arial", 12, FontStyle.Bold);
            btnVolver.BackColor = Color.FromArgb(211, 208, 242);
            btnVolver.Dock = DockStyle.Bottom;
            btnVolver.Height = 40;
            btnVolver.Click += btnVolver_Click;

            // Initialize the container panel
            panelContainer = new Panel();
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.AutoScroll = true;

            // Initialize the FlowLayoutPanel
            flpNotificaciones = new FlowLayoutPanel();
            flpNotificaciones.Dock = DockStyle.Top;
            flpNotificaciones.AutoSize = true;
            flpNotificaciones.FlowDirection = FlowDirection.TopDown;
            flpNotificaciones.WrapContents = false;

            // Add the FlowLayoutPanel to the container panel
            panelContainer.Controls.Add(flpNotificaciones);

            // Add the controls to the form
            this.Controls.Add(panelContainer);
            this.Controls.Add(btnVolver);
            this.Controls.Add(lblTitulo);

            // Ensure the form itself can accommodate the controls and the scrollbar
            this.Size = new Size(450, 600); // Adjust the size as needed
        }

        private void FrmNotificaciones_Load(object sender, EventArgs e)
        {
            CargaNotificaciones();
        }

        private void CargaNotificaciones()
        {
            try
            {
                List<Notificacion> notificaciones = Notificacion.GetAllNotificaciones(Sesion.Instance.NumCuenta);

                if (!notificaciones.Any())
                {
                    AddPanel("No hay notificaciones que mostrar");
                }
                else
                {
                    foreach (Notificacion noti in notificaciones)
                    {
                        AddPanel(noti);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPanel(Notificacion noti)
        {
            // Convertir el color de fondo de string a Color
            Color bgColor = Color.FromArgb(-36238);

            // Crear el panel principal de la notificación
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = bgColor;
            panel.Padding = new Padding(10);
            panel.Margin = new Padding(10);
            panel.Size = new Size(400, 100);

            // Crear el label para el título
            Label lblTitulo = new Label();
            lblTitulo.Text = noti.Titulo;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font(lblTitulo.Font, FontStyle.Bold);
            lblTitulo.Location = new Point(10, 10);

            // Crear el label para la recomendación
            Label lblRecomendacion = new Label();
            lblRecomendacion.Text = noti.Recomendacion;
            lblRecomendacion.AutoSize = true;
            lblRecomendacion.Location = new Point(10, 40);

            // Crear el panel para la descripción
            Panel panelDescripcion = new Panel();
            panelDescripcion.BackColor = ColorTranslator.FromHtml("#D9FFD8");
            panelDescripcion.BorderStyle = BorderStyle.FixedSingle;
            panelDescripcion.Size = new Size(120, 70);
            panelDescripcion.Location = new Point(250, 10);

            // Crear el label para la descripción dentro del panel de descripción
            Label lblDescripcion = new Label();
            lblDescripcion.Text = noti.Descripcion;
            lblDescripcion.AutoSize = false; // Set AutoSize to false
            lblDescripcion.Size = new Size(100, 40); // Adjust the size to fit within the panel
            lblDescripcion.Location = new Point(10, 15); // Adjust the location to fit within the panel
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            lblDescripcion.Font = new Font(lblDescripcion.Font, FontStyle.Bold);

            // Agregar el label de descripción al panel de descripción
            panelDescripcion.Controls.Add(lblDescripcion);

            // Agregar los labels y el panel de descripción al panel principal
            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(lblRecomendacion);
            panel.Controls.Add(panelDescripcion);

            // Agregar el panel principal al FlowLayoutPanel
            flpNotificaciones.Controls.Add(panel);
        }

        private void AddPanel(string texto)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Padding = new Padding(10);
            panel.BackColor = Color.LightGray;
            panel.Size = new Size(400, 100);

            Label lblMensaje = new Label();
            lblMensaje.Text = texto;
            lblMensaje.Font = new Font("Arial", 16, FontStyle.Bold);
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(lblMensaje);

            flpNotificaciones.Controls.Add(panel);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
