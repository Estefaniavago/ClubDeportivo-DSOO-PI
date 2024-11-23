using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Microsoft.VisualBasic;
using ClubDeportivo_DSOO_PI;


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
            // variables usadas para larepetición de líneas de código
            bool correcto = false;
           
            // creamos las variables para recibir los datos desde el
            //teclado


            string T_servidor = "Servidor" ;
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave"; // se antepuso la T para indicar
//que vienen desde TECLADO


    while (correcto != true)
    {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = CustomInputBox.Show("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = CustomInputBox.Show("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = CustomInputBox.Show("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = CustomInputBox.Show("Ingrese clave", "DATOS DE INSTALACIÓN MySQL");

                // Mostrar el mensaje con el nuevo modal
                string mensaje = $"Su ingreso:\nSERVIDOR = {T_servidor}\nPUERTO = {T_puerto}\nUSUARIO = {T_usuario}\nCLAVE = {T_clave}";
                ModalConectionForm modal = new ModalConectionForm(mensaje, "AVISO DEL SISTEMA");
                modal.ShowDialog();

                // Evaluar la respuesta del usuario
                if (modal.UserChoice) // Si elige "Sí", se confirma la configuración
                {
                    correcto = true;
                }
                else
                {
                    MessageBox.Show("Ingrese nuevamente los datos", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // reemplazamos los datos concretos que teniamos por las
            //variables
            this.baseDatos = "proyecto";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; //"3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave;


        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
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