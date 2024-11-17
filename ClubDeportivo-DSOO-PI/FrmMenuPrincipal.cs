﻿using ClubDeportivo.Datos;
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
        public frmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual; // posición manual
            this.Size = new Size(800, 450); // tamaño
            this.Location = new Point(100, 100); // posición en la pantalla
            this.Load += new System.EventHandler(this.Form2_Load);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Fondo degradado
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,Color.LightBlue, Color.White, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

        private void Form2_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Form2_Load_1(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego.");
            Application.Exit();
        }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        // Método para cargar un formulario en panel2 sin bordes ni título
        private void MostrarFormularioEnPanel(Form formulario)
        {
            // Limpiar cualquier formulario presente en panel2
            panel2.Controls.Clear();

            // Configurar el formulario para cargar en el panel sin bordes ni título
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario a panel2 y mostrar
            panel2.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnRegistroSocio_Click_1(object sender, EventArgs e)
        {
            // Instancia del formulario de registro de persona
            registroPersona form3 = new registroPersona();
            MostrarFormularioEnPanel(form3);
        }

        private void btnPagoMensual_Click(object sender, EventArgs e)
        {
            // Instancia del formulario de pago de cuota mensual
            frmPagoCuotaMensual formulario = new frmPagoCuotaMensual();
            MostrarFormularioEnPanel(formulario);
        }

        private void btnGrillaPr_Click(object sender, EventArgs e)
        {
            PersonasRegistradas form2 = new PersonasRegistradas();
            MostrarFormularioEnPanel(form2);
            //form2.ShowDialog();
        }

        private void btnPagoActividad_Click(object sender, EventArgs e)
        {
            frmPagoNoSocio form4 = new frmPagoNoSocio();
            MostrarFormularioEnPanel(form4);
            
        }
    }
}

