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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
           InitializeComponent();
            this.StartPosition = FormStartPosition.Manual; // posición manual
            this.Size = new Size(800, 450); // tamaño
            this.Location = new Point(100, 100); // posición en la pantalla
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           // fondo degradado
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.LightBlue, Color.White, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

       private void Form1_Load(object sender, EventArgs e)
        {
         
            
       }
    
       /* private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/
     
       
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Usuarios dato = new Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                string nombreUsuario = tablaLogin.Rows[0]["nombreUsuario"].ToString();

                MessageBox.Show($"Ingreso exitoso. Bienvenid@ {nombreUsuario}");
               


                frmPrincipal form2 = new frmPrincipal();
                form2.ShowDialog();
                


            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto. Intente nuevamente");
                txtUsuario.Text = "USUARIO";
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "CONTRASEÑA";
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

       
        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega el foco */
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco */
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
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
    }
}