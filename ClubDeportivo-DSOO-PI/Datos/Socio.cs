using MySql.Data.MySqlClient;
using System;
using ClubDeportivo_DSOO_PI.Entidades;
using ClubDeportivo.Datos;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI.Datos
{
    public class Socio
    {
        public static E_Socio ObtenerDatosSocio(int nroRegistro)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                string query = @"
                SELECT 
                    p.idRegistro, 
                    p.nombre, 
                    p.apellido, 
                    p.tipodoc, 
                    p.nrodoc, 
                    p.condicion, 
                    v.fechaVencimiento
                FROM persona p
                LEFT JOIN vencimientos v ON p.idRegistro = v.idRegistro
                WHERE p.idRegistro = @nroRegistro
                ORDER BY v.fechaVencimiento DESC
                LIMIT 1;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nroRegistro", nroRegistro);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new E_Socio
                            {
                                idRegistro = Convert.ToInt32(reader["idRegistro"]),
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                tipodoc = reader["tipodoc"].ToString(),
                                nrodoc = Convert.ToInt32(reader["nrodoc"]),
                                condicion = Convert.ToBoolean(reader["condicion"]),
                                fechaVencimiento = reader["fechaVencimiento"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["fechaVencimiento"])
                                    : (DateTime?)null
                            };
                        }
                    }
                }
            }
            return null; // Si no se encuentra, retorna null
        }
    
    //public void InsertarVencimiento(int nroRegistro, DateTime fechaActual, DateTime proximoVencimiento, string medioPago, string cuotas, Button btnComprobanteS)
    //{
    //    using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
    //    {
    //        try
    //        {
    //            connection.Open();

    //            // Insertar en la tabla de vencimientos
    //            string query = "INSERT INTO vencimientos (idRegistro, fechaPago, fechaVencimiento, medioPago, cuotas) VALUES (@idRegistro, @fechaPago, @fechaVencimiento, @medioPago, @cuotas)";
    //            using (MySqlCommand command = new MySqlCommand(query, connection))
    //            {
    //                command.Parameters.AddWithValue("@idRegistro", nroRegistro);
    //                command.Parameters.AddWithValue("@fechaPago", fechaActual);
    //                command.Parameters.AddWithValue("@fechaVencimiento", proximoVencimiento);
    //                command.Parameters.AddWithValue("@medioPago", medioPago);
    //                command.Parameters.AddWithValue("@cuotas", cuotas);

    //                command.ExecuteNonQuery();
    //            }

    //            // Actualizar condición de la persona
    //            string updateQuery = "UPDATE persona SET condicion = 1 WHERE idRegistro = @idRegistro";
    //            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
    //            {
    //                updateCommand.Parameters.AddWithValue("@idRegistro", nroRegistro);
    //                updateCommand.ExecuteNonQuery();
    //            }

    //            MessageBox.Show("Pago realizado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //            btnComprobanteS.Enabled = true;
    //        }
    //        catch (MySqlException ex)
    //        {
    //            MessageBox.Show("Error al procesar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //    }
    //}
    
    }

}