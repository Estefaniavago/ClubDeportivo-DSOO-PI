using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo_DSOO_PI.Datos; // Referencia a la carpeta de Datos


namespace ClubDeportivo_DSOO_PI
{
    public partial class frmPagoCuota : Form
    {
        private string nroRegistro;
        public frmPagoCuota(string nroRegistro)
        {
            InitializeComponent();
            

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new frmPrincipal();
            principal.Show();
            this.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPagoCuota_Load(object sender, EventArgs e)
        {

        }
    }
}
