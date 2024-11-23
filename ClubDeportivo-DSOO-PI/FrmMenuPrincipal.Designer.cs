namespace ClubDeportivo_DSOO_PI
{
    partial class frmPrincipal
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
            this.btnRegistroSocio = new System.Windows.Forms.Button();
            this.btnPagoMensual = new System.Windows.Forms.Button();
            this.btnCarnet = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPagoActividad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGrillaPr = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(316, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 47);
            this.label1.TabIndex = 5;
            this.label1.Tag = "tituloMenu";
            this.label1.Text = "MENÚ PRINCIPAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistroSocio
            // 
            this.btnRegistroSocio.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRegistroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroSocio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistroSocio.Location = new System.Drawing.Point(4, 161);
            this.btnRegistroSocio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistroSocio.Name = "btnRegistroSocio";
            this.btnRegistroSocio.Size = new System.Drawing.Size(192, 48);
            this.btnRegistroSocio.TabIndex = 7;
            this.btnRegistroSocio.Text = "REGISTRAR ";
            this.btnRegistroSocio.UseVisualStyleBackColor = false;
            this.btnRegistroSocio.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnPagoMensual
            // 
            this.btnPagoMensual.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPagoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoMensual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagoMensual.Location = new System.Drawing.Point(6, 336);
            this.btnPagoMensual.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagoMensual.Name = "btnPagoMensual";
            this.btnPagoMensual.Size = new System.Drawing.Size(191, 49);
            this.btnPagoMensual.TabIndex = 8;
            this.btnPagoMensual.Text = "PAGO MENSUAL";
            this.btnPagoMensual.UseVisualStyleBackColor = false;
            this.btnPagoMensual.Click += new System.EventHandler(this.btnPagoMensual_Click);
            // 
            // btnCarnet
            // 
            this.btnCarnet.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCarnet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCarnet.Location = new System.Drawing.Point(5, 455);
            this.btnCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarnet.Name = "btnCarnet";
            this.btnCarnet.Size = new System.Drawing.Size(191, 50);
            this.btnCarnet.TabIndex = 9;
            this.btnCarnet.Text = "EMITIR CARNET";
            this.btnCarnet.UseVisualStyleBackColor = false;
            this.btnCarnet.Click += new System.EventHandler(this.btnCarnet_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.DarkBlue;
            this.btnListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListado.Location = new System.Drawing.Point(5, 278);
            this.btnListado.Margin = new System.Windows.Forms.Padding(4);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(191, 50);
            this.btnListado.TabIndex = 10;
            this.btnListado.Text = "VENCIMIENTOS";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(28, 522);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 39);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPagoActividad
            // 
            this.btnPagoActividad.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPagoActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoActividad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagoActividad.Location = new System.Drawing.Point(5, 393);
            this.btnPagoActividad.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagoActividad.Name = "btnPagoActividad";
            this.btnPagoActividad.Size = new System.Drawing.Size(192, 54);
            this.btnPagoActividad.TabIndex = 13;
            this.btnPagoActividad.Text = "PAGO ACTIVIDAD DIARIA";
            this.btnPagoActividad.UseVisualStyleBackColor = false;
            this.btnPagoActividad.Click += new System.EventHandler(this.btnPagoActividad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGrillaPr);
            this.panel1.Controls.Add(this.btnRegistroSocio);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnPagoActividad);
            this.panel1.Controls.Add(this.btnCarnet);
            this.panel1.Controls.Add(this.btnListado);
            this.panel1.Controls.Add(this.btnPagoMensual);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 587);
            this.panel1.TabIndex = 14;
            this.panel1.Tag = "panel1";
            // 
            // btnGrillaPr
            // 
            this.btnGrillaPr.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGrillaPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnGrillaPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrillaPr.Location = new System.Drawing.Point(6, 225);
            this.btnGrillaPr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrillaPr.Name = "btnGrillaPr";
            this.btnGrillaPr.Size = new System.Drawing.Size(192, 47);
            this.btnGrillaPr.TabIndex = 0;
            this.btnGrillaPr.Text = "REGISTROS";
            this.btnGrillaPr.UseVisualStyleBackColor = false;
            this.btnGrillaPr.Click += new System.EventHandler(this.btnGrillaPr_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(208, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 465);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ClubDeportivo_DSOO_PI.Properties.Resources.fitmoveRecurso_2_3x;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(208, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 111);
            this.panel3.TabIndex = 16;
            this.panel3.Tag = "panel3";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1156, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistroSocio;
        private System.Windows.Forms.Button btnPagoMensual;
        private System.Windows.Forms.Button btnCarnet;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPagoActividad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGrillaPr;
        private System.Windows.Forms.Panel panel3;
    }
}