namespace AP14EJ02
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.pcbTriangulo = new System.Windows.Forms.PictureBox();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbDatos.Controls.Add(this.btnComprobar);
            this.grbDatos.Controls.Add(this.txtLado3);
            this.grbDatos.Controls.Add(this.txtLado2);
            this.grbDatos.Controls.Add(this.txtLado1);
            this.grbDatos.Controls.Add(this.lblLado3);
            this.grbDatos.Controls.Add(this.lblLado2);
            this.grbDatos.Controls.Add(this.lblLado1);
            this.grbDatos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(28, 21);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(204, 187);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos del Triángulo";
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(56, 139);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(96, 30);
            this.btnComprobar.TabIndex = 6;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(86, 98);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 26);
            this.txtLado3.TabIndex = 5;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(86, 66);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 26);
            this.txtLado2.TabIndex = 4;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(86, 35);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 26);
            this.txtLado1.TabIndex = 3;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(20, 102);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(50, 20);
            this.lblLado3.TabIndex = 2;
            this.lblLado3.Text = "lado 3:";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(16, 69);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(54, 20);
            this.lblLado2.TabIndex = 1;
            this.lblLado2.Text = "Lado 2:";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(16, 36);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(54, 20);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1:";
            // 
            // pcbTriangulo
            // 
            this.pcbTriangulo.Image = global::AP14EJ02.Properties.Resources.isosceles;
            this.pcbTriangulo.Location = new System.Drawing.Point(268, 21);
            this.pcbTriangulo.Name = "pcbTriangulo";
            this.pcbTriangulo.Size = new System.Drawing.Size(228, 187);
            this.pcbTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTriangulo.TabIndex = 1;
            this.pcbTriangulo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 238);
            this.Controls.Add(this.pcbTriangulo);
            this.Controls.Add(this.grbDatos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobación de triángulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTriangulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.PictureBox pcbTriangulo;
    }
}

