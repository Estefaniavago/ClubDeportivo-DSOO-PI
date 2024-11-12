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
using MySql.Data.MySqlClient;

namespace ClubDeportivo_DSOO_PI
{
    public partial class frmPagoCuotaMensual : Form
    {
        private string nroRegistro; // En la BBDD es idRegistro
        private string comprobante; // Para almacenar el comprobante generado
        private decimal montoTotal = 1200; // Monto total de la cuota mensual para todos los socios

        public frmPagoCuotaMensual()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void txtNroRegistro_TextChanged(object sender, EventArgs e)
        {
            nroRegistro = txtNroRegistro.Text;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nroRegistro, out int registroId))
            {
                buscarRegistro(registroId);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de registro válido.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarRegistro(int nroRegistro)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM persona WHERE idRegistro = @nroRegistro";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nroRegistro", nroRegistro);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string nombre = reader["nombre"].ToString();
                                    string apellido = reader["apellido"].ToString();
                                    MessageBox.Show($"Registro encontrado:\nNombre: {nombre}\nApellido: {apellido}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro con el número especificado.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al acceder a la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Determina el medio de pago y el número de cuotas
            string medioPago = "";
            int cuotas = 1; // Predeterminado a 1 cuota (efectivo)
            decimal montoPorCuota = montoTotal; // Monto por cuota

            if (rdEfectivo.Checked)
            {
                medioPago = "Efectivo";
                cuotas = 1;
            }
            else if (rdDebito.Checked)
            {
                medioPago = "Débito";
                cuotas = 3;
                montoPorCuota = montoTotal / cuotas;
            }
            else if (rdCredito.Checked)
            {
                medioPago = "Crédito";
                cuotas = 6;
                montoPorCuota = montoTotal / cuotas;
            }

            // Verifica que se haya seleccionado un medio de pago
            if (string.IsNullOrEmpty(medioPago))
            {
                MessageBox.Show("Por favor, seleccione un medio de pago.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular la fecha del próximo vencimiento, siempre a un mes
            DateTime fechaActual = DateTime.Now;
            DateTime proximoVencimiento = fechaActual.AddMonths(1);

            // Generar el comprobante de pago
            comprobante = $"Comprobante de Pago:\n" +
                          $"Número de Registro: {nroRegistro}\n" +
                          $"Medio de Pago: {medioPago}\n" +
                          $"Fecha de Pago: {fechaActual.ToShortDateString()}\n" +
                          $"Próximo Vencimiento: {proximoVencimiento.ToShortDateString()}\n" +
                          $"Monto Total: ${montoTotal}\n" +
                          $"Número de Cuotas: {cuotas}\n" +
                          $"Monto por Cuota: ${montoPorCuota}";

            // Almacenar el pago en la base de datos en la tabla 'vencimientos'
            RegistrarVencimiento(nroRegistro, fechaActual, proximoVencimiento, medioPago, cuotas);

            MessageBox.Show("Pago realizado exitosamente. Comprobante generado.", "Confirmación de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegistrarVencimiento(string idRegistro, DateTime fechaPago, DateTime fechaVencimiento, string medioPago, int cuotas)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO vencimientos (idRegistro, fechaPago, fechaVencimiento, medioPago, cuotas) " +
                                   "VALUES (@idRegistro, @fechaPago, @fechaVencimiento, @medioPago, @cuotas)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idRegistro", idRegistro);
                        command.Parameters.AddWithValue("@fechaPago", fechaPago);
                        command.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                        command.Parameters.AddWithValue("@medioPago", medioPago);
                        command.Parameters.AddWithValue("@cuotas", cuotas);

                        command.ExecuteNonQuery();
                    }

                    // Actualizar el cliente como socio en la tabla `persona`
                    string updateQuery = "UPDATE persona SET condicion = 1 WHERE idRegistro = @idRegistro";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@idRegistro", idRegistro);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al registrar el vencimiento en la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comprobante))
            {
                // Mostrar el comprobante en un modal con estilo de tarjeta (simulado)
                Form comprobanteForm = new Form();
                comprobanteForm.Text = "Comprobante de Pago";
                comprobanteForm.Size = new Size(400, 300);

                Label comprobanteLabel = new Label
                {
                    Text = comprobante,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(20, 20)
                };

                comprobanteForm.Controls.Add(comprobanteLabel);
                comprobanteForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ningún comprobante generado aún.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
