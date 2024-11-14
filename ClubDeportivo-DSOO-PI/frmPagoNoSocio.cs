using System;
using System.Data;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo_DSOO_PI
{
    public partial class frmPagoNoSocio : Form
    {
        public frmPagoNoSocio()
        {
            InitializeComponent();
            txtPrecioAct.ReadOnly = true; // Establece el campo como de solo lectura
            CargarActividades(); // Llamar al método para cargar actividades al abrir el formulario
        }

        private void CargarActividades()
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM actividad";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agregar el nombre de la actividad al ComboBox
                            cbActividad.Items.Add(reader["Nombre"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void txtPrecioAct_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbMedioPago_Enter(object sender, EventArgs e)
        {

        }

        private void cbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la actividad seleccionada
            string actividadSeleccionada = cbActividad.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(actividadSeleccionada))
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT precio FROM actividad WHERE Nombre = @Nombre";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", actividadSeleccionada);

                            object resultado = command.ExecuteScalar();

                            if (resultado != null)
                            {
                                // Mostrar el precio en el TextBox txtPrecioAct
                                txtPrecioAct.Text = resultado.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el precio para la actividad seleccionada.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el precio de la actividad: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
