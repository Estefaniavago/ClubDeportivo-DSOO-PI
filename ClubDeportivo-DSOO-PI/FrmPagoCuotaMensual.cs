using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using ClubDeportivo_DSOO_PI.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivo_DSOO_PI
{
    public partial class frmPagoCuota : Form
    {
        private string nroRegistro; // en la BBDD es idRegistro
        private string comprobante; // para almacenar el comprobante generado

        public frmPagoCuota()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void txtNroRegistro_TextChanged(object sender, EventArgs e)
        {
            nroRegistro = txtNroRegistro.Text;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nroRegistro, out int registroId))
            {
                buscarRegistro(registroId);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de registro válido.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarRegistro(int nroRegistro)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM persona WHERE idRegistro = @nroRegistro";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nroRegistro", nroRegistro);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string nombre = reader["nombre"].ToString();
                                    string apellido = reader["apellido"].ToString();
                                    MessageBox.Show($"Registro encontrado:\nNombre: {nombre}\nApellido: {apellido}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro con el número especificado.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al acceder a la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Determina el medio de pago seleccionado
            string medioPago = "";
            if (rdEfectivo.Checked)
            {
                medioPago = "Efectivo";
            }
            else if (rdDebito.Checked)
            {
                medioPago = "Débito";
            }
            else if (rdCredito.Checked)
            {
                medioPago = "Crédito";
            }

            // Verifica que se haya seleccionado un medio de pago
            if (string.IsNullOrEmpty(medioPago))
            {
                MessageBox.Show("Por favor, seleccione un medio de pago.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular la fecha del próximo vencimiento
            DateTime fechaActual = DateTime.Now;
            DateTime proximoVencimiento = fechaActual.AddMonths(1); // Sumar un mes a la fecha actual para el próximo vencimiento

            // Generar el comprobante de pago
            comprobante = $"Comprobante de Pago:\n" +
                          $"Número de Registro: {nroRegistro}\n" +
                          $"Medio de Pago: {medioPago}\n" +
                          $"Fecha de Pago: {fechaActual.ToShortDateString()}\n" +
                          $"Próximo Vencimiento: {proximoVencimiento.ToShortDateString()}";

            MessageBox.Show("Pago realizado exitosamente. Comprobante generado.", "Confirmación de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comprobante))
            {
                MessageBox.Show(comprobante, "Comprobante de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay ningún comprobante generado aún.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}