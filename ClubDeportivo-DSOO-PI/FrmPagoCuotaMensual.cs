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
using ClubDeportivo.Datos;
using ClubDeportivo_DSOO_PI.Datos;
using MySql.Data.MySqlClient; // Referencia a la carpeta de Datos


namespace ClubDeportivo_DSOO_PI
{
    public partial class frmPagoCuota : Form
    {
        private string nroRegistro; /*en la bbdd es idRegistro*/
        public frmPagoCuota()
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

        private void frmPagoCuota_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNroRegistro_TextChanged(object sender, EventArgs e)
        {
            nroRegistro = txtNroRegistro.Text;
            
            if (string.IsNullOrEmpty(nroRegistro))
            {
                MessageBox.Show("Debe seleccionar un numero de registro.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void buscarRegistro(int nroRegistro)
        {
            
            using (MySqlConnection connection=Conexion.getInstancia().CrearConexion())
            {
                try {
                    connection.Open();
                    string query = "select * from persona where idRegistro=@nroRegistro";
                    using (MySqlCommand command = new MySqlCommand(query, connection)) 
                    {
                        command.Parameters.AddWithValue("@nroRegistro", nroRegistro);
                        using (MySqlDataReader reader = command.ExecuteReader()) { 
                        if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string nombre = reader["nombre"].ToString
                                }
                            }
                        }
                    }
                
                }

            }
        }
    }
}
