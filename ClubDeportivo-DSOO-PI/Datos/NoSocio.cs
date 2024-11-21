using ClubDeportivo.Datos;
using ClubDeportivo_DSOO_PI.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI.Datos
{

    //  -----------------------arreglar clase no socio------------------
    internal class NoSocio
    {
        //       public class NoSocio

    // Método estático para registrar el pago de un no socio
    public static bool RegistrarPagoNoSocio(int idPersona, string actividadSeleccionada, string precio, string fechaPago)
        {
            // Buscar el NActividad correspondiente al nombre de la actividad seleccionada
            int nActividad = ObtenerNActividad(actividadSeleccionada);

            if (nActividad != -1)  // Si la actividad existe
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        connection.Open();

                        string query = @"INSERT INTO no_socio 
                                     (idPersona, actividadElegida, fechaPago) 
                                     VALUES 
                                     (@idPersona, @actividadElegida, @fechaPago)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idPersona", idPersona);
                            command.Parameters.AddWithValue("@actividadElegida", nActividad);
                            command.Parameters.AddWithValue("@fechaPago", fechaPago);

                            int result = command.ExecuteNonQuery();

                            return result > 0;  // Devuelve true si se registró correctamente
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("La actividad seleccionada no existe en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para obtener el NActividad de una actividad seleccionada
        private static int ObtenerNActividad(string actividadSeleccionada)
        {
            int nActividad = -1;  // Valor por defecto si no se encuentra la actividad

            // Establecer la consulta SQL para obtener el NActividad
            string query = @"SELECT NActividad 
                     FROM actividad 
                     WHERE Nombre = @Nombre";

            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Añadir el parámetro para la consulta
                        command.Parameters.AddWithValue("@Nombre", actividadSeleccionada);

                        // Ejecutar la consulta y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Si la consulta devuelve un valor, asignarlo a nActividad
                        if (result != null && result != DBNull.Value)
                        {
                            nActividad = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el NActividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return nActividad;
        }

    }

}