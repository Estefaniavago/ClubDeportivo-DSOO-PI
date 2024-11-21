using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; // Necesario para LinearGradientBrush
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class ModalVistaCarnet : Form
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string fechavencimiento;

        public ModalVistaCarnet(string nombre, string apellido, string dni, string fechavencimiento)
        {
            InitializeComponent();

            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechavencimiento = fechavencimiento;

            GenerarVistaPrevia();
        }

        private void GenerarVistaPrevia()
        {
            Bitmap carnet = new Bitmap(pbVistaPrevia.Width, pbVistaPrevia.Height);
            using (Graphics g = Graphics.FromImage(carnet))
            {
                // **1. Fondo con degradado vertical**
                using (LinearGradientBrush gradiente = new LinearGradientBrush(
                    new Rectangle(0, 0, carnet.Width, carnet.Height),
                    Color.LightBlue, // Color inicial
                    Color.White,     // Color final
                    LinearGradientMode.Vertical)) // Dirección del degradado
                {
                    g.FillRectangle(gradiente, 0, 0, carnet.Width, carnet.Height);
                }

                // **2. Dibujar borde decorativo**
                Pen borderPen = new Pen(Color.DarkBlue, 3);
                g.DrawRectangle(borderPen, 0, 0, carnet.Width - 1, carnet.Height - 1);

                // **3. Agregar logo**
                try
                {
                    Image logo = Image.FromFile("./Assets/fitmoveRecurso 2@3x.png");
                    g.DrawImage(logo, 10, 10, 80, 80);
                }
                catch
                {
                    g.DrawString("LOGO", new Font("Arial", 10, FontStyle.Bold), Brushes.Gray, new PointF(10, 10));
                }

                // **4. Título estilizado y centrado**
                Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold);

                // Calcular posición centrada para el título
                string titulo = "CARNET DE SOCIO";
                SizeF tituloSize = g.MeasureString(titulo, titleFont);
                float tituloX = (carnet.Width - tituloSize.Width) / 2; // Centrar horizontalmente
                g.DrawString(titulo, titleFont, Brushes.DarkBlue, new PointF(tituloX, 20));

                // **5. Información del socio con diseño**
                Font infoFont = new Font("Segoe UI", 12);
                g.DrawString($"Nombre: {nombre}", infoFont, Brushes.Black, new PointF(20, 110));
                g.DrawString($"Apellido: {apellido}", infoFont, Brushes.Black, new PointF(20, 140));
                g.DrawString($"DNI: {dni}", infoFont, Brushes.Black, new PointF(20, 170));
                g.DrawString($"Válido hasta: {fechavencimiento}", infoFont, Brushes.Black, new PointF(20, 200));

                // **6. Agregar firma o marcador para firma**
                try
                {
                    Image firma = Image.FromFile("./Assets/firma.png");
                    g.DrawImage(firma, 250, 250, 120, 50);
                }
                catch
                {
                    g.DrawString("FIRMA", new Font("Segoe UI", 10, FontStyle.Italic), Brushes.Gray, new PointF(250, 250));
                }
            }

            pbVistaPrevia.Image = carnet;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += ImprimirCarnet;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void ImprimirCarnet(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pbVistaPrevia.Image, 100, 100);
        }
    }
}
