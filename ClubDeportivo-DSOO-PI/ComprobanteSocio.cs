using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

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

            // Configuración inicial del formulario
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Size = new Size(500, 600); // Ajustar dimensiones
            this.Paint += FrmComprobanteSocio_Paint; // Dibujar fondo y borde
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

        private void FrmComprobanteSocio_Paint(object sender, PaintEventArgs e)
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


        private void btnImprimirComprobanteS_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo documento de impresión
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += imprimirComprobanteS;

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
        private void imprimirComprobanteS(object o, PrintPageEventArgs e)
        {
            int x = 100;
            int y = 100;

            e.Graphics.DrawString($"Nombre: {Nombre}", new Font("Segoe UI", 12), Brushes.Black, x, y);
            e.Graphics.DrawString($"Apellido: {Apellido}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
            e.Graphics.DrawString($"Monto Cuota: {Montocuota}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
            e.Graphics.DrawString($"Fecha de Pago: {FechaPago}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
            e.Graphics.DrawString($"Medio de Pago: {MedioPago}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
            e.Graphics.DrawString($"Cuotas: {Cuotas}", new Font("Segoe UI", 12), Brushes.Black, x, y += 40);
        }

        
    }
    }
         
