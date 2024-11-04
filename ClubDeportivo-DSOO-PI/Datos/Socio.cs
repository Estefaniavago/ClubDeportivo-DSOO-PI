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
    public class Socio
    {
        public string Nuevo_Registro(E_Persona persona)
        {
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
        {
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
    }
}