using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI.Datos
{
    internal class Actividad
    {
        public static List<string> CargarActividades()
        {
            List<string> actividades = new List<string>();

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
                            actividades.Add(reader["Nombre"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return actividades;
        }
                 // Método estático para obtener los detalles de la actividad (precio, horarios, días)
            public static DataTable ObtenerDetallesActividad(string nombreActividad)
            {
                DataTable horariosTable = new DataTable();

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
                            command.Parameters.AddWithValue("@Nombre", nombreActividad);

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(horariosTable);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los detalles de la actividad: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return horariosTable;
            }
        }

    }