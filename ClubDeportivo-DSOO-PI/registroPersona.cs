using ClubDeportivo_DSOO_PI.Entidades; // Referencia a la carpeta de Entidades
using ClubDeportivo_DSOO_PI.Datos; // Referencia a la carpeta de Datos
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace ClubDeportivo_DSOO_PI
{
    public partial class registroPersona : Form
    {

        //Inicializo el formulario
        public registroPersona()
        {
            InitializeComponent();
            btnPagarPrimerCuota.Enabled = false;//Deshabilito el boton de pagar primer cuota 
            cboxTipoDocumento.SelectedItem = "DNI";//al cargar el formulario por defecto aparece cargado el dni
        }

        //BOTON REGISTRAR 
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try 
            
            { 

            // Validar que los campos obligatorios estén completos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
                || string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos (*)",
                    "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida que el formato del número de documento sea válido
            if (!int.TryParse(txtNumero.Text, out int nroDoc))
            {
                    MessageBox.Show("El formato del número de documento ingresado no es válido. Intente nuevamente",
                    "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            
                //Toma los datos cargados en el formulario .
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string tipoDoc = cboxTipoDocumento.SelectedItem.ToString();
                bool aptoFisico = chkAptoFisico.Checked;


            // Crear el objeto de tipo E_Persona 
            E_Persona nuevaPersona = new E_Persona()
            {
                nombre = nombre,
                apellido = apellido,
                tipodoc = tipoDoc,
                nrodoc = nroDoc,
                aptofisico = aptoFisico,
                condicion = false
            };

            // Llamar al método de la clase Persona para registrar al nuevo usuario en la bbdd
            Persona datosPersona = new Persona();
            string respuesta = datosPersona.Nuevo_Registro(nuevaPersona);
            /* En respuesta se guarda si se pudo agregar o no. Si la respuesta es 1, ya existe el usuario.
            Si no existe devuelve un numero de registro (pk de la tabla persona autoincremental) */


            if (int.TryParse(respuesta, out int codigo))
            {
                if (codigo == 1)
                {

                        MessageBox.Show($"La persona ya existe en el sistema",
                            "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                else
                {

                    MessageBox.Show($"Registro exitoso. Código de Usuario: {respuesta}.",
                        "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ACA PODRIAMOS AGREGAR LA ADVERTENCIA DE ENTREGAR APTO FISICO
                    btnPagarPrimerCuota.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Error al registrar al usuario.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch(Exception ex)

            {
             MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
                     
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumero.Text = "";
            chkAptoFisico.Checked = false;
            btnPagarPrimerCuota.Enabled = false;
        }

        private void btnPagarPrimerCuota_Click(object sender, EventArgs e)
        {

            // Crear una nueva instancia del formulario de pago
            frmPagoCuotaMensual formulario = new frmPagoCuotaMensual();
         
            formulario.Show(); // Mostrar el formulario como modal
            

        }
       
    }
}