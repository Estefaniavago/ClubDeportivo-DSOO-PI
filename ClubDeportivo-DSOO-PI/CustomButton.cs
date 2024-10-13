using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        // Dibuja la sombra
        Graphics g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // Sombra negra (con un poco de transparencia)
        Color shadowColor = Color.FromArgb(100, 0, 0, 0);
        using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
        {
            g.FillRectangle(shadowBrush, new Rectangle(5, 5, Width, Height));
        }

        // Dibuja el fondo del botón
        using (SolidBrush buttonBrush = new SolidBrush(this.BackColor))
        {
            g.FillRectangle(buttonBrush, 0, 0, Width, Height);
        }

        // Dibuja el texto
        TextRenderer.DrawText(g, this.Text, this.Font, new Point(10, 10), this.ForeColor);

        // Dibuja la región redondeada
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, 20, 20, 180, 90);
        path.AddArc(Width - 20, 0, 20, 20, 270, 90);
        path.AddArc(Width - 20, Height - 20, 20, 20, 0, 90);
        path.AddArc(0, Height - 20, 20, 20, 90, 90);
        this.Region = new Region(path);

        base.OnPaint(pevent);
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // Evita que se dibuje el fondo predeterminado
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        this.BackColor =  Color.FromArgb(255, 100, 150); // Cambia el color de fondo en hover
        base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        this.BackColor = Color.FromArgb(12, 57, 80); // Vuelve al color original
        base.OnMouseLeave(e);
    }
}