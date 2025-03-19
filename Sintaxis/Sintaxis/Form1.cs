namespace Sintaxis
{
    public partial class Form1 : Form
    {
        //ENTERO - byte, short, int, long
        private int numero = 1;
        private int numero2 = 2;

        //Flotante - float, double
        private float numFloat = 1.115f;
        private double numDouble = 1.6434;

        //BOOLEANOS - bool
        private bool condicion = false;
        private bool condicion2 = true;

        //STRING - string
        private string palabra = "palabra";
        public Form1()
        {
            InitializeComponent();
        }

        private void Sintaxis(object sender, EventArgs e)
        {
            //OPERADORES ARITMÉTICOS + - * / % ++ --
            numero++; // numero = numero + 1
            numero--;

            //ASIGNACIÓN COMPUESTA op= += -= /= %=
            numero2 -= 4; //Numero2 = numero2 + 4

            //OPERADORES DE COMPARACIÓN < <= > >= != ==
            condicion = numero < numero2; //true
            condicion2 = numero2 <= numero; //false

            //OPERADORES LÓGICOS  && || !
            bool condicion3 = !condicion || (condicion && numero > 10);

            //CONDICIONALES - if, else if, else
            if (condicion)
            {
                //Acciones 
            }
            else if (condicion2 && condicion3)
            {
                //Acciones # 2
            }
            else
            {
                //Acciones # 3
            }

            switch (numero)
            {
                case 1:
                    //instrucciones
                    break;
                case 2:
                    //instrucciones 2
                    break;
            }

            //BUCLE FOR
            for (int i = 1; i <= 10; i++)
            {
                //Instrucciones a repetirse
            }

            //WHILE Y DO WHILE
            while (numero < 10)
            {
                //instrucciones a repetirse
                numero++;
            }
            do
            {
                //INSTRUCCIONES
            } while (numero < 10);

            //ARRAYS Y LISTAS
            int[] numeros = new int[3] { 1, 2, 3 };
            string[] palabras = { "palabra1", "palabra2" };

            numeros[0] = 10;
            numero = numeros[0];

            List<int> listaEnteros = new List<int>() { 1, 2, 3, 4, 2 };

            listaEnteros[0] = 10;

            listaEnteros.Add(5);
            listaEnteros.Remove(2);
            listaEnteros.RemoveAt(0);
            listaEnteros.Clear();
            listaEnteros.Sort();
            listaEnteros.Reverse();

            foreach (int i in listaEnteros)
            {
                //INSTRUCCIONES
            }

            numero = Sumar1(4);

        }

        private int Sumar1(int num)
        {
            num += 1;
            return num;
        }

        private void CrearObjeto()
        {
            string nombreFruta;
            string tamanoFruta;
            Frutas fruta1 = new Frutas("Frutal", "Pequeño");

            fruta1.SetNombre("Nueva Fruta 1");
            nombreFruta = fruta1.GetNombre();
            fruta1.Tamano = "Mediano";
            tamanoFruta = fruta1.Tamano;

            Naranja naranja = new Naranja("Naranja", "Pequeño", "Verde");
            naranja.Madurar(); // color = Naranja

            Banano banano = new Banano("Banano", "Mediano", "Verde");
            banano.Madurar(); // color = Amarillo
        }
    }
}
