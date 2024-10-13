using ClubDeportivo.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Dibuja un fondo degradado
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.LightBlue, Color.White, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Crear botón personalizado
            CustomButton btnIngresar = new CustomButton();
            btnIngresar.Text = "INGRESAR";
            btnIngresar.Size = new Size(150, 40);
            btnIngresar.Location = new Point(505, 300); // Ajusta la posición
            btnIngresar.BackColor = Color.FromArgb(12, 57, 80); // Color de fondo inicial
            btnIngresar.ForeColor = Color.White; // Color del texto
            btnIngresar.Click += btnIngresar_Click; // Asocia el evento
            this.Controls.Add(btnIngresar); // Añade el botón al formulario

            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false; // Asegúrate de que el texto esté visible inicialmente

            txtUsuario.Text = "USUARIO";
            txtUsuario.ForeColor = Color.FromArgb(12, 57, 80);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega el foco */
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black; // Cambia el color al foco
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco */
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray; // Restaura el color del marcador
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = ""; // Limpia el texto
                txtPass.UseSystemPasswordChar = true; // Oculta la contraseña
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Text = "CONTRASEÑA"; // Restablece el texto por defecto
                txtPass.UseSystemPasswordChar = false; // Muestra el texto
            }
        }
    

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Usuarios dato = new Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                 MessageBox.Show("Ingreso exitoso");

                Form2 form2 = new Form2();

                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }

        }

        private void LogoClub_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
