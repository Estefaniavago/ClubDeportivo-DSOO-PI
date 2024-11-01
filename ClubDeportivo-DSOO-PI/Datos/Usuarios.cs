﻿using ClubDeportivo_DSOO_PI.Datos;
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
        //Método para agregar persona
        public string RegistrarPersona(E_Persona persona)
        {
            string respuesta = "";
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarPersona", sqlCon); // Supongamos que tienes un procedimiento almacenado llamado RegistrarPersona
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nom", MySqlDbType.VarChar).Value = persona.nombre;
                comando.Parameters.Add("ape", MySqlDbType.VarChar).Value = persona.apellido;
                comando.Parameters.Add("tipo", MySqlDbType.VarChar).Value = persona.tipodoc;
                comando.Parameters.Add("doc", MySqlDbType.Int32).Value = persona.nrodoc;
                comando.Parameters.Add("apto", MySqlDbType.Bit).Value = persona.aptofisico;
                comando.Parameters.Add("cond", MySqlDbType.Bit).Value = persona.condicion;

                MySqlParameter resParam = new MySqlParameter("res", MySqlDbType.Int32);
                resParam.Direction = ParameterDirection.Output;
                comando.Parameters.Add(resParam);

                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                respuesta = filasAfectadas > 0 ? "Registro exitoso" : "Error al registrar";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return respuesta;
        }



        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string L_usu, string P_usu)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                // el comando es un elemento que almacena en este caso el nombre

                // del procedimiento almacenado y la referencia a la conexion

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("usu", MySqlDbType.VarChar).Value = L_usu;
                comando.Parameters.Add("pass", MySqlDbType.VarChar).Value = P_usu;

                // abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // almacenamos el resulatdo en la variable

                tabla.Load(resultado); // cargamos la tabla con el resultado

                return tabla;

                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL

            }
            catch (Exception ex)
            {
                throw;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}