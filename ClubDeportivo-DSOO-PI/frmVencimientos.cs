using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClubDeportivo_DSOO_PI.Datos;
using ClubDeportivo_DSOO_PI.Entidades;

namespace ClubDeportivo_DSOO_PI
{
    public partial class frmVencimientos : Form
    {
        private readonly Vencimientos vencimientosDatos;

        public frmVencimientos()
        {
            InitializeComponent();
            vencimientosDatos = new Vencimientos(); // Instancia de la clase de datos
            CargarVencimientos();
        }

        private void frmVencimientos_Load(object sender, EventArgs e)
        {
            dtpFiltroFecha.Value = DateTime.Now;
        }

        private void CargarVencimientos(DateTime? fechaFiltro = null)
        {
            try
            {
                List<E_Vencimientos> listaVencimientos = vencimientosDatos.ObtenerVencimientos(fechaFiltro);

                dtgvVencimientos.AllowUserToAddRows = false;
                dtgvVencimientos.DataSource = listaVencimientos;
                dtgvVencimientos.Columns["idPago"].HeaderText = "ID Pago";
                dtgvVencimientos.Columns["idRegistro"].HeaderText = "Nro Registro";
                dtgvVencimientos.Columns["fechaVencimiento"].HeaderText = "Fecha Vencimiento";

                dtgvVencimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                lblMensaje.Visible = listaVencimientos.Count == 0;
                lblMensaje.Text = fechaFiltro.HasValue
                    ? $"No hay registros para la fecha seleccionada: {fechaFiltro.Value.ToShortDateString()}"
                    : "No hay registros para mostrar.";

                foreach (DataGridViewRow row in dtgvVencimientos.Rows)
                {
                    DateTime fechaVencimiento = Convert.ToDateTime(row.Cells["fechaVencimiento"].Value);

                    if (fechaVencimiento < DateTime.Now)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if ((fechaVencimiento - DateTime.Now).TotalDays <= 7)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vencimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFiltroFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarVencimientos(dtpFiltroFecha.Value);
        }

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {
            dtpFiltroFecha.Value = DateTime.Now;
            CargarVencimientos();
        }
    }
}