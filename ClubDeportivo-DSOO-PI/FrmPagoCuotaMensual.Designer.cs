namespace ClubDeportivo_DSOO_PI
{
    partial class frmPagoCuotaMensual
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroRegistro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCuotas = new System.Windows.Forms.ComboBox();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.rdEfectivo = new System.Windows.Forms.RadioButton();
            this.btnComprobanteS = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::ClubDeportivo_DSOO_PI.Properties.Resources.crossfit_3180368_1280;
            this.pictureBox1.Location = new System.Drawing.Point(31, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 214);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPagos.Location = new System.Drawing.Point(256, 29);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(231, 24);
            this.lblPagos.TabIndex = 2;
            this.lblPagos.Text = "PAGO CUOTA MENSUAL";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(224, 89);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(165, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Numero de Registr/Numero socio";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(86, 109);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(86, 28);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medio de Pago";
            // 
            // txtNroRegistro
            // 
            this.txtNroRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNroRegistro.Location = new System.Drawing.Point(226, 106);
            this.txtNroRegistro.Name = "txtNroRegistro";
            this.txtNroRegistro.Size = new System.Drawing.Size(155, 29);
            this.txtNroRegistro.TabIndex = 6;
            this.txtNroRegistro.TextChanged += new System.EventHandler(this.txtNroRegistro_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCuotas);
            this.groupBox1.Controls.Add(this.rdCredito);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.rdEfectivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(242, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbCuotas
            // 
            this.cbCuotas.FormattingEnabled = true;
            this.cbCuotas.Items.AddRange(new object[] {
            "1 CUOTA",
            "3 CUOTAS",
            "6 CUOTAS"});
            this.cbCuotas.Location = new System.Drawing.Point(88, 56);
            this.cbCuotas.Name = "cbCuotas";
            this.cbCuotas.Size = new System.Drawing.Size(121, 21);
            this.cbCuotas.TabIndex = 9;
            this.cbCuotas.SelectedIndexChanged += new System.EventHandler(this.cbCuotas_SelectedIndexChanged);
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Location = new System.Drawing.Point(19, 56);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(58, 17);
            this.rdCredito.TabIndex = 8;
            this.rdCredito.TabStop = true;
            this.rdCredito.Text = "Crédito";
            this.rdCredito.UseVisualStyleBackColor = true;
            // 
            // rdEfectivo
            // 
            this.rdEfectivo.AutoSize = true;
            this.rdEfectivo.Location = new System.Drawing.Point(18, 27);
            this.rdEfectivo.Name = "rdEfectivo";
            this.rdEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdEfectivo.TabIndex = 6;
            this.rdEfectivo.TabStop = true;
            this.rdEfectivo.Text = "Efectivo";
            this.rdEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnComprobanteS
            // 
            this.btnComprobanteS.Location = new System.Drawing.Point(242, 336);
            this.btnComprobanteS.Name = "btnComprobanteS";
            this.btnComprobanteS.Size = new System.Drawing.Size(100, 39);
            this.btnComprobanteS.TabIndex = 9;
            this.btnComprobanteS.Text = "COMPROBANTE";
            this.btnComprobanteS.UseVisualStyleBackColor = true;
            this.btnComprobanteS.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(394, 106);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(100, 29);
            this.btnValidar.TabIndex = 10;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(314, 137);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 11;
            // 
            // frmPagoCuotaMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnComprobanteS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNroRegistro);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPagoCuotaMensual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.frmPagoCuotaMensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdEfectivo;
        private System.Windows.Forms.ComboBox cbCuotas;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.Button btnComprobanteS;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblResultado;
    }
}