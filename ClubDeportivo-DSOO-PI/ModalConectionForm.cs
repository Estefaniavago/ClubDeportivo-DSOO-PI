using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivo_DSOO_PI
{
    public class ModalConectionForm : Form
    {
        private Label lblMessage;
        private Button btnYes;
        private Button btnNo;

        public bool UserChoice { get; private set; } // Almacena la elección del usuario

        public ModalConectionForm(string message, string title)
        {
            // Configuración del formulario
            this.Text = title;
            this.Size = new Size(450, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Crear y configurar el Label para el mensaje
            lblMessage = new Label
            {
                Text = message,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Dock = DockStyle.Top,
                Height = 120, // Altura para dar espacio al texto
                Padding = new Padding(10, 20, 10, 10) // Espaciado interno
            };

            // Panel para los botones
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                Padding = new Padding(10)
            };

            // Botón "Sí"
            btnYes = new Button
            {
                Text = "Sí",
                DialogResult = DialogResult.Yes,
                BackColor = Color.FromArgb(63, 81, 181),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 100,
                Height = 40
            };
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.Click += (s, e) => { UserChoice = true; this.Close(); };

            // Botón "No"
            btnNo = new Button
            {
                Text = "No",
                DialogResult = DialogResult.No,
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 100,
                Height = 40
            };
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.Click += (s, e) => { UserChoice = false; this.Close(); };

            // Alinear los botones
            FlowLayoutPanel flowLayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = false,
                Padding = new Padding(0, 10, 0, 0)
            };
            flowLayout.Controls.Add(btnYes);
            flowLayout.Controls.Add(btnNo);
            buttonPanel.Controls.Add(flowLayout);

            // Añadir controles al formulario
            this.Controls.Add(lblMessage);
            this.Controls.Add(buttonPanel);
        }
    }
}
