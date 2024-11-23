using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

public static class EstilosGlobales
{
    public static void AplicarEstilosFormulario(Form formulario)
    {
        if (formulario is ClubDeportivo_DSOO_PI.frmLogin)
        {
            // Carga la imagen de la carpeta "Assets"
            formulario.BackgroundImage = Image.FromFile("Assets/FondoLogin.jpg");
            formulario.BackgroundImageLayout = ImageLayout.Stretch;
        }
        else
        {
            formulario.BackColor = ColorTranslator.FromHtml("#EBF5FB"); // Fondo liso para otros formularios
        }
        AplicarEstilosRecursivos(formulario.Controls);
    }


    private static void AplicarEstilosRecursivos(Control.ControlCollection controls)
    {
        foreach (Control control in controls)
        {
            if (control is Button btn)
            {
                btn.BackColor = ColorTranslator.FromHtml("#01579B"); // Azul oscuro
                btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF"); // Blanco
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                // Botones redondeados
                btn.Paint += (s, e) =>
                {
                    Graphics graphics = e.Graphics;
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
                    GraphicsPath path = new GraphicsPath();
                    path.AddArc(rect.X, rect.Y, 20, 20, 180, 90);
                    path.AddArc(rect.X + rect.Width - 20, rect.Y, 20, 20, 270, 90);
                    path.AddArc(rect.X + rect.Width - 20, rect.Y + rect.Height - 20, 20, 20, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - 20, 20, 20, 90, 90);
                    path.CloseAllFigures();

                    btn.Region = new Region(path);
                };
            }
            else if (control is Label lbl)
            {
                // Fondo transparente para los labels
                lbl.BackColor = Color.Transparent;

                if (lbl.Tag != null)
                {
                    if (lbl.Tag.ToString() == "tituloPpal")
                    {
                        lbl.Font = new Font("Segoe UI", 24, FontStyle.Bold);
                        lbl.ForeColor = ColorTranslator.FromHtml("#222222"); // Azul oscuro
                    }
                    else if (lbl.Tag.ToString() == "tituloForm")
                    {
                        lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                        lbl.ForeColor = ColorTranslator.FromHtml("#3D8A33"); // Verde más oscuro
                    }

                    else if (lbl.Tag.ToString() == "tituloMenu")
                    {
                        lbl.Font = new Font("Segoe UI", 22, FontStyle.Bold);
                        lbl.ForeColor = ColorTranslator.FromHtml("#3D8A33"); // Verde más oscuro
                    }
                }
                else
                {
                    lbl.ForeColor = ColorTranslator.FromHtml("#222222"); // Gris oscuro
                    lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
            }
            else if (control is PictureBox pb)
            {
                // Fondo transparente para el PictureBox
                pb.BackColor = Color.Transparent;
            }
            else if (control is TextBox txt)
            {
                // Configurar el TextBox
                txt.BorderStyle = BorderStyle.None; // Sin bordes
                txt.BackColor = Color.White; // Fondo blanco
                txt.ForeColor = Color.FromArgb(51, 51, 51); // Negro suave

                // Evento Paint para dibujar la sombra
                txt.Parent.Paint += (s, e) =>
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        // Crear rectángulo para la sombra
                        Rectangle rect = txt.Bounds;
                        rect.Inflate(1, 1); // Expande el área para la sombra

                        // Crear un rectángulo redondeado
                        int radius = 10;
                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                        path.CloseAllFigures();

                        // Dibujar la sombra
                        using (SolidBrush brush = new SolidBrush(Color.LightGray))
                        {
                            e.Graphics.FillPath(brush, path);
                        }
                    }
                };
            }
            else if (control is Panel pnl)
            {
                // Verificar el Tag del panel para aplicar diferentes estilos
                if (pnl.Tag != null && pnl.Tag.ToString() == "panel1")
                {
                    try
                    {
                        // Intentar cargar la imagen de fondo
                        pnl.BackgroundImage = Image.FromFile("Assets/FondoLogin.jpg"); // Ruta a la imagen
                        pnl.BackgroundImageLayout = ImageLayout.Stretch; // Ajustar la imagen al tamaño del panel
                    }
                    catch (FileNotFoundException)
                    {
                        // Si no se encuentra la imagen, asignar un color celeste claro como fondo
                        pnl.BackgroundImage = null; // Elimina cualquier fondo previo
                        pnl.BackColor = Color.FromArgb(173, 216, 230); // Color celeste claro
                        MessageBox.Show(
                            "La imagen de fondo no fue encontrada. Se aplicará un color de fondo predeterminado.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                else
                {
                    // Fondo predeterminado para otros paneles
                    pnl.BackColor = Color.FromArgb(245, 245, 245); // Gris claro
                }
            }
            else if (control is DataGridView dgv)
            {
                // Fondo general del control
                dgv.BackgroundColor = ColorTranslator.FromHtml("#EBF5FB"); // Celeste claro

                // Estilo de las celdas
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // Gris claro para celdas
                dgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#222222"); // Gris oscuro para texto
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // Alternar filas con blanco puro
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#222222");

                // Estilo de los encabezados
                dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01579B"); // Azul oscuro
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto blanco
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                // Bordes
                dgv.GridColor = Color.LightGray; // Gris claro para las líneas de la grilla

                // Deshabilitar el estilo visual predeterminado
                dgv.EnableHeadersVisualStyles = false;

                // Opcional: Ajustar el alto de las filas y encabezados para mejor visibilidad
                dgv.RowTemplate.Height = 30;
                dgv.ColumnHeadersHeight = 35;
            }

            // Recursividad: aplicar estilos a los hijos
            if (control.HasChildren)
            {
                AplicarEstilosRecursivos(control.Controls);
            }
        }
    }
}
