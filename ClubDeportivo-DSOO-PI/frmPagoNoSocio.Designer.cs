﻿namespace ClubDeportivo_DSOO_PI
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
            this.grbMedioPago = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblMedioDePago = new System.Windows.Forms.Label();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.rdEfectivo = new System.Windows.Forms.RadioButton();
            this.btnComprobanteNoSocio = new System.Windows.Forms.Button();
            this.btnValidarNSocio = new System.Windows.Forms.Button();
            this.dtgvActividad = new System.Windows.Forms.DataGridView();
            this.lblNyANs = new System.Windows.Forms.Label();
            this.txtNyANs = new System.Windows.Forms.TextBox();
            this.txtPrecioAct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroRegistroNs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbMedioPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMedioPago
            // 
            this.grbMedioPago.Controls.Add(this.btnPagar);
            this.grbMedioPago.Controls.Add(this.lblMedioDePago);
            this.grbMedioPago.Controls.Add(this.rdCredito);
            this.grbMedioPago.Controls.Add(this.rdEfectivo);
            this.grbMedioPago.Location = new System.Drawing.Point(449, 89);
            this.grbMedioPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbMedioPago.Name = "grbMedioPago";
            this.grbMedioPago.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbMedioPago.Size = new System.Drawing.Size(259, 152);
            this.grbMedioPago.TabIndex = 8;
            this.grbMedioPago.TabStop = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(83, 117);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 35);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblMedioDePago.Location = new System.Drawing.Point(-4, 0);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(129, 38);
            this.lblMedioDePago.TabIndex = 10;
            this.lblMedioDePago.Text = "Medio de Pago";
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Location = new System.Drawing.Point(27, 77);
            this.rdCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(84, 24);
            this.rdCredito.TabIndex = 8;
            this.rdCredito.TabStop = true;
            this.rdCredito.Text = "Crédito";
            this.rdCredito.UseVisualStyleBackColor = true;
            // 
            // rdEfectivo
            // 
            this.rdEfectivo.AutoSize = true;
            this.rdEfectivo.Location = new System.Drawing.Point(27, 43);
            this.rdEfectivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdEfectivo.Name = "rdEfectivo";
            this.rdEfectivo.Size = new System.Drawing.Size(90, 24);
            this.rdEfectivo.TabIndex = 6;
            this.rdEfectivo.TabStop = true;
            this.rdEfectivo.Text = "Efectivo";
            this.rdEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnComprobanteNoSocio
            // 
            this.btnComprobanteNoSocio.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnComprobanteNoSocio.Location = new System.Drawing.Point(505, 262);
            this.btnComprobanteNoSocio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprobanteNoSocio.Name = "btnComprobanteNoSocio";
            this.btnComprobanteNoSocio.Size = new System.Drawing.Size(158, 42);
            this.btnComprobanteNoSocio.TabIndex = 7;
            this.btnComprobanteNoSocio.Text = "COMPROBANTE";
            this.btnComprobanteNoSocio.UseVisualStyleBackColor = true;
            this.btnComprobanteNoSocio.Click += new System.EventHandler(this.btnComprobanteNoSocio_Click);
            // 
            // btnValidarNSocio
            // 
            this.btnValidarNSocio.Location = new System.Drawing.Point(272, 62);
            this.btnValidarNSocio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidarNSocio.Name = "btnValidarNSocio";
            this.btnValidarNSocio.Size = new System.Drawing.Size(115, 32);
            this.btnValidarNSocio.TabIndex = 12;
            this.btnValidarNSocio.Text = "Validar";
            this.btnValidarNSocio.UseVisualStyleBackColor = true;
            this.btnValidarNSocio.Click += new System.EventHandler(this.btnValidarNSocio_Click);
            // 
            // dtgvActividad
            // 
            this.dtgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvActividad.Location = new System.Drawing.Point(9, 199);
            this.dtgvActividad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvActividad.Name = "dtgvActividad";
            this.dtgvActividad.RowHeadersWidth = 51;
            this.dtgvActividad.RowTemplate.Height = 24;
            this.dtgvActividad.Size = new System.Drawing.Size(430, 166);
            this.dtgvActividad.TabIndex = 11;
            // 
            // lblNyANs
            // 
            this.lblNyANs.AutoSize = true;
            this.lblNyANs.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblNyANs.Location = new System.Drawing.Point(5, 104);
            this.lblNyANs.Name = "lblNyANs";
            this.lblNyANs.Size = new System.Drawing.Size(146, 20);
            this.lblNyANs.TabIndex = 10;
            this.lblNyANs.Text = "Nombre y Apellido";
            // 
            // txtNyANs
            // 
            this.txtNyANs.Location = new System.Drawing.Point(133, 105);
            this.txtNyANs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNyANs.Name = "txtNyANs";
            this.txtNyANs.Size = new System.Drawing.Size(211, 27);
            this.txtNyANs.TabIndex = 9;
            // 
            // txtPrecioAct
            // 
            this.txtPrecioAct.Location = new System.Drawing.Point(133, 172);
            this.txtPrecioAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioAct.Name = "txtPrecioAct";
            this.txtPrecioAct.Size = new System.Drawing.Size(115, 27);
            this.txtPrecioAct.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F);
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // cbActividad
            // 
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(133, 136);
            this.cbActividad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(213, 28);
            this.cbActividad.TabIndex = 4;
            this.cbActividad.SelectedIndexChanged += new System.EventHandler(this.cbActividad_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F);
            this.label3.Location = new System.Drawing.Point(8, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Actividad";
            // 
            // txtNroRegistroNs
            // 
            this.txtNroRegistroNs.Location = new System.Drawing.Point(134, 67);
            this.txtNroRegistroNs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroRegistroNs.Name = "txtNroRegistroNs";
            this.txtNroRegistroNs.Size = new System.Drawing.Size(106, 27);
            this.txtNroRegistroNs.TabIndex = 2;
            this.txtNroRegistroNs.TextChanged += new System.EventHandler(this.txtNroRegistroNs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F);
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro de Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 47);
            this.label1.TabIndex = 0;
            this.label1.Tag = "tituloForm";
            this.label1.Text = "PAGO ACTIVIDAD DIARIA";
            // 
            // frmPagoNoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 513);
            this.Controls.Add(this.grbMedioPago);
            this.Controls.Add(this.btnComprobanteNoSocio);
            this.Controls.Add(this.btnValidarNSocio);
            this.Controls.Add(this.dtgvActividad);
            this.Controls.Add(this.lblNyANs);
            this.Controls.Add(this.txtNyANs);
            this.Controls.Add(this.txtPrecioAct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroRegistroNs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPagoNoSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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