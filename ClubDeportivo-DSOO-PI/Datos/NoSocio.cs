using ClubDeportivo.Datos;
using ClubDeportivo_DSOO_PI.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo_DSOO_PI.Datos
{

    //  -----------------------arreglar clase no socio------------------
    internal class NoSocio
    {
        //        public bool RegistrarNoSocio(E_NoSocio noSocio)
        //        {
        //            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
        //            {
        //                try
        //                {
        //                    connection.Open();
        //                    string query = @"
        //                        INSERT INTO no_socio (idPersona, actividadElegida, precio, fechaPago)
        //                        VALUES (@idPersona, @actividadElegida, @precio, @fechaPago);";

        //                    using (MySqlCommand command = new MySqlCommand(query, connection))
        //                    {
        //                        command.Parameters.AddWithValue("@idPersona", noSocio.idRegistro);
        //                        command.Parameters.AddWithValue("@actividadElegida", noSocio.actividadElegida);
        //                        command.Parameters.AddWithValue("@precio", noSocio.precio);
        //                        command.Parameters.AddWithValue("@fechaPago", DateTime.Now);

        //                        command.ExecuteNonQuery();
        //                    }
        //                    return true;
        //                }
        //                catch (MySqlException ex)
        //                {
        //                    throw new Exception("Error al registrar NoSocio: " + ex.Message);
        //                }
        //            }
        //        }

        //        public DataTable ObtenerNoSocios()
        //        {
        //            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
        //            {
        //                try
        //                {
        //                    connection.Open();
        //                    string query = "SELECT * FROM no_socio;";

        //                    using (MySqlCommand command = new MySqlCommand(query, connection))
        //                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
        //                    {
        //                        DataTable dt = new DataTable();
        //                        adapter.Fill(dt);
        //                        return dt;
        //                    }
        //                }
        //                catch (MySqlException ex)
        //                {
        //                    throw new Exception("Error al obtener NoSocios: " + ex.Message);
        //                }
        //            }
        //        }
        //    }
    }
}