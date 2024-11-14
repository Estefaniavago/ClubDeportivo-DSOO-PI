namespace ClubDeportivo_DSOO_PI
{
    partial class frmPagoNoSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioAct = new System.Windows.Forms.TextBox();
            this.btnComprobanteNoSocio = new System.Windows.Forms.Button();
            this.grbMedioPago = new System.Windows.Forms.GroupBox();
            this.cbCuotas = new System.Windows.Forms.ComboBox();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.rdDebito = new System.Windows.Forms.RadioButton();
            this.btnPagar = new System.Windows.Forms.Button();
            this.rdEfectivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.grbMedioPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro de Registro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Actividad";
            // 
            // cbActividad
            // 
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(592, 163);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(121, 24);
            this.cbActividad.TabIndex = 4;
            this.cbActividad.SelectedIndexChanged += new System.EventHandler(this.cbActividad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // txtPrecioAct
            // 
            this.txtPrecioAct.Location = new System.Drawing.Point(592, 207);
            this.txtPrecioAct.Name = "txtPrecioAct";
            this.txtPrecioAct.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioAct.TabIndex = 6;
            this.txtPrecioAct.TextChanged += new System.EventHandler(this.txtPrecioAct_TextChanged);
            // 
            // btnComprobanteNoSocio
            // 
            this.btnComprobanteNoSocio.Location = new System.Drawing.Point(887, 425);
            this.btnComprobanteNoSocio.Name = "btnComprobanteNoSocio";
            this.btnComprobanteNoSocio.Size = new System.Drawing.Size(215, 39);
            this.btnComprobanteNoSocio.TabIndex = 7;
            this.btnComprobanteNoSocio.Text = "Comprobante";
            this.btnComprobanteNoSocio.UseVisualStyleBackColor = true;
            // 
            // grbMedioPago
            // 
            this.grbMedioPago.Controls.Add(this.cbCuotas);
            this.grbMedioPago.Controls.Add(this.rdCredito);
            this.grbMedioPago.Controls.Add(this.rdDebito);
            this.grbMedioPago.Controls.Add(this.btnPagar);
            this.grbMedioPago.Controls.Add(this.rdEfectivo);
            this.grbMedioPago.Controls.Add(this.label5);
            this.grbMedioPago.Location = new System.Drawing.Point(441, 283);
            this.grbMedioPago.Margin = new System.Windows.Forms.Padding(4);
            this.grbMedioPago.Name = "grbMedioPago";
            this.grbMedioPago.Padding = new System.Windows.Forms.Padding(4);
            this.grbMedioPago.Size = new System.Drawing.Size(405, 212);
            this.grbMedioPago.TabIndex = 8;
            this.grbMedioPago.TabStop = false;
            this.grbMedioPago.Enter += new System.EventHandler(this.grbMedioPago_Enter);
            // 
            // cbCuotas
            // 
            this.cbCuotas.FormattingEnabled = true;
            this.cbCuotas.Items.AddRange(new object[] {
            "1 CUOTA",
            "3 CUOTAS",
            "6 CUOTAS"});
            this.cbCuotas.Location = new System.Drawing.Point(117, 90);
            this.cbCuotas.Margin = new System.Windows.Forms.Padding(4);
            this.cbCuotas.Name = "cbCuotas";
            this.cbCuotas.Size = new System.Drawing.Size(160, 24);
            this.cbCuotas.TabIndex = 9;
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Location = new System.Drawing.Point(24, 90);
            this.rdCredito.Margin = new System.Windows.Forms.Padding(4);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(71, 20);
            this.rdCredito.TabIndex = 8;
            this.rdCredito.TabStop = true;
            this.rdCredito.Text = "Crédito";
            this.rdCredito.UseVisualStyleBackColor = true;
            // 
            // rdDebito
            // 
            this.rdDebito.AutoSize = true;
            this.rdDebito.Location = new System.Drawing.Point(24, 62);
            this.rdDebito.Margin = new System.Windows.Forms.Padding(4);
            this.rdDebito.Name = "rdDebito";
            this.rdDebito.Size = new System.Drawing.Size(68, 20);
            this.rdDebito.TabIndex = 7;
            this.rdDebito.TabStop = true;
            this.rdDebito.Text = "Débito";
            this.rdDebito.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(179, 142);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(100, 28);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // rdEfectivo
            // 
            this.rdEfectivo.AutoSize = true;
            this.rdEfectivo.Location = new System.Drawing.Point(24, 33);
            this.rdEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.rdEfectivo.Name = "rdEfectivo";
            this.rdEfectivo.Size = new System.Drawing.Size(76, 20);
            this.rdEfectivo.TabIndex = 6;
            this.rdEfectivo.TabStop = true;
            this.rdEfectivo.Text = "Efectivo";
            this.rdEfectivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Medio de Pago";
            // 
            // frmPagoNoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 625);
            this.Controls.Add(this.grbMedioPago);
            this.Controls.Add(this.btnComprobanteNoSocio);
            this.Controls.Add(this.txtPrecioAct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPagoNoSocio";
            this.Text = "frmPagoNoSocio";
            this.grbMedioPago.ResumeLayout(false);
            this.grbMedioPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioAct;
        private System.Windows.Forms.Button btnComprobanteNoSocio;
        private System.Windows.Forms.GroupBox grbMedioPago;
        private System.Windows.Forms.ComboBox cbCuotas;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.RadioButton rdDebito;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.RadioButton rdEfectivo;
        private System.Windows.Forms.Label label5;
    }
}