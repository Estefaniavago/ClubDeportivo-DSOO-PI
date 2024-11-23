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
    //frmLogin hereda de Form, clase de C#
    public partial class frmLogin : BaseForm
    {
        //Constructor de la clase frmLogin
        public frmLogin()
        {
           InitializeComponent();
           EstilosGlobales.AplicarEstilosFormulario(this);

        }


        //Se ejecuta cuando el usuario hace click en el boton INGRESAR
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text == "USUARIO" ||
                    string.IsNullOrWhiteSpace(txtPass.Text) || txtPass.Text == "CONTRASEÑA")
                {
                    MessageBox.Show("Por favor, complete ambos campos antes de continuar.",
                                    "Campos incompletos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
                Usuarios dato = new Usuarios(); // variable que contiene todas las caracteristicas de la clase

                //Consulta si las credenciales son validas
                tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

                //verifica si la consulta devolvio filas
                if (tablaLogin.Rows.Count > 0)
                {
                    // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                    string nombreUsuario = tablaLogin.Rows[0]["nombreUsuario"].ToString();

                    MessageBox.Show($"Ingreso exitoso. Bienvenid@ {nombreUsuario}");

                    //Abre el formulario del menu principal si la consulta es exitosa
                    frmPrincipal form2 = new frmPrincipal();
                    this.Hide();//oculta el formLogin
                    form2.ShowDialog();
                    this.Show(); //vuelve a mostrar el form de login

                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrecto. Intente nuevamente");
                    //txtUsuario.Text = "USUARIO";
                    //txtPass.UseSystemPasswordChar = false;
                    //txtPass.Text = "CONTRASEÑA";
                    ReiniciarCamposLogin();
                }

            }
            catch (Exception ex)
            {
                // Manejo de errores, muestra un mensaje al usuario
                MessageBox.Show($"Ocurrió un error: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                ReiniciarCamposLogin(); // Limpia los campos en caso de error
            }
        }


        // Método para reiniciar y restaurar los campos de texto
        private void ReiniciarCamposLogin()
        {
            txtUsuario.Text = "USUARIO";
            txtUsuario.ForeColor = Color.Gray;

            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            txtPass.ForeColor = Color.Gray;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega el foco al textbox de USUARIO*/
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }

        }


        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco de USUARIO*/
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