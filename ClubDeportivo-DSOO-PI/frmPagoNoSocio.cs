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
        private string horarioSeleccionado;
        private string diaSeleccionado;

        public frmPagoNoSocio()
        {
            InitializeComponent();
            txtPrecioAct.ReadOnly = true; // Establece el campo como de solo lectura
            dtgvActividad.ReadOnly = true; // Hace que el DataGridView sea de solo lectura
            dtgvActividad.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar filas completas
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

        private void cbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string actividadSeleccionada = cbActividad.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(actividadSeleccionada))
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        connection.Open();
                        string query = @"SELECT a.precio, h.dia, h.horario 
                                        FROM actividad a
                                        JOIN actividad_horarios h ON a.NActividad = h.NActividad
                                        WHERE a.Nombre = @Nombre";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", actividadSeleccionada);

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                DataTable horariosTable = new DataTable();
                                adapter.Fill(horariosTable);

                                if (horariosTable.Rows.Count > 0)
                                {
                                    // Mostrar el precio en el TextBox txtPrecioAct (solo la primera fila)
                                    txtPrecioAct.Text = horariosTable.Rows[0]["precio"].ToString();

                                    // Configurar y mostrar los horarios en el DataGridView
                                    dtgvActividad.DataSource = horariosTable;
                                    dtgvActividad.Columns["dia"].HeaderText = "Día";
                                    dtgvActividad.Columns["horario"].HeaderText = "Horario";
                                    dtgvActividad.Columns["precio"].Visible = false; // Ocultar la columna del precio
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron horarios para la actividad seleccionada.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los detalles de la actividad: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtgvActividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se está haciendo clic en el encabezado
            {
                DataGridViewRow row = dtgvActividad.Rows[e.RowIndex];
                diaSeleccionado = row.Cells["dia"].Value.ToString();
                horarioSeleccionado = row.Cells["horario"].Value.ToString();

                MessageBox.Show($"Has seleccionado el día: {diaSeleccionado} y el horario: {horarioSeleccionado}",
                    "Horario Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnComprobanteNoSocio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbActividad.Text) && !string.IsNullOrEmpty(txtPrecioAct.Text) )
            {
                string actividad = cbActividad.Text;
                string precio = txtPrecioAct.Text;
                string fechaPago = DateTime.Now.ToShortDateString();

                string comprobante = $"Comprobante de Pago:\n" +
                                     $"Actividad: {actividad}\n" +
                                     $"Precio: ${precio}\n" +
                                     $"Fecha de Pago: {fechaPago}";

                MessageBox.Show(comprobante, "Comprobante Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de generar el comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNroRegistroNs_TextChanged(object sender, EventArgs e)
        {
            string nroRegistro = txtNroRegistroNs.Text;

            if (!string.IsNullOrEmpty(nroRegistro))
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT nombre, apellido FROM persona WHERE idRegistro = @idRegistro";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idRegistro", nroRegistro);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNyANs.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                                }
                                else
                                {
                                    txtNyANs.Text = "Registro no encontrado";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar el registro: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnValidarNSocio_Click(object sender, EventArgs e)
        {
            string nroRegistro = txtNroRegistroNs.Text;

            if (!string.IsNullOrEmpty(nroRegistro))
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT nombre, apellido FROM persona WHERE idRegistro = @idRegistro";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idRegistro", nroRegistro);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNyANs.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                                    MessageBox.Show("Registro validado exitosamente.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Registro no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al validar el registro: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    




        private void txtPrecioAct_TextChanged(object sender, EventArgs e)
        {
        }

        private void grbMedioPago_Enter(object sender, EventArgs e)
        {
        }

        private void dtgvActividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
