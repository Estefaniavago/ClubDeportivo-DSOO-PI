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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(236, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENÚ PRINCIPAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistroSocio
            // 
            this.btnRegistroSocio.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRegistroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroSocio.Location = new System.Drawing.Point(24, 108);
            this.btnRegistroSocio.Name = "btnRegistroSocio";
            this.btnRegistroSocio.Size = new System.Drawing.Size(185, 66);
            this.btnRegistroSocio.TabIndex = 7;
            this.btnRegistroSocio.Text = "REGISTRAR SOCIO";
            this.btnRegistroSocio.UseVisualStyleBackColor = false;
            this.btnRegistroSocio.Click += new System.EventHandler(this.btnRegistroSocio_Click_1);
            // 
            // btnPagoMensual
            // 
            this.btnPagoMensual.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPagoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoMensual.Location = new System.Drawing.Point(446, 114);
            this.btnPagoMensual.Name = "btnPagoMensual";
            this.btnPagoMensual.Size = new System.Drawing.Size(185, 66);
            this.btnPagoMensual.TabIndex = 8;
            this.btnPagoMensual.Text = "PAGO MENSUAL";
            this.btnPagoMensual.UseVisualStyleBackColor = false;
            this.btnPagoMensual.Click += new System.EventHandler(this.btnPagoMensual_Click);
            // 
            // btnCarnet
            // 
            this.btnCarnet.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarnet.Location = new System.Drawing.Point(24, 213);
            this.btnCarnet.Name = "btnCarnet";
            this.btnCarnet.Size = new System.Drawing.Size(185, 66);
            this.btnCarnet.TabIndex = 9;
            this.btnCarnet.Text = "EMITIR CARNET";
            this.btnCarnet.UseVisualStyleBackColor = false;
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.Aquamarine;
            this.btnListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.Location = new System.Drawing.Point(230, 213);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(185, 66);
            this.btnListado.TabIndex = 10;
            this.btnListado.Text = "VENCIMIENTOS";
            this.btnListado.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(243, 312);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(185, 66);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ClubDeportivo_DSOO_PI.Properties.Resources.fitmoveRecurso_2_3x;
            this.pictureBox1.Location = new System.Drawing.Point(299, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(435, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 66);
            this.button2.TabIndex = 13;
            this.button2.Text = "PAGO ACTIVIDAD DIARIA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(688, 415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnCarnet);
            this.Controls.Add(this.btnPagoMensual);
            this.Controls.Add(this.btnRegistroSocio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistroSocio;
        private System.Windows.Forms.Button btnPagoMensual;
        private System.Windows.Forms.Button btnCarnet;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button2;
    }
}