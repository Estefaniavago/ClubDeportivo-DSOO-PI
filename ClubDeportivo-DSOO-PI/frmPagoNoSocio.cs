using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using ClubDeportivo_DSOO_PI.Datos;
using ClubDeportivo_DSOO_PI.Entidades;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo_DSOO_PI
{
    public partial class frmPagoNoSocio : Form
    {
        private string horarioSeleccionado;
        private string diaSeleccionado;

        public frmPagoNoSocio()
        {
            InitializeComponent();
            txtPrecioAct.ReadOnly = true; // Establece el campo como de solo lectura
            dtgvActividad.ReadOnly = true; // Hace que el DataGridView sea de solo lectura
            dtgvActividad.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección de filas completas
            dtgvActividad.AllowUserToAddRows = false; // No permitir filas vacías
            dtgvActividad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al tamaño disponible

            dtgvActividad.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar filas completas
            CargarActividades(); // Llamar al método para cargar actividades al abrir el formulario
            btnPagar.Enabled = false;
        }

        //Carga las actividades para que puedan seleccionarse del combobox, trayendolas de la bbdd
        private void CargarActividades()
        {
            List<string> actividades = Actividad.CargarActividades();
            cbActividad.Items.Clear(); // Limpiar el ComboBox antes de agregar nuevas actividades

            foreach (string actividad in actividades)
            {
                cbActividad.Items.Add(actividad);
            }
        }

        //Codigo que corresponde al evento de seleccionar una actividad de la lista
        //Se autocompleta el precio de la actividad y se cargan los dias y horarios en la grilla
        private void cbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string actividadSeleccionada = cbActividad.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(actividadSeleccionada))
            {
                // Llamamos al método estático ObtenerDetallesActividad de la clase Actividad
                DataTable horariosTable = Actividad.ObtenerDetallesActividad(actividadSeleccionada);

                if (horariosTable.Rows.Count > 0)
                {
                    // Mostrar el precio en el TextBox txtPrecioAct (solo la primera fila)
                    txtPrecioAct.Text = horariosTable.Rows[0]["precio"].ToString();

                    // Configurar y mostrar los horarios en el DataGridView
                    dtgvActividad.DataSource = horariosTable;
                    dtgvActividad.Columns["dia"].HeaderText = "Día";
                    dtgvActividad.Columns["horario"].HeaderText = "Horario";
                    dtgvActividad.Columns["precio"].Visible = false; // Ocultar la columna del precio
                }
                else
                {
                    MessageBox.Show("No se encontraron horarios para la actividad seleccionada.",
                                     "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //Seleccionar dia y horario de la actividad
        private void dtgvActividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se está haciendo clic en el encabezado
            {
                DataGridViewRow row = dtgvActividad.Rows[e.RowIndex];
                diaSeleccionado = row.Cells["dia"].Value.ToString();
                horarioSeleccionado = row.Cells["horario"].Value.ToString();

                MessageBox.Show($"Has seleccionado el día: {diaSeleccionado} y el horario: {horarioSeleccionado}",
                    "Horario Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnComprobanteNoSocio_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos
            if (!string.IsNullOrEmpty(cbActividad.Text) &&
                !string.IsNullOrEmpty(txtPrecioAct.Text) &&
                !string.IsNullOrEmpty(txtNyANs.Text))
            {
                // Crear y configurar el formulario de comprobante
                ComprobanteNoSocio comprobanteForm = new ComprobanteNoSocio
                {
                    Nombre = txtNyANs.Text.Split(' ')[0],
                    Apellido = txtNyANs.Text.Split(' ')[1],
                    ActividadElegida = cbActividad.Text,
                    Precio = txtPrecioAct.Text,
                    FechaPago = DateTime.Now.ToShortDateString(),
                    MedioPago = rdEfectivo.Checked ? "Efectivo" : rdCredito.Checked ? "Crédito" : "N/A"
                };

                // Mostrar el formulario de comprobante
                comprobanteForm.ShowDialog(); // Utilizamos ShowDialog para que sea modal
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de generar el comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtNroRegistroNs_TextChanged(object sender, EventArgs e)
        {
            string nroRegistro = txtNroRegistroNs.Text;

            if (!string.IsNullOrEmpty(nroRegistro))
            {
                try
                {
                    // Llama al método de la clase Persona
                    string resultado = Persona.ObtenerNombreYApellido(nroRegistro);

                    // Muestra el resultado en el campo de texto
                    txtNyANs.Text = resultado;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Limpia el campo si el número de registro está vacío
                txtNyANs.Text = string.Empty;
            }
        }

        private void btnValidarNSocio_Click(object sender, EventArgs e)
        {
            string nroRegistro = txtNroRegistroNs.Text;

            if (!string.IsNullOrEmpty(nroRegistro))
            {
                try
                {
                    // Llama al método de la clase Persona para validar el registro
                    E_Persona ePersona = Persona.ValidarRegistro(nroRegistro);

                    if (ePersona != null)
                    {
                        // Accede a las propiedades Nombre y Apellido de la instancia de E_Persona
                        txtNyANs.Text = $"{ePersona.nombre} {ePersona.apellido}";

                        if (ePersona.EsSocio)
                        {
                            MessageBox.Show("Este registro corresponde a un socio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnPagar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Registro validado exitosamente.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnPagar.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registro no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnPagar.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al validar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están completos
            if (!string.IsNullOrEmpty(cbActividad.Text) &&
                !string.IsNullOrEmpty(txtPrecioAct.Text) &&
                !string.IsNullOrEmpty(txtNyANs.Text) &&
                !string.IsNullOrEmpty(txtNroRegistroNs.Text) &&
                (rdCredito.Checked || rdEfectivo.Checked))
            {
                // Capturar los datos del formulario
                int.TryParse(txtNroRegistroNs.Text, out int idPersona);
                string actividadSeleccionada = cbActividad.Text;
                string precio = txtPrecioAct.Text;  // Usamos el precio que ya está en el TextBox
                string fechaPago = DateTime.Now.ToString("yyyy-MM-dd");

                // Llamar al método estático de la clase NoSocio para registrar el pago
                bool pagoRegistrado = NoSocio.RegistrarPagoNoSocio(idPersona, actividadSeleccionada, precio, fechaPago);

                if (pagoRegistrado)
                {
                    MessageBox.Show("El pago ha sido registrado correctamente.", "Pago Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnComprobanteNoSocio.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el pago. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de proceder con el pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

    }
}