namespace Topos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnComenzar = new Button();
            lblMejor = new Label();
            lblPuntaje = new Label();
            lblFallosRestantes = new Label();
            tmrTopo = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnComenzar
            // 
            btnComenzar.BackColor = Color.Transparent;
            btnComenzar.BackgroundImage = (Image)resources.GetObject("btnComenzar.BackgroundImage");
            btnComenzar.BackgroundImageLayout = ImageLayout.Center;
            btnComenzar.FlatAppearance.BorderSize = 0;
            btnComenzar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnComenzar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnComenzar.FlatStyle = FlatStyle.Flat;
            btnComenzar.Location = new Point(644, 217);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(230, 72);
            btnComenzar.TabIndex = 0;
            btnComenzar.UseVisualStyleBackColor = false;
            btnComenzar.Click += Comenzar_Click;
            // 
            // lblMejor
            // 
            lblMejor.AutoSize = true;
            lblMejor.BackColor = Color.Transparent;
            lblMejor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMejor.Location = new Point(679, 319);
            lblMejor.Name = "lblMejor";
            lblMejor.Size = new Size(87, 25);
            lblMejor.TabIndex = 1;
            lblMejor.Text = "Mejor: 0";
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPuntaje.Location = new Point(679, 364);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(101, 25);
            lblPuntaje.TabIndex = 2;
            lblPuntaje.Text = "Puntaje: 0";
            // 
            // lblFallosRestantes
            // 
            lblFallosRestantes.AutoSize = true;
            lblFallosRestantes.BackColor = Color.Transparent;
            lblFallosRestantes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFallosRestantes.Location = new Point(679, 423);
            lblFallosRestantes.Name = "lblFallosRestantes";
            lblFallosRestantes.Size = new Size(167, 25);
            lblFallosRestantes.TabIndex = 3;
            lblFallosRestantes.Text = "Fallos restantes: 5";
            // 
            // tmrTopo
            // 
            tmrTopo.Interval = 2000;
            tmrTopo.Tick += TimerTopo;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(904, 601);
            Controls.Add(lblFallosRestantes);
            Controls.Add(lblPuntaje);
            Controls.Add(lblMejor);
            Controls.Add(btnComenzar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComenzar;
        private Label lblMejor;
        private Label lblPuntaje;
        private Label lblFallosRestantes;
        private System.Windows.Forms.Timer tmrTopo;
    }
}
