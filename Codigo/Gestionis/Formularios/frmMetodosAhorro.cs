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
    public partial class frmMetodosAhorro : Form
    {
        public frmMetodosAhorro()
        {
            InitializeComponent();
        }

        private void MetodosAhorro_Load(object sender, EventArgs e)
        {
            pbArrow.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow2.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow2.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow3.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow3.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow4.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow4.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow5.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow5.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow6.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow6.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow7.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow7.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow8.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow8.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow9.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow9.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow10.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow10.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow11.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow11.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        private void btn503020_Click(object sender, EventArgs e)
        {
            pnl503020.Visible = true;
            pnlPersonalizado.Visible = false;
            btnPAgregar.Visible = false;
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            pnl503020.Visible = false;
            //foreach (Control control in pnl503020.Controls)
            //{
            //    if (control is Label || control is PictureBox)
            //    {
            //        control.Visible = false;
            //    }
            //}
            pnlPersonalizado.Visible = true;
            btnPAgregar.Visible=true;
        }
    }
}
