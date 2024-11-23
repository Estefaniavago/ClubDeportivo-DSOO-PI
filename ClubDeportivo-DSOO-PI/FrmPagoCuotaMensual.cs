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
using ClubDeportivo_DSOO_PI.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivo_DSOO_PI
{
    public partial class frmPagoCuotaMensual : BaseForm
    {

        public Form FormularioOrigen { get; set; } // Propiedad para almacenar el formulario de origen
        private string nroRegistro; // En la BBDD es idRegistro
        string montoTotal = "30000"; // Monto total de la cuota mensual para todos los socios
        string nombre;
        string apellido;
        

        //public string NroRegistro { get; set; }

        public frmPagoCuotaMensual()
        {
            InitializeComponent();
            btnPagar.Enabled = false; // Deshabilitado el pago hasta que esté validado el registro
            btnComprobanteS.Enabled = false;//Deshabilitado el comprobante hasta que esté pago
        }


        // Botón para validar el número de registro
        private void btnValidar_Click(object sender, EventArgs e)
        {
           //Lee numero de registro
            nroRegistro = txtNroRegistro.Text;

            //Valida si el textbox está vacio o se ingresó un número no valido
            if (string.IsNullOrEmpty(nroRegistro) || !int.TryParse(nroRegistro, out int registroId))
            {
                MessageBox.Show("Por favor, ingrese un número de registro válido.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Método para validar el registro
            ValidarRegistro(registroId);
        }

        //Método para validar el número de registro
        private void ValidarRegistro(int nroRegistro)

        {            
            try
            {
                E_Socio socio = Socio.ObtenerDatosSocio(nroRegistro);

                if (socio != null)
                {
                    // Asignar nombre y apellido al formulario actual
                    this.nombre = socio.nombre;
                    this.apellido = socio.apellido;
                    lblResultado.Text = $"{socio.nombre} {socio.apellido} ";

                    if (socio.condicion) // Es un socio
                    {
                        lblResultado.Text += socio.EstadoCuota;
                        lblResultado.ForeColor = socio.fechaVencimiento == null || socio.fechaVencimiento <= DateTime.Now
                            ? Color.Red
                            : Color.Green;
                        btnPagar.Enabled = socio.fechaVencimiento == null || socio.fechaVencimiento <= DateTime.Now;
                    }
                    else
                    {
                        lblResultado.Text += "No es socio. Puede pagar para convertirse en socio.";
                        lblResultado.ForeColor = Color.Blue;
                        btnPagar.Enabled = true;
                    }
                }
                else
                {
                    lblResultado.Text = "No corresponde a un cliente registrado.";
                    lblResultado.ForeColor = Color.Red;
                    btnPagar.Enabled = false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
                       
            string medioPago = rdEfectivo.Checked ? "Efectivo" : rdCredito.Checked ? "Crédito" : "";

            //Valida que se haya seleccionado un metodo de pago
            if (string.IsNullOrEmpty(medioPago))
            {
                MessageBox.Show("Por favor, seleccione un medio de pago.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //en caso de elegir efectivo se asegura que se guarde con 0 cuotas
            if (rdEfectivo.Checked)
            {
                cbCuotas.SelectedItem = "0";
                cbCuotas.Text = "";
                
            }
            if (rdCredito.Checked)
            {
                if (cbCuotas.SelectedIndex==0)
                {
                    cbCuotas.Text = "1";
                }else if (cbCuotas.SelectedIndex == 1)
                {
                    cbCuotas.Text = "3";
                } else if (cbCuotas.SelectedIndex == 2)
                {
                    cbCuotas.Text = "6";
                }
                else
                {
                    cbCuotas.Text = "1";
                }
               
            }
            
            DateTime fechaActual = DateTime.Now;
            DateTime proximoVencimiento = fechaActual.AddMonths(1);

            // instancia de la clase Vencimientos
            Vencimientos vencimiento = new Vencimientos();

            // llama al método InsertarVencimiento
            vencimiento.InsertarVencimiento(
                int.Parse(nroRegistro), // convierte nroRegistro a int
                fechaActual,
                proximoVencimiento,
                medioPago,
                cbCuotas.Text,
                btnComprobanteS
            );
            // Deshabilitar el botón de pago y mostrar un mensaje de confirmación
            btnPagar.Enabled = false;
            btnComprobanteS.Enabled = true; // Habilitar comprobante
            lblResultado.Text = "Pago registrado exitosamente.";
            lblResultado.ForeColor = Color.Green;
        }

       
        private void btnComprobante_Click(object sender, EventArgs e)
        {

            //Instancia al comprobante y le pasa los datos cargados
            frmComprobanteSocio comprobanteForm = new frmComprobanteSocio(this)

            {
                Nombre = this.nombre,
                Apellido = this.apellido,
                Montocuota = montoTotal,
                FechaPago = DateTime.Now.ToShortDateString(),
                MedioPago = rdEfectivo.Checked ? "Efectivo" : rdCredito.Checked ? "Crédito" : "N/A",
                Cuotas = cbCuotas.Text,
             
            };

            // Ocultar el formulario actual y abrir el comprobante
            this.Hide();
            comprobanteForm.ShowDialog();

        }
         private void btnVolver_Click(object sender, EventArgs e)
        {
            // Verificar el origen y regresar al formulario correspondiente
            if (FormularioOrigen is registroPersona registroPersonaForm)
            {
                registroPersonaForm.Show(); // Mostrar el formulario de registroPersona si es el origen
            }
            else
            {
                frmPrincipal formPrincipal = new frmPrincipal();
                formPrincipal.Show(); // Si no viene de registroPersona, regresa al menú principal
            }

            this.Close(); // Cerrar el formulario actual
        }


        private void frmPagoCuotaMensual_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "Ingrese el número de registro y presione Validar.";
            lblResultado.ForeColor = Color.Black;
            btnPagar.Enabled = false;
            btnVolver.Visible = FormularioOrigen is registroPersona;

            // Si ya se validó un registro anteriormente, vuelve a comprobar su estado
            if (!string.IsNullOrEmpty(nroRegistro) && int.TryParse(nroRegistro, out int registroId))
            {
                ValidarRegistro(registroId);
            }
        }
         
       
        

        public void LimpiarFormulario()
        {
            // Limpiar todos los controles y resetear el formulario
            txtNroRegistro.Clear();
            lblResultado.Text = "Ingrese el número de registro y presione Validar.";
            lblResultado.ForeColor = Color.Black;
            rdEfectivo.Checked = false;
            rdCredito.Checked = false;
            cbCuotas.SelectedIndex = -1;
            btnPagar.Enabled = false;
            btnComprobanteS.Enabled = false;
        }
    }
}
    
