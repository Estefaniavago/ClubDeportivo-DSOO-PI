using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI.Datos
{
    internal class Vencimientos
    {
        public void InsertarVencimiento(int nroRegistro, DateTime fechaActual, DateTime proximoVencimiento, string medioPago, string cuotas, Button btnComprobanteS)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

                    // Insertar en la tabla de vencimientos
                    string query = "INSERT INTO vencimientos (idRegistro, fechaPago, fechaVencimiento, medioPago, cuotas) VALUES (@idRegistro, @fechaPago, @fechaVencimiento, @medioPago, @cuotas)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idRegistro", nroRegistro);
                        command.Parameters.AddWithValue("@fechaPago", fechaActual);
                        command.Parameters.AddWithValue("@fechaVencimiento", proximoVencimiento);
                        command.Parameters.AddWithValue("@medioPago", medioPago);
                        command.Parameters.AddWithValue("@cuotas", cuotas);

                        command.ExecuteNonQuery();
                    }

                    // Actualizar condición de la persona
                    string updateQuery = "UPDATE persona SET condicion = 1 WHERE idRegistro = @idRegistro";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@idRegistro", nroRegistro);
                        updateCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pago realizado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnComprobanteS.Enabled = true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al procesar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
