using ClubDeportivo_DSOO_PI.Entidades; // Referencia a la carpeta de Entidades
using ClubDeportivo_DSOO_PI.Datos; // Referencia a la carpeta de Datos
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo_DSOO_PI
{
    public partial class registroPersona : Form
    {
        public registroPersona()
        {
            InitializeComponent();
        }

        private void registroPersona_Load(object sender, EventArgs e)
        {
            // Cargar todos los usuarios cuando se abra el formulario
            CargarUsuarios();
            //Carga el DNI por defecto en el combobox
            cboxTipoDocumento.SelectedItem = "DNI"; 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) 
                || string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos (*)", 
                    "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Toma los datos del formulario .
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string tipoDoc = cboxTipoDocumento.SelectedItem?.ToString() ?? string.Empty;
            
            //ESTO YA NO SE NECESITARIA PORQUE ESTA PUESTO POR DEFECTO DNI, NUNCA VA A ESTAR EMPTY.
            /*if (string.IsNullOrEmpty(tipoDoc))
            {
                MessageBox.Show("Debe seleccionar un tipo de documento.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            int nroDoc = Convert.ToInt32(txtNumero.Text);
            
            bool aptoFisico = chkAptoFisico.Checked;

            // Determinar que el usuario no es socio por defecto, se hace socio al pagar la primer cuota
            //bool esSocio = false;

            
            // Crear el objeto de tipo E_Persona
            E_Persona nuevaPersona = new E_Persona()
            {
                nombre = nombre,
                apellido = apellido,
                tipodoc = tipoDoc,
                nrodoc = nroDoc,
                aptofisico = aptoFisico,
                //condicion = esSocio
            };

            // Llamar al método de la clase Persona para registrar al nuevo usuario en la bbdd
            Persona datosPersona = new Persona();
            string respuesta = datosPersona.Nuevo_Registro(nuevaPersona);
            // En respuesta se guarda si se pudo agregar o no
            //Si la respuesta es 1, ya existe el usuario. si no existe devuelve un numero de registro y se
            //convierte a int el string y refresca la 


            if (int.TryParse(respuesta, out int codigo))
            {
                if (codigo == 1)
                {
                    MessageBox.Show("El usuario ya existe.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    MessageBox.Show($"Registro exitoso. Código de Usuario: {respuesta}.", 
                        "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
                Persona personaDatos = new Persona();
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
            MessageBox.Show($"Ustede volverá al menú principal");
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

        private void cboxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumero.Text = "";
            chkAptoFisico.Checked = false; 
        }

        
    }
}