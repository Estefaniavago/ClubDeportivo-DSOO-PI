namespace ClubDeportivo_DSOO_PI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.Txtcontrasenia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LogoClub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoClub)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(424, 117);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(285, 20);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.Text = "USUARIO";
            // 
            // Txtcontrasenia
            // 
            this.Txtcontrasenia.Location = new System.Drawing.Point(424, 188);
            this.Txtcontrasenia.Name = "Txtcontrasenia";
            this.Txtcontrasenia.Size = new System.Drawing.Size(285, 20);
            this.Txtcontrasenia.TabIndex = 1;
            this.Txtcontrasenia.Text = "CONTRASEÑA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(518, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LogoClub
            // 
            this.LogoClub.Image = ((System.Drawing.Image)(resources.GetObject("LogoClub.Image")));
            this.LogoClub.Location = new System.Drawing.Point(82, 74);
            this.LogoClub.Name = "LogoClub";
            this.LogoClub.Size = new System.Drawing.Size(298, 242);
            this.LogoClub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoClub.TabIndex = 3;
            this.LogoClub.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoClub);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtcontrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox Txtcontrasenia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox LogoClub;
    }
}

