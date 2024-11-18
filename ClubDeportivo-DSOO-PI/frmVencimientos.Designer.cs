namespace ClubDeportivo_DSOO_PI
{
    partial class frmVencimientos
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
            this.lblTituloVencimientos = new System.Windows.Forms.Label();
            this.txtRegistroSocio = new System.Windows.Forms.TextBox();
            this.lblRegistroSocio = new System.Windows.Forms.Label();
            this.btnPagarCuotaVencida = new System.Windows.Forms.Button();
            this.dtgvVencimientos = new System.Windows.Forms.DataGridView();
            this.btnValidarRegistroSocio = new System.Windows.Forms.Button();
            this.txtSocioValidado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVencimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloVencimientos
            // 
            this.lblTituloVencimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVencimientos.Location = new System.Drawing.Point(133, 48);
            this.lblTituloVencimientos.Name = "lblTituloVencimientos";
            this.lblTituloVencimientos.Size = new System.Drawing.Size(561, 41);
            this.lblTituloVencimientos.TabIndex = 0;
            this.lblTituloVencimientos.Text = "Vencimientos de Cuotas Mensuales";
            // 
            // txtRegistroSocio
            // 
            this.txtRegistroSocio.Location = new System.Drawing.Point(140, 154);
            this.txtRegistroSocio.Name = "txtRegistroSocio";
            this.txtRegistroSocio.Size = new System.Drawing.Size(136, 22);
            this.txtRegistroSocio.TabIndex = 1;
            // 
            // lblRegistroSocio
            // 
            this.lblRegistroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegistroSocio.Location = new System.Drawing.Point(43, 150);
            this.lblRegistroSocio.Name = "lblRegistroSocio";
            this.lblRegistroSocio.Size = new System.Drawing.Size(91, 23);
            this.lblRegistroSocio.TabIndex = 2;
            this.lblRegistroSocio.Text = "N° Socio";
            // 
            // btnPagarCuotaVencida
            // 
            this.btnPagarCuotaVencida.Location = new System.Drawing.Point(83, 388);
            this.btnPagarCuotaVencida.Name = "btnPagarCuotaVencida";
            this.btnPagarCuotaVencida.Size = new System.Drawing.Size(178, 34);
            this.btnPagarCuotaVencida.TabIndex = 3;
            this.btnPagarCuotaVencida.Text = "Pagar";
            this.btnPagarCuotaVencida.UseVisualStyleBackColor = true;
            this.btnPagarCuotaVencida.Click += new System.EventHandler(this.btnPagarCuotaVencida_Click);
            // 
            // dtgvVencimientos
            // 
            this.dtgvVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVencimientos.Location = new System.Drawing.Point(313, 117);
            this.dtgvVencimientos.Name = "dtgvVencimientos";
            this.dtgvVencimientos.RowHeadersWidth = 51;
            this.dtgvVencimientos.RowTemplate.Height = 24;
            this.dtgvVencimientos.Size = new System.Drawing.Size(582, 305);
            this.dtgvVencimientos.TabIndex = 4;
            // 
            // btnValidarRegistroSocio
            // 
            this.btnValidarRegistroSocio.Location = new System.Drawing.Point(149, 207);
            this.btnValidarRegistroSocio.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarRegistroSocio.Name = "btnValidarRegistroSocio";
            this.btnValidarRegistroSocio.Size = new System.Drawing.Size(112, 26);
            this.btnValidarRegistroSocio.TabIndex = 13;
            this.btnValidarRegistroSocio.Text = "Validar";
            this.btnValidarRegistroSocio.UseVisualStyleBackColor = true;
            this.btnValidarRegistroSocio.Click += new System.EventHandler(this.btnValidarRegistroSocio_Click);
            // 
            // txtSocioValidado
            // 
            this.txtSocioValidado.Location = new System.Drawing.Point(48, 270);
            this.txtSocioValidado.Name = "txtSocioValidado";
            this.txtSocioValidado.Size = new System.Drawing.Size(237, 22);
            this.txtSocioValidado.TabIndex = 14;
            this.txtSocioValidado.TextChanged += new System.EventHandler(this.txtSocioValidado_TextChanged);
            // 
            // frmVencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 512);
            this.Controls.Add(this.txtSocioValidado);
            this.Controls.Add(this.btnValidarRegistroSocio);
            this.Controls.Add(this.dtgvVencimientos);
            this.Controls.Add(this.btnPagarCuotaVencida);
            this.Controls.Add(this.lblRegistroSocio);
            this.Controls.Add(this.txtRegistroSocio);
            this.Controls.Add(this.lblTituloVencimientos);
            this.Name = "frmVencimientos";
            this.Text = "frmVencimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVencimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVencimientos;
        private System.Windows.Forms.TextBox txtRegistroSocio;
        private System.Windows.Forms.Label lblRegistroSocio;
        private System.Windows.Forms.Button btnPagarCuotaVencida;
        private System.Windows.Forms.DataGridView dtgvVencimientos;
        private System.Windows.Forms.Button btnValidarRegistroSocio;
        private System.Windows.Forms.TextBox txtSocioValidado;
    }
}