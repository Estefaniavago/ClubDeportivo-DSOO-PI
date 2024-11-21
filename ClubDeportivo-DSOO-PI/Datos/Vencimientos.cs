using System;
using System.Collections.Generic;
using System.Data;
using ClubDeportivo.Datos;
using ClubDeportivo_DSOO_PI.Entidades;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClubDeportivo_DSOO_PI.Datos
{
    internal class Vencimientos
    {
        // Método para obtener los vencimientos desde la base de datos
        public List<E_Vencimientos> ObtenerVencimientos(DateTime? fechaFiltro = null)
        {
            List<E_Vencimientos> listaVencimientos = new List<E_Vencimientos>();

            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            v.idPago,
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

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaVencimientos.Add(new E_Vencimientos
                                {
                                    idPago = Convert.ToInt32(reader["idPago"]),
                                    idRegistro = Convert.ToInt32(reader["idRegistro"]),
                                    fechaVencimiento = Convert.ToDateTime(reader["fechaVencimiento"]),
                                    //medioPago = string.Empty, // No se obtiene en esta consulta
                                    //cuotas = string.Empty,    // No se obtiene en esta consulta
                                    //fechaPago = DateTime.MinValue, // Placeholder, no se obtiene en esta consulta
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los vencimientos: " + ex.Message);
                }
            }

            return listaVencimientos;
        }

        public void InsertarVencimiento(int nroRegistro, DateTime fechaActual, DateTime proximoVencimiento, string medioPago, string cuotas, Button btnComprobanteS)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

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
