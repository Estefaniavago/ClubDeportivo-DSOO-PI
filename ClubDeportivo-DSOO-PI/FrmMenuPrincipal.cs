using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class frmPrincipal : BaseForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
            //ESTILOS
            this.StartPosition = FormStartPosition.Manual; // posición manual
            this.Size = new Size(850, 450); // tamaño
            this.Location = new Point(100, 100); // posición en la pantalla
            
        }

     
        //BOTON PARA REGISTRAR PERSONAS
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
            registroPersona formRegistrarPersona = new registroPersona();// Instancia del formulario de registro de persona
            MostrarFormularioEnPanel(formRegistrarPersona);//Muestra el formulario en el panel 2
        }

        //BOTON PARA VER LA GRILLA CON LAS PERSONAS REGISTRADAS
        private void btnGrillaPr_Click(object sender, EventArgs e)
        {
            
            PersonasRegistradas PersonasRegistradasForm = new PersonasRegistradas();
            MostrarFormularioEnPanel(PersonasRegistradasForm);
        }

        //BOTON QUE MUESTRA EL LISTADO DE VENCIMIENTOS
        private void btnListado_Click(object sender, EventArgs e)
        {
            frmVencimientos vencimientosForm = new frmVencimientos();
            MostrarFormularioEnPanel(vencimientosForm);
        }

        //BOTON DE PAGO MENSUAL- Para cobrar la cuota a los socios
        private void btnPagoMensual_Click(object sender, EventArgs e)
        {
            frmPagoCuotaMensual pagoCuotaForm = new frmPagoCuotaMensual();
            MostrarFormularioEnPanel(pagoCuotaForm);
        }

        //BOTON PARA PAGAR ACTIVIDADES PARA LOS NO SOCIOS
        private void btnPagoActividad_Click(object sender, EventArgs e)
        {
            frmPagoNoSocio formPagoActividades = new frmPagoNoSocio();
            MostrarFormularioEnPanel(formPagoActividades);
            
        }

        //BOTON PARA EMITIR CARNET PARA LOS SOCIOS
        private void btnCarnet_Click(object sender, EventArgs e)
        {
            CarnetSocio formCarnet = new CarnetSocio();
            MostrarFormularioEnPanel(formCarnet);
        }

         
        //BOTON PARA SALIR DEL SISTEMA
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego.");
            Application.Exit();
        }
       
        
        // Método para cargar un formulario en panel2 sin bordes ni título
        private void MostrarFormularioEnPanel(Form formulario)
        {
            // Limpiar cualquier formulario presente en panel2
            panel2.Controls.Clear();

            // Configurar el formulario para cargar en el panel sin bordes ni título
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario a panel2 y mostrar
            panel2.Controls.Add(formulario);
            formulario.Show();
        }

    }
}

