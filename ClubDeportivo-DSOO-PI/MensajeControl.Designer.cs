namespace ClubDeportivo_DSOO_PI
{
    partial class MensajeControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensajeValidacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensajeValidacion
            // 
            this.lblMensajeValidacion.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajeValidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensajeValidacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensajeValidacion.Location = new System.Drawing.Point(0, 0);
            this.lblMensajeValidacion.Name = "lblMensajeValidacion";
            this.lblMensajeValidacion.Size = new System.Drawing.Size(150, 150);
            this.lblMensajeValidacion.TabIndex = 0;
            this.lblMensajeValidacion.Text = "label1";
            this.lblMensajeValidacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajeValidacion.Visible = false;
            // 
            // MensajeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMensajeValidacion);
            this.Name = "MensajeControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeValidacion;
    }
}
