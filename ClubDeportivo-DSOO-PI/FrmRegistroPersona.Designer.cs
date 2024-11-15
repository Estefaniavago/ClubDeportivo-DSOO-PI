namespace ClubDeportivo_DSOO_PI
{
    partial class registroPersona
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblAptofisico = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cboxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.chkAptoFisico = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPagarPrimerCuota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR CLIENTE";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(315, 82);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(315, 130);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(315, 177);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(540, 177);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 16);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Número";
            // 
            // lblAptofisico
            // 
            this.lblAptofisico.AutoSize = true;
            this.lblAptofisico.Location = new System.Drawing.Point(315, 245);
            this.lblAptofisico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAptofisico.Name = "lblAptofisico";
            this.lblAptofisico.Size = new System.Drawing.Size(74, 16);
            this.lblAptofisico.TabIndex = 7;
            this.lblAptofisico.Text = "Apto Físico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(388, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 22);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(388, 127);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(111, 22);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(617, 174);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 22);
            this.txtNumero.TabIndex = 10;
            // 
            // cboxTipoDocumento
            // 
            this.cboxTipoDocumento.FormattingEnabled = true;
            this.cboxTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.cboxTipoDocumento.Location = new System.Drawing.Point(388, 174);
            this.cboxTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxTipoDocumento.Name = "cboxTipoDocumento";
            this.cboxTipoDocumento.Size = new System.Drawing.Size(111, 24);
            this.cboxTipoDocumento.TabIndex = 11;
            this.cboxTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboxTipoDocumento_SelectedIndexChanged);
            // 
            // chkAptoFisico
            // 
            this.chkAptoFisico.AutoSize = true;
            this.chkAptoFisico.Location = new System.Drawing.Point(425, 245);
            this.chkAptoFisico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAptoFisico.Name = "chkAptoFisico";
            this.chkAptoFisico.Size = new System.Drawing.Size(18, 17);
            this.chkAptoFisico.TabIndex = 14;
            this.chkAptoFisico.UseVisualStyleBackColor = true;
            this.chkAptoFisico.CheckedChanged += new System.EventHandler(this.chkAptoFisico_CheckedChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(260, 301);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 43);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Agregar Usuario";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClubDeportivo_DSOO_PI.Properties.Resources.crossfit_3180368_1280;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(61, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 272);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(443, 301);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 43);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPagarPrimerCuota
            // 
            this.btnPagarPrimerCuota.Location = new System.Drawing.Point(602, 301);
            this.btnPagarPrimerCuota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagarPrimerCuota.Name = "btnPagarPrimerCuota";
            this.btnPagarPrimerCuota.Size = new System.Drawing.Size(147, 43);
            this.btnPagarPrimerCuota.TabIndex = 19;
            this.btnPagarPrimerCuota.Text = "PAGAR PRIMER CUOTA";
            this.btnPagarPrimerCuota.UseVisualStyleBackColor = true;
            this.btnPagarPrimerCuota.Click += new System.EventHandler(this.btnPagarPrimerCuota_Click);
            // 
            // registroPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 554);
            this.Controls.Add(this.btnPagarPrimerCuota);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkAptoFisico);
            this.Controls.Add(this.cboxTipoDocumento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAptofisico);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "registroPersona";
            this.Text = "Registro Usuario";
            this.TransparencyKey = System.Drawing.Color.Salmon;
            this.Load += new System.EventHandler(this.registroPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblAptofisico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboxTipoDocumento;
        private System.Windows.Forms.CheckBox chkAptoFisico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPagarPrimerCuota;
    }
}