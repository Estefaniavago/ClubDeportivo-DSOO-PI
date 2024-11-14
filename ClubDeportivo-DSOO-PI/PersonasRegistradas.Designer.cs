namespace ClubDeportivo_DSOO_PI
{
    partial class PersonasRegistradas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnGrillaEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(473, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 41);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Personas Registradas";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Location = new System.Drawing.Point(117, 228);
            this.dtgvRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersWidth = 51;
            this.dtgvRegistro.Size = new System.Drawing.Size(1015, 159);
            this.dtgvRegistro.TabIndex = 17;
            this.dtgvRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRegistro_CellContentClick);
            // 
            // btnGrillaEliminar
            // 
            this.btnGrillaEliminar.Location = new System.Drawing.Point(473, 450);
            this.btnGrillaEliminar.Name = "btnGrillaEliminar";
            this.btnGrillaEliminar.Size = new System.Drawing.Size(164, 43);
            this.btnGrillaEliminar.TabIndex = 18;
            this.btnGrillaEliminar.Text = "Eliminar Cliente";
            this.btnGrillaEliminar.UseVisualStyleBackColor = true;
            this.btnGrillaEliminar.Click += new System.EventHandler(this.btnGrillaEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1029, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PersonasRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGrillaEliminar);
            this.Controls.Add(this.dtgvRegistro);
            this.Controls.Add(this.textBox1);
            this.Name = "PersonasRegistradas";
            this.Text = "PersonasRegistradas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.Button btnGrillaEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}