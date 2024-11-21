using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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

        private void ComprobanteNoSocio_Load_1(object sender, EventArgs e)
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

        private void btnImrpimirCompr_Click_1(object sender, EventArgs e)
        {

            /* Eliminamos el boton imprimir de la vista*/
            btnImrpimirCompr.Visible = false;
            /* Creamos objeto para imprimir*/
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(imprimirComprobanteNs);
            pd.Print();
            btnImrpimirCompr.Visible = true; // visualizamos nuevamente el boton de imprimir


            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }
    
    
       
        private void imprimirComprobanteNs(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }


    }
}