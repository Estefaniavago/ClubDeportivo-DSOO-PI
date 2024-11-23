using System;
using System.Windows.Forms;

public class BaseForm : Form
{
    public BaseForm()
    {
        this.Load += BaseForm_Load;

        // Habilitar doble buffer para evitar parpadeos
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        this.DoubleBuffered = true;
    }

    private void BaseForm_Load(object sender, EventArgs e)
    {
        // Aplica los estilos globales al formulario actual
        EstilosGlobales.AplicarEstilosFormulario(this);
    }
}
