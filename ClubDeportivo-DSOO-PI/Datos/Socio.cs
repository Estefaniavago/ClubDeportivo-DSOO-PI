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
        public static bool ValidarSocio(E_Socio socio)
        {
            if (socio == null || socio.fechaVencimiento == null || socio.fechaVencimiento <= DateTime.Now)
            {
                return false; // No es socio válido o está vencido
            }
            return true; // Socio válido y habilitado
        }

    }

}