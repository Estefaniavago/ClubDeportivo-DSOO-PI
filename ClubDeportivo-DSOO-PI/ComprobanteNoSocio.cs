using System;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace ClubDeportivo_DSOO_PI
{
    public partial class ComprobanteNoSocio : Form
    {
        // Propiedades públicas para recibir los datos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ActividadElegida { get; set; }
        public string Precio { get; set; }
        public string FechaPago { get; set; }
        public string MedioPago { get; set; }

        public ComprobanteNoSocio()
        {
            InitializeComponent();
        }

        private void ComprobanteNoSocio_Load(object sender, EventArgs e)
        {
            


            try
            {

                MessageBox.Show($"Nombre: {Nombre}, Apellido: {Apellido}, Actividad: {ActividadElegida}, Precio: {Precio}, Fecha: {FechaPago}, Medio de Pago: {MedioPago}");
                
                // Asignar los valores recibidos a los campos del formulario
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

        private void btnImrpimirCompr_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ComprobanteNoSocio.pdf");

            try
            {
                using (PdfWriter writer = new PdfWriter(rutaArchivo))
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Comprobante de Pago").SetFontSize(18).SetBold());
                    document.Add(new Paragraph($"Nombre: {Nombre}"));
                    document.Add(new Paragraph($"Apellido: {Apellido}"));
                    document.Add(new Paragraph($"Actividad Elegida: {ActividadElegida}"));
                    document.Add(new Paragraph($"Precio: {Precio}"));
                    document.Add(new Paragraph($"Fecha de Pago: {FechaPago}"));
                    document.Add(new Paragraph($"Medio de Pago: {MedioPago}"));
                }

                MessageBox.Show($"El comprobante ha sido guardado en: {rutaArchivo}", "Comprobante Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnImrpimirCompr.Enabled = false; // Deshabilitar el botón después de generar el comprobante
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void txtNombreNoSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoNoSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtActividadElegida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioActividad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaDePagoNoSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedioDePago_TextChanged(object sender, EventArgs e)
        {

        }
    }
}