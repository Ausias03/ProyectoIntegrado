using System.Drawing.Drawing2D;

namespace Gestionis
{
    public class RoundGroupBox : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Brush brush = new SolidBrush(Color.FromArgb(233, 236, 239)))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

            DrawRoundedGroupBox(e.Graphics, this.ClientRectangle, Color.Black, Color.FromArgb(205, 213, 221), 10);
        }

        private void DrawRoundedGroupBox(Graphics g, Rectangle rectangle, Color borderColor, Color backColor, int cornerRadius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                // Create a rounded rectangle path
                path.AddArc(rectangle.X, rectangle.Y, cornerRadius * 6, cornerRadius * 6, 180, 90);
                path.AddArc(rectangle.Width - (cornerRadius * 6), rectangle.Y, cornerRadius * 6, cornerRadius * 6, 270, 90);
                path.AddArc(rectangle.Width - (cornerRadius * 6), rectangle.Height - (cornerRadius * 6), cornerRadius * 6, cornerRadius * 6, 0, 90);
                path.AddArc(rectangle.X, rectangle.Height - (cornerRadius * 6), cornerRadius * 6, cornerRadius * 6, 90, 90);
                path.CloseFigure();

                // Fill the rounded rectangle with background color
                using (Brush brush = new SolidBrush(backColor))
                {
                    g.FillPath(brush, path);
                }

                // Draw the rounded rectangle border
                //using (Pen pen = new Pen(borderColor, 1.0f))
                //{
                //    g.DrawPath(pen, path);
                //}
            }
        }
    }
}
