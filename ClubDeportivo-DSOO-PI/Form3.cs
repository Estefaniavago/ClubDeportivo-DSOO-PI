using ClubDeportivo_DSOO_PI.Entidades; // Referencia a la carpeta de Entidades
using ClubDeportivo_DSOO_PI.Datos; // Referencia a la carpeta de Datos
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class registroUsuario : Form
    {
        public registroUsuario()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Cargar todos los usuarios cuando se abra el formulario
            CargarUsuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recoger los datos del formulario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string tipoDoc = cboxTipoDocumento.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(tipoDoc))
            {
                MessageBox.Show("Debe seleccionar un tipo de documento.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nroDoc = Convert.ToInt32(txtNumero.Text);
            bool aptoFisico = chkAptoFisico.Checked;

            // Crear el objeto de tipo E_Persona
            E_Persona nuevaPersona = new E_Persona()
            {
                nombre = nombre,
                apellido = apellido,
                tipodoc = tipoDoc,
                nrodoc = nroDoc,
                aptofisico = aptoFisico
            };

            // Llamar al método de la clase Persona para registrar al nuevo usuario
            Persona datosPersona = new Persona();
            string respuesta = datosPersona.Nuevo_Registro(nuevaPersona);

            if (int.TryParse(respuesta, out int codigo))
            {
                if (codigo == 1)
                {
                    MessageBox.Show("El usuario ya existe.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Registro exitoso. Código de Usuario: {respuesta}", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios(); // Refrescar la lista de usuarios después del registro
                }
            }
            else
            {
                MessageBox.Show("Error al registrar al usuario.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método para manejar el evento CheckedChanged del checkbox chkAptoFisico
        private void chkAptoFisico_CheckedChanged(object sender, EventArgs e)
        {
            // Este método puede estar vacío o puedes agregar lógica adicional si necesitas hacer algo cada vez que cambie el estado del checkbox
        }



        // Método para cargar la lista de usuarios en el DataGridView
        private void CargarUsuarios()
        {
            try
            {
                Persona personaDatos = new Persona();
                DataTable usuarios = personaDatos.ObtenerUsuarios();

                usuarios.Columns.Add("EstadoSocio", typeof(string));

                foreach (DataRow row in usuarios.Rows)
                {
                    row["EstadoSocio"] = (bool)row["condicion"] ? "Socio" : "No Socio";
                }
                // Asignar el DataTable al DataGridView
                dtgvRegistro.DataSource = usuarios;
            
                if (dtgvRegistro.Columns.Contains("condicion"))
            {
                dtgvRegistro.Columns["condicion"].Visible = false;
            }

            // Cambiar el encabezado de la columna "EstadoSocio"
            if (dtgvRegistro.Columns.Contains("EstadoSocio"))
            {
                dtgvRegistro.Columns["EstadoSocio"].HeaderText = "Socio / No Socio";
            }
        }
    catch (Exception ex)
    {
        MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
    }
}