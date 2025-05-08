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
            this.btnAprender = new System.Windows.Forms.Button();
            this.liHabilidades = new System.Windows.Forms.ListBox();
            this.liAprendidas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHabilidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(48, 261);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(169, 68);
            this.btnAprender.TabIndex = 0;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.Aprender_Click);
            // 
            // liHabilidades
            // 
            this.liHabilidades.FormattingEnabled = true;
            this.liHabilidades.Location = new System.Drawing.Point(272, 105);
            this.liHabilidades.Name = "liHabilidades";
            this.liHabilidades.Size = new System.Drawing.Size(176, 303);
            this.liHabilidades.TabIndex = 1;
            // 
            // liAprendidas
            // 
            this.liAprendidas.FormattingEnabled = true;
            this.liAprendidas.Location = new System.Drawing.Point(487, 105);
            this.liAprendidas.Name = "liAprendidas";
            this.liAprendidas.Size = new System.Drawing.Size(176, 303);
            this.liAprendidas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "HABILIDADES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "APRENDIDAS";
            // 
            // txtHabilidad
            // 
            this.txtHabilidad.Location = new System.Drawing.Point(38, 210);
            this.txtHabilidad.Name = "txtHabilidad";
            this.txtHabilidad.Size = new System.Drawing.Size(192, 20);
            this.txtHabilidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Habilidad a aprender";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(35, 119);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(85, 20);
            this.lblPuntos.TabIndex = 7;
            this.lblPuntos.Text = "Puntos: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 479);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHabilidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liAprendidas);
            this.Controls.Add(this.liHabilidades);
            this.Controls.Add(this.btnAprender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.From1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.ListBox liHabilidades;
        private System.Windows.Forms.ListBox liAprendidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHabilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuntos;
    }
}

