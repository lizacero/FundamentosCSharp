using System.Media;

namespace Topos
{
    public partial class Form1 : Form
    {
        public SoundPlayer BGmusic = new SoundPlayer("Recursos/menu.wav");
        PictureBox imagen = new PictureBox();
        bool yaGolpeado = false;
        bool gameOver = false;
        List<PictureBox> imagenes = new List<PictureBox>();
        Random random = new Random();
        bool topoInicia = true;
        int numeroAux;
        int puntos = 0;
        int mejorPuntaje = 0;
        int fallos = 5;
        string tagAux;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarImgBox();
            BGmusic.PlayLooping();
        }

        private void CargarImgBox()
        {
            int margenIzq = 50;
            int margenTop = 50;
            int columnas = 0;
            int tag = 1;


            for (int i = 0; i < 9; i++)
            {
                PictureBox img = new PictureBox();

                img.Height = 150;
                img.Width = 150;
                img.Image = Image.FromFile("Recursos/imginterrogante1.png");
                img.BackColor = Color.Transparent;
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                img.Tag = tag.ToString();
                tag++;
                img.Click += Img_Click;
                imagenes.Add(img);

                if (tag == 4)
                {
                    tag = 1;
                }
                if (columnas < 3)
                {
                    columnas++;
                    img.Left = margenIzq;
                    img.Top = margenTop;
                    this.Controls.Add(img);
                    margenIzq += 170;
                }
                if (columnas == 3)
                {
                    margenIzq = 50;
                    margenTop += 170;
                    columnas = 0;
                }
            }
        }
        private void Img_Click(object? sender, EventArgs e)
        {
            imagen = (PictureBox)sender;

            if (gameOver)
            {
                return;
            }

            if (!yaGolpeado)
            {
                if(imagen.Tag != "topo")
                {
                    Fallo();
                }
                else
                {
                    yaGolpeado = true;
                    imagen.Image = Image.FromFile("Recursos/golpe" + tagAux + ".png");
                    puntos += 100;

                    if(puntos == 1000)
                    {
                        tmrTopo.Interval = 1000;
                    }
                    else if(puntos == 2000)
                    {
                        tmrTopo.Interval = 700;
                    }

                        lblPuntaje.Text = "Puntos: " + puntos;
                    if(puntos > mejorPuntaje)
                    {
                        mejorPuntaje = puntos;
                        lblMejor.Text = "Mejor: "+mejorPuntaje;
                    }
                }
            }
        }

        private void TimerTopo(object sender, EventArgs e)
        {
            int randomNum = random.Next(0, 9);

            if (topoInicia)
            {
                numeroAux = randomNum;
                tagAux = imagenes[randomNum].Tag.ToString();
                imagenes[randomNum].Image = Image.FromFile("Recursos/animal" + imagenes[randomNum].Tag + ".png");
                imagenes[randomNum].Tag = "topo";
                topoInicia = false;
                yaGolpeado = true;
            }
            else
            {
                while (randomNum == numeroAux)
                {
                    randomNum = random.Next(0, 9);
                }
                imagenes[numeroAux].Image = Image.FromFile("Recursos/imginterrogante1.png");
                imagenes[numeroAux].Tag = tagAux;
                numeroAux = randomNum;
                tagAux = imagenes[randomNum].Tag.ToString();
                imagenes[randomNum].Image = Image.FromFile("Recursos/animal" + imagenes[randomNum].Tag + ".png");
                imagenes[randomNum].Tag = "topo";
            }
            if (!yaGolpeado)
            {
                Fallo();
            }
            yaGolpeado = false;
        }

        private void Comenzar_Click(object sender, EventArgs e)
        {
            tmrTopo.Start();
            if (gameOver)
            {
                Reiniciar_Juego();
            }
            
        }
        
        private void Fallo()
        {
            fallos--;
            lblFallosRestantes.Text = "Fallos restantes: " + fallos;
            if (fallos < 1)
            {
                gameOver = true;
                tmrTopo.Stop();
                MessageBox.Show("Juego Terminado");
            }
        }

        private void Reiniciar_Juego()
        {
            gameOver = false;
            yaGolpeado = true;
            puntos = 0;
            fallos = 5;

            tmrTopo.Interval = 2000;
            lblFallosRestantes.Text = "Fallos restantes: " + fallos;
            lblPuntaje.Text = "Puntaje: " + puntos;
            imagenes[numeroAux].Image = Image.FromFile("Recursos/imginterrogante1.png");
            imagenes[numeroAux].Tag = tagAux;
        }
    }
}
