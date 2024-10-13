using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Crear botón "ALTA SOCIO / NO SOCIO"
            CustomButton btnAltaSocio = new CustomButton();
            btnAltaSocio.Text = "ALTA SOCIO / NO SOCIO";
            btnAltaSocio.Size = new Size(150, 40);
            btnAltaSocio.Location = new Point(50, 100);
            btnAltaSocio.BackColor = Color.LightBlue; // Color de fondo
            btnAltaSocio.ForeColor = Color.White; // Color del texto
            btnAltaSocio.Click += BtnAltaSocio_Click; // Asocia el evento
            this.Controls.Add(btnAltaSocio);

            // Crear botón "EMITIR CARNET"
            CustomButton btnEmitirCarnet = new CustomButton();
            btnEmitirCarnet.Text = "EMITIR CARNET";
            btnEmitirCarnet.Size = new Size(150, 40);
            btnEmitirCarnet.Location = new Point(50, 150);
            btnEmitirCarnet.BackColor = Color.LightGreen; // Color de fondo
            btnEmitirCarnet.ForeColor = Color.White; // Color del texto
            btnEmitirCarnet.Click += BtnEmitirCarnet_Click; // Asocia el evento
            this.Controls.Add(btnEmitirCarnet);



        }

        private void BtnAltaSocio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón ALTA SOCIO / NO SOCIO presionado.");
        }

        private void BtnEmitirCarnet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón EMITIR CARNET presionado.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
