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
    public partial class frmComprobanteSocio : Form
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Montocuota { get; set; }
        public string FechaPago { get; set; }
        public string MedioPago { get; set; }
        public string Cuotas{ get; set; }

        public frmComprobanteSocio()
        {
            InitializeComponent();
        }

        private void frmComprobanteSocio_Load(object sender, EventArgs e)
        {
            try
            {

                
                // Asignar los valores recibidos a los campos del formulario
                txtNombreS.Text = Nombre;
                txtApellidoS.Text = Apellido;
                txtMontoS.Text = Montocuota;
                txtFechaS.Text = FechaPago;
                txtMediodePagoS.Text = MedioPago;
                txtCuotasS.Text = Cuotas;

                // Configurar los TextBox como de solo lectura
                txtNombreS.ReadOnly = true;
                txtApellidoS.ReadOnly = true;
                txtMontoS.ReadOnly = true;
                txtFechaS.ReadOnly = true;
                txtMediodePagoS.ReadOnly = true;
                txtCuotasS.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del comprobante: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirComprobanteS_Click(object sender, EventArgs e)
        {
            /* Eliminamos el boton imprimir de la vista*/
            btnImprimirComprobanteS.Visible = false;
            /* Creamos objeto para imprimir*/
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(imprimirComprobanteNs);
            pd.Print();
            btnImprimirComprobanteS.Visible = true; // visualizamos nuevamente el boton de imprimir


            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
         
