using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                g.Clear(Color.White);

                // Dibujar borde
                Pen borderPen = new Pen(Color.Black, 2);
                g.DrawRectangle(borderPen, 0, 0, carnet.Width - 1, carnet.Height - 1);

                // Agregar logo
                try
                {
                    Image logo = Image.FromFile("./Assets/fitmoveRecurso 2@3x.png");
                    g.DrawImage(logo, 10, 10, 80, 80);
                }
                catch
                {
                    g.DrawString("LOGO", new Font("Arial", 10, FontStyle.Bold), Brushes.Gray, new PointF(10, 10));
                }

                // Título
                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                g.DrawString("CARNET DE SOCIO", titleFont, Brushes.Black, new PointF(100, 10));

                // Información del socio
                Font infoFont = new Font("Arial", 12);
                g.DrawString($"Nombre: {nombre}", infoFont, Brushes.Black, new PointF(10, 100));
                g.DrawString($"Apellido: {apellido}", infoFont, Brushes.Black, new PointF(10, 130));
                g.DrawString($"DNI: {dni}", infoFont, Brushes.Black, new PointF(10, 160));
                g.DrawString($"Válido hasta: {fechavencimiento}", infoFont, Brushes.Black, new PointF(10, 190));

                // Agregar firma
                try
                {
                    Image firma = Image.FromFile("./Assets/firma.png");
                    g.DrawImage(firma, 300, 200, 120, 50);
                }
                catch
                {
                    g.DrawString("FIRMA", new Font("Arial", 10, FontStyle.Bold), Brushes.Gray, new PointF(300, 200));
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
