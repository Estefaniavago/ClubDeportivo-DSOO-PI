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
            this.lblPersonasRegistradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PersonasRegistradas";
            this.Text = "PersonasRegistradas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.Label lblPersonasRegistradas;
    }
}