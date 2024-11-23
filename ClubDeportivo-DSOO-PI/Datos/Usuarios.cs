using ClubDeportivo_DSOO_PI.Datos;
using ClubDeportivo_DSOO_PI.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo.Datos
{
    internal class Usuarios
    {
        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string L_usu, string P_usu)
        {
            DataTable tabla = new DataTable(); // Tabla para almacenar los resultados
            MySqlConnection sqlCon = null; // Declarar la conexión
            try
            {
                // Crear la conexión
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Comando para el procedimiento almacenado
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Definir los parámetros del procedimiento almacenado
                comando.Parameters.Add("usu", MySqlDbType.VarChar).Value = L_usu;
                comando.Parameters.Add("pass", MySqlDbType.VarChar).Value = P_usu;

                // Abrir la conexión
                sqlCon.Open();

                // Ejecutar el comando y cargar los resultados en la tabla
                using (MySqlDataReader resultado = comando.ExecuteReader())
                {
                    tabla.Load(resultado);
                }

                return tabla; // Devolver los resultados
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al conectarse a la base de datos. Por favor, revise los datos ingresados y vuelva a intentar.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado. Inténtelo nuevamente.", ex);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}