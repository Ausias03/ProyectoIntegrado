using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gestionis
{
    public partial class frmTablaClasificación : Form
    {
        public frmTablaClasificación()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void pnlBarra_Paint(object sender, PaintEventArgs e)
        //{
        //    pbHamburger.Image = Properties.Resources.hamburger.ToBitmap();
        //    pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;

        //    pbAyuda.Image = Properties.Resources.question.ToBitmap();
        //    pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;

        //    pbEnglish.Image = Properties.Resources.england.ToBitmap();
        //    pbEnglish.SizeMode = PictureBoxSizeMode.StretchImage;

        //    pbSpain.Image = Properties.Resources.eapanya.ToBitmap();
        //    pbSpain.SizeMode = PictureBoxSizeMode.StretchImage;

        //    p.Image = Properties.Resources.newspaper.ToBitmap();
        //    p.SizeMode = PictureBoxSizeMode.StretchImage;

        //    a.Image = Properties.Resources.bell.ToBitmap();
        //    a.SizeMode = PictureBoxSizeMode.StretchImage;

        //    u.Image = Properties.Resources.user.ToBitmap();
        //    u.SizeMode = PictureBoxSizeMode.StretchImage;

        //    pbTema.Image = Properties.Resources.dark.ToBitmap();
        //    pbTema.SizeMode = PictureBoxSizeMode.StretchImage;
        //}
    }
}