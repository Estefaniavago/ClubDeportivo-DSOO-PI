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
            // Lógica para cargar datos en la grilla al abrir el formulario
            CargarVencimientos();
        }

        private void CargarVencimientos()
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
                    v.fechaVencimiento, 
                    CASE
                        WHEN v.fechaVencimiento < CURDATE() THEN 'Vencido'
                        WHEN DATEDIFF(v.fechaVencimiento, CURDATE()) <= 7 THEN 'Por Vencer'
                        ELSE 'Pendiente'
                    END AS Estado
                FROM persona p
                JOIN vencimientos v ON p.idRegistro = v.idRegistro
                WHERE p.condicion = 1
                ORDER BY v.fechaVencimiento";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        vencimientosTable = new DataTable();
                        adapter.Fill(vencimientosTable);

                        dtgvVencimientos.DataSource = vencimientosTable;
                        dtgvVencimientos.Columns["idRegistro"].HeaderText = "Nro Registro";
                        dtgvVencimientos.Columns["nombre"].HeaderText = "Nombre";
                        dtgvVencimientos.Columns["apellido"].HeaderText = "Apellido";
                        dtgvVencimientos.Columns["fechaVencimiento"].HeaderText = "Fecha Vencimiento";
                        dtgvVencimientos.Columns["Estado"].HeaderText = "Estado";

                        // Ajustar diseño de la grilla
                        dtgvVencimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Aplicar colores a las filas según el estado
                        foreach (DataGridViewRow row in dtgvVencimientos.Rows)
                        {
                            if (row.Cells["Estado"].Value != null)
                            {
                                string estado = row.Cells["Estado"].Value.ToString();
                                if (estado == "Vencido")
                                {
                                    row.DefaultCellStyle.BackColor = Color.Red;
                                    row.DefaultCellStyle.ForeColor = Color.White;
                                }
                                else if (estado == "Por Vencer")
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los vencimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnValidarRegistroSocio_Click(object sender, EventArgs e)
        {
            string nroRegistro = txtRegistroSocio.Text;

            if (string.IsNullOrEmpty(nroRegistro))
            {
                MessageBox.Show("Por favor, ingrese un número de registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = vencimientosTable.Select($"idRegistro = {nroRegistro}");

            if (row.Length > 0)
            {
                dtgvVencimientos.ClearSelection();
                foreach (DataGridViewRow dgvRow in dtgvVencimientos.Rows)
                {
                    if (dgvRow.Cells["idRegistro"].Value.ToString() == nroRegistro)
                    {
                        dgvRow.Selected = true;
                        dtgvVencimientos.FirstDisplayedScrollingRowIndex = dgvRow.Index;

                        if (dgvRow.Cells["Estado"].Value.ToString() == "Vencido" || dgvRow.Cells["Estado"].Value.ToString() == "Por Vencer")
                        {
                            btnPagarCuotaVencida.Enabled = true;
                        }
                        else
                        {
                            btnPagarCuotaVencida.Enabled = false;
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el registro o no tiene cuotas próximas a vencer.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPagarCuotaVencida.Enabled = false;
            }
        }

        private void btnPagarCuotaVencida_Click(object sender, EventArgs e)
        {
            string nroRegistro = txtRegistroSocio.Text; // Obtener el número de registro del TextBox

            if (!string.IsNullOrEmpty(nroRegistro))
            {
                frmPagoCuotaMensual pagoForm = new frmPagoCuotaMensual();
                pagoForm.NroRegistro = nroRegistro; // Asignar el número de registro
                pagoForm.ShowDialog(); // Mostrar el formulario
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de registro válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSocioValidado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
