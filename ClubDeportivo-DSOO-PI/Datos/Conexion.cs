using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Referencia a MySQL (se agrega como libreria)
using MySql.Data.MySqlClient;


namespace ClubDeportivo.Datos
{
    public class Conexion // la clase debe ser PUBLICA
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;
        private Conexion() // asignamos valores a las variables de la conexion
        {
            baseDatos = "proyecto";
            servidor = "localhost";
            puerto = "3306";
            usuario = "root";
            clave = "root";
        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + servidor +
                ";port=" + puerto +
                ";username=" + usuario +
                ";password=" + clave +
                ";Database=" + baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
};