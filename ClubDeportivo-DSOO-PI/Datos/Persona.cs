using ClubDeportivo.Datos;
using ClubDeportivo_DSOO_PI.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo_DSOO_PI.Datos
{
    public class Persona
    {
        public string Nuevo_Registro(E_Persona persona)
        {/*Nuevo_Registro: Este método se encarga de insertar un nuevo registro 
  * en la base de datos a través de un procedimiento almacenado llamado Nuevo_Registro.

Parámetro de entrada: Recibe un objeto de tipo E_Persona, que contiene los datos de una persona 
    (nombre, apellido, tipo de documento, número de documento, apto físico, condición).
Conexión y comandos: Se conecta a la base de datos usando Conexion.getInstancia().CrearConexion() 
    y ejecuta el procedimiento almacenado, pasando cada propiedad de persona como parámetros de entrada 
    (nom, ape, tipo, doc, apto, cond).
Parámetro de salida: Define un parámetro de salida res que obtiene el resultado del procedimiento almacenado 
    (se asume que podría ser un ID o un código de éxito).
Retorno: Devuelve el valor de res como una cadena. Si ocurre una excepción, 
    lanza un mensaje de error personalizado.
*/
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand("Nuevo_Registro", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("nom", persona.nombre);
                comando.Parameters.AddWithValue("ape", persona.apellido);
                comando.Parameters.AddWithValue("tipo", persona.tipodoc);
                comando.Parameters.AddWithValue("doc", persona.nrodoc);
                comando.Parameters.AddWithValue("apto", persona.aptofisico);
                comando.Parameters.AddWithValue("cond", persona.condicion);

                MySqlParameter resParam = new MySqlParameter("res", MySqlDbType.Int32);
                resParam.Direction = ParameterDirection.Output;
                comando.Parameters.Add(resParam);

                comando.ExecuteNonQuery();
                
                return resParam.Value.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el registro: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable ObtenerUsuarios()
        {/* ObtenerUsuarios: Este método obtiene una lista de usuarios 
          (en este caso, registros de personas) de la base de datos.

        Consulta SQL: Ejecuta una consulta directa a la tabla persona con SELECT * FROM persona.
    Adaptador y DataTable: Utiliza MySqlDataAdapter para llenar un DataTable 
            con los resultados de la consulta.
    Retorno: Devuelve el DataTable lleno con los datos obtenidos de la tabla persona. 
            Si ocurre un error, lanza un mensaje de excepción personalizado.*/

            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM persona", sqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable personas = new DataTable();
                adapter.Fill(personas);
                return personas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los usuarios: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public bool EliminarRegistro(int idRegistro)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand("DELETE FROM persona WHERE id = @idRegistro", sqlCon);
                comando.Parameters.AddWithValue("@idRegistro", idRegistro);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0; // Retorna true si al menos una fila fue eliminada
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el registro: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}