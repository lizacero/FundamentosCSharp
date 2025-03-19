namespace Ejercicios_Csharp
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
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.Location = new System.Drawing.Point(341, 22);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(169, 68);
            this.btnAmarillo.TabIndex = 0;
            this.btnAmarillo.Text = "Amarillo";
            this.btnAmarillo.UseVisualStyleBackColor = true;
            this.btnAmarillo.Click += new System.EventHandler(this.Color_Amarillo);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(341, 109);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(169, 68);
            this.btnRojo.TabIndex = 1;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.Color_Rojo);
            // 
            // btnNegro
            // 
            this.btnNegro.Location = new System.Drawing.Point(341, 194);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(169, 68);
            this.btnNegro.TabIndex = 2;
            this.btnNegro.Text = "Negro";
            this.btnNegro.UseVisualStyleBackColor = true;
            this.btnNegro.Click += new System.EventHandler(this.Color_Negro);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(341, 281);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(169, 68);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.Color_Reiniciar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 371);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnAmarillo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.From1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnNegro;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

