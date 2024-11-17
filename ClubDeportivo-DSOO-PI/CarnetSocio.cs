using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class CarnetSocio : Form

    {
        private string nroRegistro;
        string nombre;
        string apellido;
        string dni;
        string fechavencimiento;
        public CarnetSocio()
        {
            InitializeComponent();
        }

        private void txtNroSocio_TextChanged(object sender, EventArgs e)
        {
            nroRegistro = txtNroSocio.Text;
        }

        private void CarnetSocio_Load(object sender, EventArgs e)
        {
            btnImprimirCarnet.Enabled = false;
        }

        private void btnValidarSocio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nroRegistro, out int registroId))
            {
                ValidarRegistro(registroId);
                MessageBox.Show("Validado");
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
                        SELECT p.nombre, p.apellido, p.nrodoc, v.fechaVencimiento
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
                                dni= reader["nrodoc"].ToString();
                                DateTime? fechaVencimiento = reader["fechaVencimiento"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["fechaVencimiento"])
                                    : (DateTime?)null;
                                fechavencimiento = reader["fechaVencimiento"].ToString();

                                if (fechaVencimiento == null || fechaVencimiento <= DateTime.Now)
                                {
                                    MessageBox.Show($"Ingreso fallido. Bienvenid@");
                                    btnImprimirCarnet.Enabled = true; // Habilitar el btón par aimprimir el carnet una vez validado que es socio y tiene la cuota al dia

                                }
                                else
                                {
                                   
                                    MessageBox.Show($"Ingreso exitoso. Bienvenid@");
                                    btnImprimirCarnet.Enabled = true; // Habilitar el botón de pago
                                    // Asignar los valores recibidos a los campos del formulario
                                    txtNombreSocio.Text = nombre;
                                    txtApellidoSocio.Text = apellido;
                                    txtDniSocio.Text = dni;
                                    txtFechaVencimientoSocio.Text = fechavencimiento;


                                    // Configurar los TextBox como de solo lectura
                                    txtNombreSocio.ReadOnly = true;
                                    txtApellidoSocio.ReadOnly = true;
                                    txtDniSocio.ReadOnly = true;
                                    txtFechaVencimientoSocio.ReadOnly = true;
                                    MessageBox.Show($"Nombre: {nombre}, Apellido: {apellido}");
                                }
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

        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            /* Eliminamos el boton imprimir y validar de la vista que se va a imprimir*/
            btnImprimirCarnet.Visible = false;
            btnValidarSocio.Visible = false;
            /* Creamos objeto para imprimir*/
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(imprimirComprobanteNs);
            pd.Print();
            btnImprimirCarnet.Visible = true; // visualizamos nuevamente el boton de imprimir


            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }
        private void imprimirComprobanteNs(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
    }

        
    

