using ClubDeportivo.Datos;
using ClubDeportivo_DSOO_PI.Datos;
using ClubDeportivo_DSOO_PI.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class CarnetSocio : BaseForm

    {
        private string nroRegistro;
       // string nombre;
        //string apellido;
       // string dni;
        //string fechavencimiento;
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

        //Verifica que el campo no este vacio y tenga un numero de registro valido
        private void btnValidarSocio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNroSocio.Text)) {  
                if (int.TryParse(nroRegistro, out int registroId))
                {
                     ValidarRegistro(registroId);

                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de registro válido.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            else
            {

                MessageBox.Show("Por favor, ingrese un número de registro .", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroSocio.Text = "";//Limpia el textbox
            }
        }
        private void ValidarRegistro(int nroRegistro)
        {
            try
            {
                // Obtener datos del socio
                E_Socio socio = Socio.ObtenerDatosSocio(nroRegistro);

                if (!Socio.ValidarSocio(socio))
                {
                    MessageBox.Show($"La persona no es socia o posee su cuota vencida. No se puede emitir carnet");
                    txtNroSocio.Text = ""; // Limpia el textbox
                    return;
                }

                // Socio válido: actualizar campos del formulario
                txtNombreSocio.Text = socio.nombre;
                txtApellidoSocio.Text = socio.apellido;
                txtDniSocio.Text = socio.nrodoc.ToString();
                txtFechaVencimientoSocio.Text = socio.fechaVencimiento?.ToShortDateString();

                // Configurar los TextBox como de solo lectura
                txtNombreSocio.ReadOnly = true;
                txtApellidoSocio.ReadOnly = true;
                txtDniSocio.ReadOnly = true;
                txtFechaVencimientoSocio.ReadOnly = true;

                btnImprimirCarnet.Enabled = true; // Habilitar el botón
                MessageBox.Show("Validado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al acceder a la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

       private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            var vistaCarnet = new ModalVistaCarnet(txtNombreSocio.Text,txtApellidoSocio.Text,txtDniSocio.Text,txtFechaVencimientoSocio.Text);
            vistaCarnet.ShowDialog();
        }
       
        
    }}
    

        
    

