using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            /*Este evento se ejecuta cuando llega el foco*/
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /*Este evento se ejecuta cuando se va el foco*/
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            /*Evento que se ejecuta cuando va el foco*/
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                /*Quiero que no se va la contraseña cuando la escribo*/
                txtPass.UseSystemPasswordChar = true;/*Si es true todo lo que escribo esta camuflado*/
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            /*Evento que se ejecuta cuando se va el foco */
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                /*Quiero que no se va la contraseña cuando la escribo*/
                txtPass.UseSystemPasswordChar = false;/*Si es true todo lo que escribo esta camuflado*/
            }

        }
    }
}
