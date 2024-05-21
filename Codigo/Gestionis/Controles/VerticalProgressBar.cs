namespace Gestionis.Controles
{
    public class VerticalProgressBar : ProgressBar
    {
        public VerticalProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                g.Clear(this.BackColor);

                float percentage = (float)this.Value / this.Maximum;
                int height = (int)(this.ClientSize.Height * percentage);

                Rectangle rect = new Rectangle(0, this.ClientSize.Height - height, this.ClientSize.Width, height);
                using (Brush brush = new SolidBrush(this.ForeColor))
                {
                    g.FillRectangle(brush, rect);
                }

                using (Pen pen = new Pen(this.ForeColor))
                {
                    g.DrawRectangle(pen, 0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                }
            }
        }
    }
}
