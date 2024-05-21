using Gestionis.Clases;
using System.Drawing.Drawing2D;

namespace Gestionis.Herramientas
{
    public class RoundGroupBox : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Color fondo;
            Color groupbox;

            base.OnPaint(e);
            
            if (Sesion.Instance.TemaOscuro)
            {
                fondo = Color.FromArgb(22, 22, 22);
                groupbox = Color.FromArgb(0, 115, 148);
            }
            else
            {
                fondo = Color.FromArgb(233, 236, 239);
                groupbox = Color.FromArgb(205, 213, 221);
            }

            using (Brush brush = new SolidBrush(fondo))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

            DrawRoundedGroupBox(e.Graphics, ClientRectangle, groupbox, 10);
        }

        private void DrawRoundedGroupBox(Graphics g, Rectangle rectangle, Color backColor, int cornerRadius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rectangle.X, rectangle.Y, cornerRadius * 6, cornerRadius * 6, 180, 90);
                path.AddArc(rectangle.Width - cornerRadius * 6, rectangle.Y, cornerRadius * 6, cornerRadius * 6, 270, 90);
                path.AddArc(rectangle.Width - cornerRadius * 6, rectangle.Height - cornerRadius * 6, cornerRadius * 6, cornerRadius * 6, 0, 90);
                path.AddArc(rectangle.X, rectangle.Height - cornerRadius * 6, cornerRadius * 6, cornerRadius * 6, 90, 90);
                path.CloseFigure();

                using (Brush brush = new SolidBrush(backColor))
                {
                    g.FillPath(brush, path);
                }
            }
        }
    }
}
