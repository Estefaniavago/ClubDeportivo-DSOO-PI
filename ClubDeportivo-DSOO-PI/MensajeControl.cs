using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public partial class MensajeControl : UserControl
    {
        public MensajeControl()
        {
            InitializeComponent();
            lblMensajeValidacion.Visible = false;
        }

        // Método para mostrar mensajes de forma animada
        public async void MostrarMensajeAnimado(string mensaje, Color color)
        {
            lblMensajeValidacion.Text = mensaje;
            lblMensajeValidacion.ForeColor = color;
            lblMensajeValidacion.BackColor = Color.LightBlue; // Cambiar si necesitas un fondo diferente
            lblMensajeValidacion.Visible = true;

            // Animación de entrada (efecto gradual)
            for (int i = 0; i <= 255; i += 25)
            {
                lblMensajeValidacion.BackColor = Color.FromArgb(i, lblMensajeValidacion.BackColor.R, lblMensajeValidacion.BackColor.G, lblMensajeValidacion.BackColor.B);
                await Task.Delay(30); // Espera para un efecto suave
            }

            await Task.Delay(3000); // Mantener visible por 3 segundos

            // Animación de salida
            for (int i = 255; i >= 0; i -= 25)
            {
                lblMensajeValidacion.BackColor = Color.FromArgb(i, lblMensajeValidacion.BackColor.R, lblMensajeValidacion.BackColor.G, lblMensajeValidacion.BackColor.B);
                await Task.Delay(30);
            }

            lblMensajeValidacion.Visible = false; // Ocultar después de la animación
        }

        // Método para mostrar mensajes de forma instantánea
        public void MostrarMensaje(string mensaje, Color color)
        {
            lblMensajeValidacion.Text = mensaje;
            lblMensajeValidacion.ForeColor = color;
            lblMensajeValidacion.BackColor = Color.LightBlue; // Cambiar si necesitas un fondo diferente
            lblMensajeValidacion.Visible = true;

            // Ocultar automáticamente después de unos segundos
            var timer = new Timer { Interval = 3000 }; // 3 segundos
            timer.Tick += (s, e) =>
            {
                lblMensajeValidacion.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }

        // Método para ocultar el mensaje manualmente
        public void OcultarMensaje()
        {
            this.Visible = false; // Oculta el control
            lblMensajeValidacion.Text = ""; // Limpia el texto del mensaje
        }
    }
}