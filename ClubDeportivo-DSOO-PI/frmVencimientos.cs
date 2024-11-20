using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivo_DSOO_PI.Datos;
using ClubDeportivo.Datos;

namespace ClubDeportivo_DSOO_PI
{
    public partial class frmVencimientos : Form
    {
        private DataTable vencimientosTable;

        public frmVencimientos()
        {
            InitializeComponent();
            CargarVencimientos();
        }

        private void frmVencimientos_Load(object sender, EventArgs e)
        {
            // Configurar el DateTimePicker para mostrar desde la fecha actual
            dtpFiltroFecha.Value = DateTime.Now;
        }

        private void CargarVencimientos(DateTime? fechaFiltro = null)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            p.idRegistro, 
                            p.nombre, 
                            p.apellido, 
                            v.fechaVencimiento
                        FROM persona p
                        JOIN vencimientos v ON p.idRegistro = v.idRegistro
                        WHERE p.condicion = 1
                        AND v.fechaVencimiento <= DATE_ADD(CURDATE(), INTERVAL 30 DAY)";

                    if (fechaFiltro.HasValue)
                    {
                        query += " AND v.fechaVencimiento = @fechaFiltro";
                    }

                    query += " ORDER BY v.fechaVencimiento";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        if (fechaFiltro.HasValue)
                        {
                            command.Parameters.AddWithValue("@fechaFiltro", fechaFiltro.Value.ToString("yyyy-MM-dd"));
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            vencimientosTable = new DataTable();
                            adapter.Fill(vencimientosTable);
                            dtgvVencimientos.AllowUserToAddRows = false;
                            dtgvVencimientos.DataSource = vencimientosTable;
                            dtgvVencimientos.Columns["idRegistro"].HeaderText = "Nro Registro";
                            dtgvVencimientos.Columns["nombre"].HeaderText = "Nombre";
                            dtgvVencimientos.Columns["apellido"].HeaderText = "Apellido";
                            dtgvVencimientos.Columns["fechaVencimiento"].HeaderText = "Fecha Vencimiento";

                            // Ajustar diseño de la grilla
                            dtgvVencimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            // Mostrar mensaje si no hay datos
                            if (vencimientosTable.Rows.Count == 0)
                            {
                                lblMensaje.Text = fechaFiltro.HasValue
                                    ? $"No hay registros para la fecha seleccionada: {fechaFiltro.Value.ToShortDateString()}"
                                    : "No hay registros para mostrar.";
                                lblMensaje.Visible = true;
                            }
                            else
                            {
                                lblMensaje.Visible = false;
                            }


                            // Aplicar colores a las filas
                            foreach (DataGridViewRow row in dtgvVencimientos.Rows)
                            {
                                if (row.Cells["fechaVencimiento"].Value != null)
                                {
                                    DateTime fechaVencimiento = Convert.ToDateTime(row.Cells["fechaVencimiento"].Value);
                                    if (fechaVencimiento < DateTime.Now)
                                    {
                                        row.DefaultCellStyle.BackColor = Color.Red;
                                        row.DefaultCellStyle.ForeColor = Color.White;
                                    }
                                    else if ((fechaVencimiento - DateTime.Now).TotalDays <= 7)
                                    {
                                        row.DefaultCellStyle.BackColor = Color.Yellow;
                                    }
                                    else
                                    {
                                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los vencimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpFiltroFecha_ValueChanged(object sender, EventArgs e)
        {
            // Filtrar vencimientos por la fecha seleccionada en el DateTimePicker
            CargarVencimientos(dtpFiltroFecha.Value);
        }

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {
            dtpFiltroFecha.Value = DateTime.Now; // Restablecer al valor actual
            CargarVencimientos(); // Mostrar vencimientos próximos a partir de hoy
        }
    }
}