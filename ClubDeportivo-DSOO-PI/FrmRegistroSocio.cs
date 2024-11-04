using ClubDeportivo_DSOO_PI.Entidades; // Referencia a la carpeta de Entidades
using ClubDeportivo_DSOO_PI.Datos; // Referencia a la carpeta de Datos
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class registroSocio : Form
    {
        public registroSocio()
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

            // Recoger los datos del formulario .
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

            // Determinar si el usuario es socio o no
            bool esSocio = true;

            if (esSocio)
            {
                MessageBox.Show("Debe pagar la cuota");

            }

            // Crear el objeto de tipo E_Persona
            E_Persona nuevaPersona = new E_Persona()
            {
                nombre = nombre,
                apellido = apellido,
                tipodoc = tipoDoc,
                nrodoc = nroDoc,
                aptofisico = aptoFisico,
                condicion = esSocio
            };

            // Llamar al método de la clase Persona para registrar al nuevo usuario
            Socio datosPersona = new Socio();
            string respuesta = datosPersona.Nuevo_Registro(nuevaPersona);

            if (int.TryParse(respuesta, out int codigo))
            {
                if (codigo == 1)
                {
                    MessageBox.Show("El usuario ya existe.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    MessageBox.Show($"Registro exitoso. Código de Usuario: {respuesta}. Debe pagar la primer cuota", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPago form4 = new frmPago();
                    form4.ShowDialog();
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
            
        }



        // Método para cargar la lista de usuarios en el DataGridView
        private void CargarUsuarios()
        {
            try
            {
                Socio personaDatos = new Socio();
                DataTable usuarios = personaDatos.ObtenerUsuarios();

                // Añadir una columna extra para mostrar si es socio o no de manera descriptiva, si no existe ya
                if (!usuarios.Columns.Contains("EstadoSocio"))
                {
                    usuarios.Columns.Add("EstadoSocio", typeof(string));
                }

                // Asegurarse de que la columna `aptofisico` esté presente y tenga datos válidos
                if (!usuarios.Columns.Contains("aptofisico"))
                {
                    usuarios.Columns.Add("aptofisico", typeof(bool));
                }

                foreach (DataRow row in usuarios.Rows)
                {
                    // Definir si es socio o no según la columna `condicion`
                    if (row["condicion"] != DBNull.Value)
                    {
                        row["EstadoSocio"] = (bool)row["condicion"] ? "Socio" : "No Socio";
                    }
                    else
                    {
                        row["EstadoSocio"] = "No Especificado";
                    }

                    // Asegurarse de que `aptofisico` tenga un valor booleano
                    if (row["aptofisico"] == DBNull.Value)
                    {
                        row["aptofisico"] = false;
                    }
                }

                // Asignar el DataTable al DataGridView
                dtgvRegistro.DataSource = usuarios;

                // Configurar la columna `aptofisico` para que sea de tipo `CheckBoxColumn`
                if (dtgvRegistro.Columns.Contains("aptofisico"))
                {
                    dtgvRegistro.Columns["aptofisico"].ReadOnly = true; 
                    dtgvRegistro.Columns["aptofisico"].HeaderText = "Apto Físico";
                }
            

                // Ocultar la columna original "condicion" para evitar confusiones
                if (dtgvRegistro.Columns.Contains("condicion"))
                {
                    dtgvRegistro.Columns["condicion"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hasta luego");
            this.Close(); // Cierra el formulario actual
        }

        /*private void Socio_CheckedChanged(object sender, EventArgs e)
        {
            if (frmRegistroSocio.Checked)
            {
                rbNoSocio.Checked = false; // Desmarcar "No Socio" si se selecciona "Socio"
            }

        }

        private void rbNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoSocio.Checked)
            {
                frmRegistroSocio.Checked = false; // Desmarcar "Socio" si se selecciona "No Socio"
            }

        }*/

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}