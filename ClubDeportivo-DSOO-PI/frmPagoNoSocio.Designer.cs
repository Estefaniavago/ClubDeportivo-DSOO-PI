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
            this.txtNroRegistroNs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioAct = new System.Windows.Forms.TextBox();
            this.btnComprobanteNoSocio = new System.Windows.Forms.Button();
            this.grbMedioPago = new System.Windows.Forms.GroupBox();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.btnPagar = new System.Windows.Forms.Button();
            this.rdEfectivo = new System.Windows.Forms.RadioButton();
            this.lblMedioDePago = new System.Windows.Forms.Label();
            this.txtNyANs = new System.Windows.Forms.TextBox();
            this.lblNyANs = new System.Windows.Forms.Label();
            this.dtgvActividad = new System.Windows.Forms.DataGridView();
            this.btnValidarNSocio = new System.Windows.Forms.Button();
            this.grbMedioPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro de Registro";
            // 
            // txtNroRegistroNs
            // 
            this.txtNroRegistroNs.Location = new System.Drawing.Point(146, 37);
            this.txtNroRegistroNs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroRegistroNs.Name = "txtNroRegistroNs";
            this.txtNroRegistroNs.Size = new System.Drawing.Size(80, 20);
            this.txtNroRegistroNs.TabIndex = 2;
            this.txtNroRegistroNs.TextChanged += new System.EventHandler(this.txtNroRegistroNs_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Actividad";
            // 
            // cbActividad
            // 
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(146, 98);
            this.cbActividad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(173, 21);
            this.cbActividad.TabIndex = 4;
            this.cbActividad.SelectedIndexChanged += new System.EventHandler(this.cbActividad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // txtPrecioAct
            // 
            this.txtPrecioAct.Location = new System.Drawing.Point(146, 130);
            this.txtPrecioAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioAct.Name = "txtPrecioAct";
            this.txtPrecioAct.Size = new System.Drawing.Size(78, 20);
            this.txtPrecioAct.TabIndex = 6;
            // 
            // btnComprobanteNoSocio
            // 
            this.btnComprobanteNoSocio.Location = new System.Drawing.Point(112, 306);
            this.btnComprobanteNoSocio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComprobanteNoSocio.Name = "btnComprobanteNoSocio";
            this.btnComprobanteNoSocio.Size = new System.Drawing.Size(161, 32);
            this.btnComprobanteNoSocio.TabIndex = 7;
            this.btnComprobanteNoSocio.Text = "Comprobante";
            this.btnComprobanteNoSocio.UseVisualStyleBackColor = true;
            this.btnComprobanteNoSocio.Click += new System.EventHandler(this.btnComprobanteNoSocio_Click);
            // 
            // grbMedioPago
            // 
            this.grbMedioPago.Controls.Add(this.rdCredito);
            this.grbMedioPago.Controls.Add(this.btnPagar);
            this.grbMedioPago.Controls.Add(this.rdEfectivo);
            this.grbMedioPago.Controls.Add(this.lblMedioDePago);
            this.grbMedioPago.Location = new System.Drawing.Point(39, 171);
            this.grbMedioPago.Name = "grbMedioPago";
            this.grbMedioPago.Size = new System.Drawing.Size(304, 123);
            this.grbMedioPago.TabIndex = 8;
            this.grbMedioPago.TabStop = false;
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Location = new System.Drawing.Point(18, 50);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(58, 17);
            this.rdCredito.TabIndex = 8;
            this.rdCredito.TabStop = true;
            this.rdCredito.Text = "Crédito";
            this.rdCredito.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(122, 86);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
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
            // lblMedioDePago
            // 
            this.lblMedioDePago.Location = new System.Drawing.Point(0, 0);
            this.lblMedioDePago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(86, 24);
            this.lblMedioDePago.TabIndex = 10;
            this.lblMedioDePago.Text = "Medio de Pago";
            // 
            // txtNyANs
            // 
            this.txtNyANs.Location = new System.Drawing.Point(146, 65);
            this.txtNyANs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNyANs.Name = "txtNyANs";
            this.txtNyANs.Size = new System.Drawing.Size(173, 20);
            this.txtNyANs.TabIndex = 9;
            // 
            // lblNyANs
            // 
            this.lblNyANs.AutoSize = true;
            this.lblNyANs.Location = new System.Drawing.Point(44, 67);
            this.lblNyANs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNyANs.Name = "lblNyANs";
            this.lblNyANs.Size = new System.Drawing.Size(92, 13);
            this.lblNyANs.TabIndex = 10;
            this.lblNyANs.Text = "Nombre y Apellido";
            // 
            // dtgvActividad
            // 
            this.dtgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvActividad.Location = new System.Drawing.Point(368, 50);
            this.dtgvActividad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvActividad.Name = "dtgvActividad";
            this.dtgvActividad.RowHeadersWidth = 51;
            this.dtgvActividad.RowTemplate.Height = 24;
            this.dtgvActividad.Size = new System.Drawing.Size(413, 193);
            this.dtgvActividad.TabIndex = 11;
            // 
            // btnValidarNSocio
            // 
            this.btnValidarNSocio.Location = new System.Drawing.Point(249, 36);
            this.btnValidarNSocio.Name = "btnValidarNSocio";
            this.btnValidarNSocio.Size = new System.Drawing.Size(84, 21);
            this.btnValidarNSocio.TabIndex = 12;
            this.btnValidarNSocio.Text = "Validar";
            this.btnValidarNSocio.UseVisualStyleBackColor = true;
            this.btnValidarNSocio.Click += new System.EventHandler(this.btnValidarNSocio_Click);
            // 
            // frmPagoNoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 508);
            this.Controls.Add(this.btnValidarNSocio);
            this.Controls.Add(this.dtgvActividad);
            this.Controls.Add(this.lblNyANs);
            this.Controls.Add(this.txtNyANs);
            this.Controls.Add(this.grbMedioPago);
            this.Controls.Add(this.btnComprobanteNoSocio);
            this.Controls.Add(this.txtPrecioAct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroRegistroNs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPagoNoSocio";
            this.Text = "frmPagoNoSocio";
            this.grbMedioPago.ResumeLayout(false);
            this.grbMedioPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroRegistroNs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioAct;
        private System.Windows.Forms.Button btnComprobanteNoSocio;
        private System.Windows.Forms.GroupBox grbMedioPago;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.RadioButton rdEfectivo;
        private System.Windows.Forms.Label lblMedioDePago;
        private System.Windows.Forms.TextBox txtNyANs;
        private System.Windows.Forms.Label lblNyANs;
        private System.Windows.Forms.DataGridView dtgvActividad;
        private System.Windows.Forms.Button btnValidarNSocio;
    }
}