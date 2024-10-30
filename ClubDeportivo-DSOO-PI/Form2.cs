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
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}