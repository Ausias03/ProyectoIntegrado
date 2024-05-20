using Gestionis.Clases;

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

            lblTitulo = new Label();
            lblTitulo.Text = "Notificaciones";
            lblTitulo.Font = new Font("Arial", 24, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 115, 148);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Height = 50;

            btnVolver = new Button();
            btnVolver.Text = "Volver";
            btnVolver.Font = new Font("Arial", 12, FontStyle.Bold);
            btnVolver.BackColor = Color.FromArgb(211, 208, 242);
            btnVolver.Dock = DockStyle.Bottom;
            btnVolver.Height = 40;
            btnVolver.Click += btnVolver_Click;

            panelContainer = new Panel();
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.AutoScroll = true;

            flpNotificaciones = new FlowLayoutPanel();
            flpNotificaciones.Dock = DockStyle.Top;
            flpNotificaciones.AutoSize = true;
            flpNotificaciones.FlowDirection = FlowDirection.TopDown;
            flpNotificaciones.WrapContents = false;

            panelContainer.Controls.Add(flpNotificaciones);

            this.Controls.Add(panelContainer);
            this.Controls.Add(btnVolver);
            this.Controls.Add(lblTitulo);

            this.Size = new Size(450, 600);
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
            Color bgColor = Color.FromArgb(-36238);

            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = bgColor;
            panel.Padding = new Padding(10);
            panel.Margin = new Padding(10);
            panel.Size = new Size(400, 100);

            Label lblTitulo = new Label();
            lblTitulo.Text = noti.Titulo;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font(lblTitulo.Font, FontStyle.Bold);
            lblTitulo.Location = new Point(10, 10);

            Label lblRecomendacion = new Label();
            lblRecomendacion.Text = noti.Recomendacion;
            lblRecomendacion.AutoSize = false;
            lblRecomendacion.Location = new Point(10, 40);
            lblRecomendacion.Size = new Size(250, 40);

            Panel panelDescripcion = new Panel();
            panelDescripcion.BackColor = ColorTranslator.FromHtml("#D9FFD8");
            panelDescripcion.BorderStyle = BorderStyle.FixedSingle;
            panelDescripcion.Size = new Size(120, 70);
            panelDescripcion.Location = new Point(265, 10);

            Label lblDescripcion = new Label();
            lblDescripcion.Text = noti.Descripcion;
            lblDescripcion.AutoSize = false;
            lblDescripcion.Size = new Size(100, 40);
            lblDescripcion.Location = new Point(10, 15);
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            lblDescripcion.Font = new Font(lblDescripcion.Font, FontStyle.Bold);

            panelDescripcion.Controls.Add(lblDescripcion);

            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(lblRecomendacion);
            panel.Controls.Add(panelDescripcion);

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
