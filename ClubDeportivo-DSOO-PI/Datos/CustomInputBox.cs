using System;
using System.Drawing;
using System.Windows.Forms;

public static class CustomInputBox
{
    public static string Show(string promptText, string title, string defaultValue = "")
    {
        Form form = new Form();
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button buttonOk = new Button();
        Button buttonCancel = new Button();

        // Configuración del Formulario
        form.Text = title;
        form.Font = new Font("Segoe UI", 10);
        form.BackColor = Color.WhiteSmoke;
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.ClientSize = new Size(400, 180);
        form.MinimizeBox = false;
        form.MaximizeBox = false;

        // Configuración del Label
        label.Text = promptText;
        label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        label.SetBounds(20, 20, 360, 40);
        label.TextAlign = ContentAlignment.MiddleLeft;

        // Configuración del TextBox
        textBox.Text = defaultValue;
        textBox.Font = new Font("Segoe UI", 10);
        textBox.SetBounds(20, 70, 360, 30);
        textBox.BorderStyle = BorderStyle.FixedSingle;

        // Configuración de los Botones
        buttonOk.Text = "Aceptar";
        buttonCancel.Text = "Cancelar";

        buttonOk.Font = new Font("Segoe UI", 9);
        buttonCancel.Font = new Font("Segoe UI", 9);

        buttonOk.SetBounds(210, 120, 80, 30);
        buttonCancel.SetBounds(300, 120, 80, 30);

        buttonOk.BackColor = Color.FromArgb(0, 120, 215);
        buttonOk.ForeColor = Color.White;
        buttonOk.FlatStyle = FlatStyle.Flat;
        buttonOk.FlatAppearance.BorderSize = 0;

        buttonCancel.BackColor = Color.LightGray;
        buttonCancel.ForeColor = Color.Black;
        buttonCancel.FlatStyle = FlatStyle.Flat;
        buttonCancel.FlatAppearance.BorderSize = 0;

        // Configuración del Comportamiento de los Botones
        buttonOk.DialogResult = DialogResult.OK;
        buttonCancel.DialogResult = DialogResult.Cancel;

        // Añadir Controles al Formulario
        form.Controls.Add(label);
        form.Controls.Add(textBox);
        form.Controls.Add(buttonOk);
        form.Controls.Add(buttonCancel);

        // Configuración de los Botones como Predeterminados
        form.AcceptButton = buttonOk;
        form.CancelButton = buttonCancel;

        // Mostrar el Formulario y Retornar el Resultado
        DialogResult dialogResult = form.ShowDialog();
        return dialogResult == DialogResult.OK ? textBox.Text : null;
    }
}