using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Csharp
{
    public partial class Form1: Form
    {
        PictureBox recuadro1 = new PictureBox();
        PictureBox recuadro2 = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void From1_Load(object sender, EventArgs e)
        {
            recuadro1.Top = 20;
            recuadro1.Left = 50;
            recuadro1.Height = 150;
            recuadro1.Width = 150;
            recuadro1.BackColor = Color.AliceBlue;
            this.Controls.Add(recuadro1);

            recuadro2.Top = 200;
            recuadro2.Left = 50;
            recuadro2.Height = 150;
            recuadro2.Width = 150;
            recuadro2.BackColor = Color.AliceBlue;
            this.Controls.Add(recuadro2);
        }

        private void Color_Amarillo(object sender, EventArgs e)
        {
            recuadro1.BackColor = Color.Yellow;
            recuadro2.BackColor = Color.Yellow;
        }

        private void Color_Rojo(object sender, EventArgs e)
        {
            recuadro1.BackColor = Color.Red;
            recuadro2.BackColor = Color.Red;
        }

        private void Color_Negro(object sender, EventArgs e)
        {
            recuadro1.BackColor = Color.Black;
            recuadro2.BackColor = Color.Black;
        }

        private void Color_Reiniciar(object sender, EventArgs e)
        {
            recuadro1.BackColor = Color.AliceBlue;
            recuadro2.BackColor = Color.AliceBlue;
        }

        
    }
}
