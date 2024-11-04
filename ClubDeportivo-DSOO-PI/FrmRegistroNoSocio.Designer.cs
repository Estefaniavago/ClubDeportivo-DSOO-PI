namespace ClubDeportivo_DSOO_PI
{
    partial class FrmRegistroNoSocio
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.chkAptoFisico = new System.Windows.Forms.CheckBox();
            this.cboxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAptofisico = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Condición";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(612, 264);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(648, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 25);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "VOLVER";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Location = new System.Drawing.Point(59, 310);
            this.dtgvRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersWidth = 51;
            this.dtgvRegistro.Size = new System.Drawing.Size(628, 129);
            this.dtgvRegistro.TabIndex = 34;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(366, 264);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 29);
            this.btnRegistrar.TabIndex = 33;
            this.btnRegistrar.Text = "Agregar Usuario";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // chkAptoFisico
            // 
            this.chkAptoFisico.AutoSize = true;
            this.chkAptoFisico.Location = new System.Drawing.Point(430, 219);
            this.chkAptoFisico.Name = "chkAptoFisico";
            this.chkAptoFisico.Size = new System.Drawing.Size(15, 14);
            this.chkAptoFisico.TabIndex = 32;
            this.chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // cboxTipoDocumento
            // 
            this.cboxTipoDocumento.FormattingEnabled = true;
            this.cboxTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.cboxTipoDocumento.Location = new System.Drawing.Point(416, 141);
            this.cboxTipoDocumento.Name = "cboxTipoDocumento";
            this.cboxTipoDocumento.Size = new System.Drawing.Size(100, 21);
            this.cboxTipoDocumento.TabIndex = 31;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(575, 141);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 30;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(416, 103);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(416, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // lblAptofisico
            // 
            this.lblAptofisico.AutoSize = true;
            this.lblAptofisico.Location = new System.Drawing.Point(368, 219);
            this.lblAptofisico.Name = "lblAptofisico";
            this.lblAptofisico.Size = new System.Drawing.Size(61, 13);
            this.lblAptofisico.TabIndex = 27;
            this.lblAptofisico.Text = "Apto Físico";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(362, 188);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(54, 13);
            this.lblSocio.TabIndex = 26;
            this.lblSocio.Text = "Condición";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(528, 143);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 25;
            this.lblNumero.Text = "Número";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(364, 144);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "Tipo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(364, 106);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 23;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(364, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClubDeportivo_DSOO_PI.Properties.Resources.crossfit_3180368_1280;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(46, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 221);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "REGISTRAR NO SOCIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmRegistroNoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgvRegistro);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkAptoFisico);
            this.Controls.Add(this.cboxTipoDocumento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAptofisico);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroNoSocio";
            this.Text = "Registro No Socio";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.CheckBox chkAptoFisico;
        private System.Windows.Forms.ComboBox cboxTipoDocumento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAptofisico;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}