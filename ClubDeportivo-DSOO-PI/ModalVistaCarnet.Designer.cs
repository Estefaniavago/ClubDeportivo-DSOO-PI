namespace ClubDeportivo_DSOO_PI
{
    partial class ModalVistaCarnet
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
            this.pbVistaPrevia = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVistaPrevia
            // 
            this.pbVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVistaPrevia.Location = new System.Drawing.Point(100, 50);
            this.pbVistaPrevia.Name = "pbVistaPrevia";
            this.pbVistaPrevia.Size = new System.Drawing.Size(600, 300);
            this.pbVistaPrevia.TabIndex = 0;
            this.pbVistaPrevia.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(350, 400);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ModalVistaCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pbVistaPrevia);
            this.Name = "ModalVistaCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalVistaCarnet";
            ((System.ComponentModel.ISupportInitialize)(this.pbVistaPrevia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVistaPrevia;
        private System.Windows.Forms.Button btnImprimir;
    }
}