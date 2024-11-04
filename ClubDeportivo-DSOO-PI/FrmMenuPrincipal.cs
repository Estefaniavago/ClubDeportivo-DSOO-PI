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
    public partial class frmPrincipal : Form
    {
       //private string nombreUsuario;
        public frmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual; // posición manual
            this.Size = new Size(800, 450); // tamaño
            this.Location = new Point(100, 100); // posición en la pantalla
            this.Load += new System.EventHandler(this.Form2_Load);
             // Guardar nombre de usuario
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
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hasta luego.");
            Application.Exit();
        }


        private void btnPago_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistroSocio_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Form3 (registroUsuario)
            registroSocio form3 = new registroSocio();

            // Mostrar el formulario Form3
            form3.ShowDialog();

        }

        private void btnPagoMensual_Click(object sender, EventArgs e)
        {

            Form formulario = new frmPago();
            formulario.Show(); //Llama al formulario de forma no modal

        }


        private void btnRegistroNoSocio_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Form4 (registroNoSocio)
           FrmRegistroNoSocio form4 = new FrmRegistroNoSocio();

            // Mostrar el formulario Form3
            form4.ShowDialog();
        }
    }
}