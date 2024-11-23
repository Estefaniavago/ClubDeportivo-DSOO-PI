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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnBorrarFiltro = new System.Windows.Forms.Button();
            this.dtpFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.dtgvVencimientos = new System.Windows.Forms.DataGridView();
            this.lblTituloVencimientos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVencimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(139, 100);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 7;
            // 
            // btnBorrarFiltro
            // 
            this.btnBorrarFiltro.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnBorrarFiltro.Location = new System.Drawing.Point(547, 64);
            this.btnBorrarFiltro.Name = "btnBorrarFiltro";
            this.btnBorrarFiltro.Size = new System.Drawing.Size(138, 31);
            this.btnBorrarFiltro.TabIndex = 6;
            this.btnBorrarFiltro.Text = "Borrar Filtro";
            this.btnBorrarFiltro.UseVisualStyleBackColor = true;
            this.btnBorrarFiltro.Click += new System.EventHandler(this.btnBorrarFiltro_Click);
            // 
            // dtpFiltroFecha
            // 
            this.dtpFiltroFecha.CalendarFont = new System.Drawing.Font("Cambria", 10F);
            this.dtpFiltroFecha.Location = new System.Drawing.Point(205, 68);
            this.dtpFiltroFecha.Name = "dtpFiltroFecha";
            this.dtpFiltroFecha.Size = new System.Drawing.Size(309, 22);
            this.dtpFiltroFecha.TabIndex = 5;
            this.dtpFiltroFecha.ValueChanged += new System.EventHandler(this.dtpFiltroFecha_ValueChanged);
            // 
            // dtgvVencimientos
            // 
            this.dtgvVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVencimientos.Location = new System.Drawing.Point(31, 142);
            this.dtgvVencimientos.Name = "dtgvVencimientos";
            this.dtgvVencimientos.RowHeadersWidth = 51;
            this.dtgvVencimientos.RowTemplate.Height = 24;
            this.dtgvVencimientos.Size = new System.Drawing.Size(879, 235);
            this.dtgvVencimientos.TabIndex = 4;
            // 
            // lblTituloVencimientos
            // 
            this.lblTituloVencimientos.Font = new System.Drawing.Font("Cambria", 20F);
            this.lblTituloVencimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lblTituloVencimientos.Location = new System.Drawing.Point(241, 9);
            this.lblTituloVencimientos.Name = "lblTituloVencimientos";
            this.lblTituloVencimientos.Size = new System.Drawing.Size(560, 41);
            this.lblTituloVencimientos.TabIndex = 0;
            this.lblTituloVencimientos.Tag = "tituloForm";
            this.lblTituloVencimientos.Text = "VENCIMIENTO CUOTAS MENSUALES";
            // 
            // frmVencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 512);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnBorrarFiltro);
            this.Controls.Add(this.dtpFiltroFecha);
            this.Controls.Add(this.dtgvVencimientos);
            this.Controls.Add(this.lblTituloVencimientos);
            this.Name = "frmVencimientos";
            this.Text = "frmVencimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVencimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVencimientos;
        private System.Windows.Forms.DataGridView dtgvVencimientos;
        private System.Windows.Forms.DateTimePicker dtpFiltroFecha;
        private System.Windows.Forms.Button btnBorrarFiltro;
        private System.Windows.Forms.Label lblMensaje;
    }
}