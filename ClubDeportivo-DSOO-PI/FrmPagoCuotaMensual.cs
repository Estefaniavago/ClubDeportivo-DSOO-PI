using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
    public partial class frmPagoCuotaMensual : Form
    {
        private string nroRegistro; // En la BBDD es idRegistro
        decimal montoTotal = 30000; // Monto total de la cuota mensual para todos los socios
        string nombre;
        string apellido;
        public string NroRegistro { get; set; }

        public frmPagoCuotaMensual()
        {
            InitializeComponent();
            btnPagar.Enabled = false; // Deshabilitado el pago hasta que esté validado el registro
            btnComprobanteS.Enabled = false;
        }

        private void txtNroRegistro_TextChanged(object sender, EventArgs e)
        {
            nroRegistro = txtNroRegistro.Text;
        }

        // Botón para validar el número de registro
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nroRegistro, out int registroId))
            {
                ValidarRegistro(registroId);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de registro válido.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarRegistro(int nroRegistro)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT p.nombre, p.apellido, v.fechaVencimiento
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
                                nombre = reader["nombre"].ToString();
                                apellido = reader["apellido"].ToString();
                                DateTime? fechaVencimiento = reader["fechaVencimiento"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["fechaVencimiento"])
                                    : (DateTime?)null;

                                if (fechaVencimiento == null || fechaVencimiento <= DateTime.Now)
                                {
                                    lblResultado.Text = $"{nombre} {apellido} debe pagar la cuota.";
                                    lblResultado.ForeColor = Color.Red;
                                    btnPagar.Enabled = true; // Habilitar el botón de pago
                                }
                                else
                                {
                                    lblResultado.Text = $"{nombre} {apellido} no necesita pagar la cuota. Vence el {fechaVencimiento.Value.ToShortDateString()}";
                                    lblResultado.ForeColor = Color.Green;
                                    btnPagar.Enabled = false; // Deshabilitar el botón de pago
                                }
                            }
                            else
                            {
                                lblResultado.Text = "No se encontró el registro.";
                                lblResultado.ForeColor = Color.Red;
                                btnPagar.Enabled = false;
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
            string medioPago = "";
            short cuotas = cbCuotas.Text == "1 CUOTA" ? (short)1 : cbCuotas.Text == "3 CUOTAS" ? (short)3 : (short)6;
            decimal montoPorCuota = montoTotal / cuotas;

            if (rdEfectivo.Checked)
            {
                medioPago = "Efectivo";
            }
            else if (rdCredito.Checked)
            {
                medioPago = "Crédito";
            }

            if (string.IsNullOrEmpty(medioPago))
            {
                MessageBox.Show("Por favor, seleccione un medio de pago.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaActual = DateTime.Now;
            DateTime proximoVencimiento = fechaActual.AddMonths(1);

            /* comprobante = $"Comprobante de Pago:\n" +
                           $"Número de Registro: {nroRegistro}\n" +
                           $"Medio de Pago: {medioPago}\n" +
                           $"Fecha de Pago: {fechaActual.ToShortDateString()}\n" +
                           $"Próximo Vencimiento: {proximoVencimiento.ToShortDateString()}\n" +
                           $"Monto Total: ${montoTotal}\n" +
                           $"Número de Cuotas: {cuotas}\n" +
                           $"Monto por Cuota: ${montoPorCuota}";*/

            RegistrarVencimiento(nroRegistro, fechaActual, proximoVencimiento, medioPago, cuotas);

            MessageBox.Show("Pago realizado exitosamente. Comprobante generado.", "Confirmación de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnComprobanteS.Enabled = true;
        }

        private void RegistrarVencimiento(string idRegistro, DateTime fechaPago, DateTime fechaVencimiento, string medioPago, int cuotas)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

                    // Verificar si ya existe un vencimiento activo
                    string checkQuery = "SELECT COUNT(*) FROM vencimientos WHERE idRegistro = @idRegistro AND fechaVencimiento > CURDATE()";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@idRegistro", idRegistro);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("El socio ya tiene un vencimiento activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    string query = "INSERT INTO vencimientos (idRegistro, fechaPago, fechaVencimiento, medioPago, cuotas) VALUES (@idRegistro, @fechaPago, @fechaVencimiento, @medioPago, @cuotas)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idRegistro", idRegistro);
                        command.Parameters.AddWithValue("@fechaPago", fechaPago);
                        command.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                        command.Parameters.AddWithValue("@medioPago", medioPago);
                        command.Parameters.AddWithValue("@cuotas", cuotas);

                        command.ExecuteNonQuery();
                    }
                    // Actualizar la tabla persona para establecer condicion = 1
                    string updateQuery = "UPDATE persona SET condicion = 1 WHERE idRegistro = @idRegistro";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@idRegistro", idRegistro);
                        updateCommand.ExecuteNonQuery();
                    }
                
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al registrar el vencimiento en la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {


            frmComprobanteSocio comprobanteForm = new frmComprobanteSocio
            {
                Nombre = nombre,
                Apellido = apellido,
                //Montocuota=montoTotal,


                FechaPago = DateTime.Now.ToShortDateString(),
                MedioPago = rdEfectivo.Checked ? "Efectivo" : rdCredito.Checked ? "Crédito" : "N/A",
                Cuotas = cbCuotas.Text
            };
            //MessageBox.Show($"Nombre: {nombre}, Apellido: {apellido}, Fecha: {comprobanteForm.FechaPago}, Medio de Pago: {comprobanteForm.MedioPago}");
            comprobanteForm.ShowDialog();

        }
        private void cbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmPagoCuotaMensual_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NroRegistro))
            {
                MessageBox.Show("No se recibió un número de registro válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cierra el formulario si el valor no es válido
                return;
            }

            // Muestra el número de registro en un label (opcional)
            lblRegistro.Text = $"Número de Registro: {NroRegistro}";

            // Valida el número de registro
            if (int.TryParse(NroRegistro, out int registroId))
            {
                ValidarRegistro(registroId);
            }
            else
            {
                MessageBox.Show("El número de registro no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cierra el formulario si el número no es válido
            }
        }
    }
}
    
