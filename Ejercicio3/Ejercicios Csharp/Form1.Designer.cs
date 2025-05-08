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
            this.btnInventario = new System.Windows.Forms.Button();
            this.liProductos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnAseo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(314, 88);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(169, 68);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // liProductos
            // 
            this.liProductos.FormattingEnabled = true;
            this.liProductos.Location = new System.Drawing.Point(508, 88);
            this.liProductos.Name = "liProductos";
            this.liProductos.Size = new System.Drawing.Size(224, 355);
            this.liProductos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUCTOS";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(39, 156);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(192, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre del producto";
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(314, 185);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(169, 68);
            this.btnComida.TabIndex = 8;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            this.btnComida.Click += new System.EventHandler(this.Comida_click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Location = new System.Drawing.Point(314, 279);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(169, 68);
            this.btnHerramientas.TabIndex = 9;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.Herramientas_click);
            // 
            // btnAseo
            // 
            this.btnAseo.Location = new System.Drawing.Point(314, 375);
            this.btnAseo.Name = "btnAseo";
            this.btnAseo.Size = new System.Drawing.Size(169, 68);
            this.btnAseo.TabIndex = 10;
            this.btnAseo.Text = "Aseo";
            this.btnAseo.UseVisualStyleBackColor = true;
            this.btnAseo.Click += new System.EventHandler(this.Aseo_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(52, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 68);
            this.button4.TabIndex = 11;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Agregar_click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(39, 201);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(192, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Precio";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(39, 243);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(192, 21);
            this.comboBoxTipo.TabIndex = 14;
            this.comboBoxTipo.Text = "Tipo de producto";
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.Seleccion_Tipo);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(36, 290);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(39, 315);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(192, 20);
            this.txtDescripcion.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 479);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAseo);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liProductos);
            this.Controls.Add(this.btnInventario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.From1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.ListBox liProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnAseo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}

