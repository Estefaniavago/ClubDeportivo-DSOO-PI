using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class Form2 : Form
    {
        private string nombreUsuario;
        public Form2(string usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual; // posición manual
            this.Size = new Size(800, 450); // tamaño
            this.Location = new Point(100, 100); // posición en la pantalla
            this.Load += new System.EventHandler(this.Form2_Load);
            nombreUsuario = usuario; // Guardar nombre de usuario
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // fondo degradado
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.LightBlue, Color.White, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

          

            int buttonWidth = 200;
            int buttonHeight = 50;
            int horizontalSpacing = 80; // Espacio horizontal entre botones
            int verticalSpacing = 40; // Espacio vertical entre botones
            

            // Calculo la posición para poder centrar los botones
            int startX = (this.ClientSize.Width - buttonWidth * 2 - horizontalSpacing) / 2;
            int startY = (this.ClientSize.Height - buttonHeight * 2 - verticalSpacing) / 2;

            // Configuración del botón "REGISTRO USUARIO"
            CustomButton btnAltaSocio = new CustomButton();
            btnAltaSocio.Text = "REGISTRO USUARIO";
            btnAltaSocio.Size = new Size(buttonWidth, buttonHeight);
            btnAltaSocio.Location = new Point(startX, startY+10); 
            btnAltaSocio.BackColor = Color.FromArgb(12, 57, 80);
            btnAltaSocio.ForeColor = Color.White;
            btnAltaSocio.Click += BtnAltaSocio_Click;
            this.Controls.Add(btnAltaSocio);

            // Configuración del botón "EMITIR CARNET"
            CustomButton btnEmitirCarnet = new CustomButton();
            btnEmitirCarnet.Text = "EMITIR CARNET";
            btnEmitirCarnet.Size = new Size(buttonWidth, buttonHeight);
            btnEmitirCarnet.Location = new Point(startX + buttonWidth + horizontalSpacing, startY+10); 
            btnEmitirCarnet.BackColor = Color.FromArgb(12, 57, 80);
            btnEmitirCarnet.ForeColor = Color.White;
            btnEmitirCarnet.Click += BtnEmitirCarnet_Click;
            this.Controls.Add(btnEmitirCarnet);

            // Configuración del botón "LISTADO DE VENCIMIENTO"
            CustomButton btnListadoDeVencimiento = new CustomButton();
            btnListadoDeVencimiento.Text = "VENCIMIENTOS";
            btnListadoDeVencimiento.Size = new Size(buttonWidth, buttonHeight);
            btnListadoDeVencimiento.Location = new Point(startX, startY + buttonHeight + verticalSpacing); // Nueva fila
            btnListadoDeVencimiento.BackColor = Color.FromArgb(12, 57, 80);
            btnListadoDeVencimiento.ForeColor = Color.White;
            btnListadoDeVencimiento.Click += BtnListadoDeVencimiento_Click;
            this.Controls.Add(btnListadoDeVencimiento);

            // Configuración del botón "PAGO"
            CustomButton btnPagoCuota = new CustomButton();
            btnPagoCuota.Text = "PAGO DE CUOTA";
            btnPagoCuota.Size = new Size(buttonWidth, buttonHeight);
            btnPagoCuota.Location = new Point(startX + buttonWidth + horizontalSpacing, startY + buttonHeight + verticalSpacing); 
            btnPagoCuota.BackColor = Color.FromArgb(12, 57, 80);
            btnPagoCuota.ForeColor = Color.White;
            btnPagoCuota.Click += BtnPagoCuota_Click;
            this.Controls.Add(btnPagoCuota);

            // Configuración del botón "Volver, regresa a la pantalla de login"
            CustomButton btnSalir = new CustomButton();
            btnSalir.Text = "VOLVER";
            btnSalir.Size = new Size(buttonWidth, buttonHeight);
            btnSalir.Location = new Point(290,300); 
            btnSalir.BackColor = Color.FromArgb(12, 57, 80);
            btnSalir.ForeColor = Color.White;
            btnSalir.Click += BtnSalir_Click;
            this.Controls.Add(btnSalir);
        }

        private void BtnAltaSocio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro de usuario presionado.");
        }

        private void BtnEmitirCarnet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emitir carnet presionado.");
        }

        private void BtnListadoDeVencimiento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vencimientos presionado.");
        }

        private void BtnPagoCuota_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago Cuota presionado.");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hasta luego, {nombreUsuario}");
            this.Close(); // Cierra el formulario
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}