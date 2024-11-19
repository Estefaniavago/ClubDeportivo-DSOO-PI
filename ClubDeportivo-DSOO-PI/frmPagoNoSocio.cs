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
            btnPagar.Enabled = false;
        }

        //Carga las actividades para que puedan seleccionarse del combobox, trayendolas de la bbdd
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

        //Codigo que corresponde al evento de seleccionar una actividad de la lista
        //Se autocompleta el precio de la actividad y se cargan los dias y horarios en la grilla
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

        //Seleccionar dia y horario de la actividad
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
            // Validar que los campos obligatorios estén completos
            if (!string.IsNullOrEmpty(cbActividad.Text) &&
                !string.IsNullOrEmpty(txtPrecioAct.Text) &&
                !string.IsNullOrEmpty(txtNyANs.Text))
            {
                // Crear y configurar el formulario de comprobante
                ComprobanteNoSocio comprobanteForm = new ComprobanteNoSocio
                {
                    Nombre = txtNyANs.Text.Split(' ')[0],
                    Apellido = txtNyANs.Text.Split(' ')[1],
                    ActividadElegida = cbActividad.Text,
                    Precio = txtPrecioAct.Text,
                    FechaPago = DateTime.Now.ToShortDateString(),
                    MedioPago = rdEfectivo.Checked ? "Efectivo" : rdCredito.Checked ? "Crédito" : "N/A"
                };

                // Mostrar el formulario de comprobante
                comprobanteForm.ShowDialog(); // Utilizamos ShowDialog para que sea modal
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de generar el comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        //Lee el numero de registro
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
                                    txtNyANs.Text = "Registro no encontrado o no válido";
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
                        string query = @"
                    SELECT 
                        nombre, 
                        apellido, 
                        condicion 
                    FROM persona 
                    WHERE idRegistro = @idRegistro";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idRegistro", nroRegistro);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string nombre = reader["nombre"].ToString();
                                    string apellido = reader["apellido"].ToString();
                                    bool esSocio = Convert.ToBoolean(reader["condicion"]);

                                    if (esSocio)
                                    {
                                        txtNyANs.Text = $"{nombre} {apellido}";
                                        MessageBox.Show("Este registro corresponde a un socio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        btnPagar.Enabled = false;
                                    }
                                    else
                                    {
                                        txtNyANs.Text = $"{nombre} {apellido}";
                                        MessageBox.Show("Registro validado exitosamente.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnPagar.Enabled = true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Registro no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    btnPagar.Enabled = false;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al validar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(cbActividad.Text) &&
                !string.IsNullOrEmpty(txtPrecioAct.Text) &&
                !string.IsNullOrEmpty(txtNyANs.Text) &&
                !string.IsNullOrEmpty(txtNroRegistroNs.Text)&&
                (rdCredito.Checked|| rdEfectivo.Checked)
                )
            {
                // Capturar los datos del formulario
                int.TryParse(txtNroRegistroNs.Text, out int idPersona);
                                       
                string actividad = cbActividad.Text;
                string precio = txtPrecioAct.Text;
                string fechaPago = DateTime.Now.ToString("yyyy-MM-dd");

                // Registrar el pago en la tabla no_socio
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        connection.Open();

                        string query = @"INSERT INTO no_socio 
                                 (idPersona, actividadElegida, precio, fechaPago) 
                                 VALUES 
                                 (@idPersona, @actividadElegida, @precio, @fechaPago)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idPersona", idPersona);
                            command.Parameters.AddWithValue("@actividadElegida", actividad);
                            command.Parameters.AddWithValue("@precio", precio);
                            command.Parameters.AddWithValue("@fechaPago", fechaPago);

                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("El pago ha sido registrado correctamente.", "Pago Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnComprobanteNoSocio.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al registrar el pago. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de proceder con el pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
