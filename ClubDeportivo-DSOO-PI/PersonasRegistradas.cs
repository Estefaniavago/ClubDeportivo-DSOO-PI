using ClubDeportivo_DSOO_PI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class PersonasRegistradas : Form
    {
        public PersonasRegistradas()
        {
            InitializeComponent();
            CargarPersona();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Método para cargar la lista de usuarios en el DataGridView
        private void CargarPersona()
        {
            try
            {
                Persona personaDatos = new Persona();
                DataTable usuarios = personaDatos.ObtenerPersona();

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
    }
}
