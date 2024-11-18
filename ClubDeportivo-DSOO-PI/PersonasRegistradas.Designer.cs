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
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnGrillaEliminar = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPersonasRegistradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Location = new System.Drawing.Point(43, 94);
            this.dtgvRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersWidth = 51;
            this.dtgvRegistro.Size = new System.Drawing.Size(482, 202);
            this.dtgvRegistro.TabIndex = 17;
            this.dtgvRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRegistro_CellContentClick);
            // 
            // btnGrillaEliminar
            // 
            this.btnGrillaEliminar.Location = new System.Drawing.Point(159, 2);
            this.btnGrillaEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrillaEliminar.Name = "btnGrillaEliminar";
            this.btnGrillaEliminar.Size = new System.Drawing.Size(104, 35);
            this.btnGrillaEliminar.TabIndex = 18;
            this.btnGrillaEliminar.Text = "Eliminar Cliente";
            this.btnGrillaEliminar.UseVisualStyleBackColor = true;
            this.btnGrillaEliminar.Click += new System.EventHandler(this.btnGrillaEliminar_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(2, 2);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAgregarCliente.Size = new System.Drawing.Size(123, 35);
            this.btnAgregarCliente.TabIndex = 19;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarCliente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGrillaEliminar, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 300);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 58);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // lblPersonasRegistradas
            // 
            this.lblPersonasRegistradas.AutoSize = true;
            this.lblPersonasRegistradas.Location = new System.Drawing.Point(286, 28);
            this.lblPersonasRegistradas.Name = "lblPersonasRegistradas";
            this.lblPersonasRegistradas.Size = new System.Drawing.Size(146, 13);
            this.lblPersonasRegistradas.TabIndex = 22;
            this.lblPersonasRegistradas.Text = "PERSONAS REGISTRADAS";
            // 
            // PersonasRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 445);
            this.Controls.Add(this.lblPersonasRegistradas);
            this.Controls.Add(this.dtgvRegistro);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PersonasRegistradas";
            this.Text = "PersonasRegistradas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.Button btnGrillaEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPersonasRegistradas;
    }
}