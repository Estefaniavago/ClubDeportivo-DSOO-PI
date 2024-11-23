using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class ComprobanteNoSocio : Form
    {

        private frmPagoNoSocio formularioOriginal;
        // Propiedades públicas para recibir los datos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ActividadElegida { get; set; }
        public string Precio { get; set; }
        public string FechaPago { get; set; }
        public string MedioPago { get; set; }

        public ComprobanteNoSocio(frmPagoNoSocio formularioOriginal)
        {
            InitializeComponent();

            // Asignar el formulario original
            this.formularioOriginal = formularioOriginal;

            // Configuración inicial del formulario
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Size = new Size(600, 600); // Ajustar dimensiones
            this.Paint += ComprobanteNoSocio_Paint; // Dibujar fondo y borde
        }

        private void ComprobanteNoSocio_Load_1(object sender, EventArgs e)
        {
            // Aplicar los estilos globales al formulario actual
            EstilosGlobales.AplicarEstilosFormulario(this);
            try
            {
                // Asignar los valores recibidos a los TextBox
                txtNombreNoSocio.Text = Nombre;
                txtApellidoNoSocio.Text = Apellido;
                txtActividadElegida.Text = ActividadElegida;
                txtPrecioActividad.Text = Precio;
                txtFechaDePagoNoSocio.Text = FechaPago;
                txtMedioDePago.Text = MedioPago;

                // Configurar los TextBox como de solo lectura
                txtNombreNoSocio.ReadOnly = true;
                txtApellidoNoSocio.ReadOnly = true;
                txtActividadElegida.ReadOnly = true;
                txtPrecioActividad.ReadOnly = true;
                txtFechaDePagoNoSocio.ReadOnly = true;
                txtMedioDePago.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del comprobante: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComprobanteNoSocio_Paint(object sender, PaintEventArgs e)
        {
            // **1. Fondo con degradado vertical**
            using (LinearGradientBrush gradiente = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, this.Height),
                Color.LightBlue, // Color inicial
                Color.White,     // Color final
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradiente, 0, 0, this.Width, this.Height);
            }

            // **2. Dibujar borde decorativo**
            Pen borde = new Pen(Color.DarkBlue, 3);
            e.Graphics.DrawRectangle(borde, 0, 0, this.Width - 1, this.Height - 1);
        }

        private void btnImrpimirCompr_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo documento de impresión
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += ImprimirComprobanteNs;

                // Crear una ventana de vista previa de impresión
                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = pd // Asignar el documento de impresión
                };

                // Mostrar la vista previa
                if (previewDialog.ShowDialog() == DialogResult.OK)
                {
                    // Si el usuario confirma, imprimir el documento
                    pd.Print();
                    MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirComprobanteNs(object sender, PrintPageEventArgs e)
        {
            int x = 100;
            int y = 100;

            e.Graphics.DrawString($"Nombre: {Nombre}", new Font("Segoe UI", 12), Brushes.Black, x, y);
            e.Graphics.DrawString($"Apellido: {Apellido}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
            e.Graphics.DrawString($"Actividad: {ActividadElegida}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
            e.Graphics.DrawString($"Precio: {Precio}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
            e.Graphics.DrawString($"Fecha de Pago: {FechaPago}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
            e.Graphics.DrawString($"Medio de Pago: {MedioPago}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Limpia los datos de los controles
            txtNombreNoSocio.Clear();
            txtApellidoNoSocio.Clear();
            txtActividadElegida.Clear();
            txtPrecioActividad.Clear();
            txtFechaDePagoNoSocio.Clear();
            txtMedioDePago.Clear();

            // Mostrar el formulario original
            formularioOriginal.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}
