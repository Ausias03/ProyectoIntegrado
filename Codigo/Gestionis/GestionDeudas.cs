using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrado
{
    public partial class frmGestionDeudas : Form
    {
        public frmGestionDeudas()
        {
            InitializeComponent();
            chart1.Titles.Add("RESUMEN TOTAL");
        }

        private void btnActualizarDato_Click(object sender, EventArgs e)
        {
            chart1.Series["Medeben"].Points.AddXY(1, 2);
            chart1.Series["Debo"].Points.AddXY(2, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
