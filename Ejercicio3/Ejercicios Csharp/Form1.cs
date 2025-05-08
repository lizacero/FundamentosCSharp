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
        public class Producto
        {
            private string nombre;
            private int precio;

            public Producto(string nombre, int precio)
            {
                this.nombre = nombre;
                this.precio = precio;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public int Precio { get => precio; set => precio = value; }
        }

        public class Comida : Producto
        {
            private string caducidad;
            public Comida(string nombre, int precio, string caducidad) : base(nombre, precio)
            {
                this.caducidad = caducidad;
            }

            public string Caducidad { get => caducidad; set => caducidad = value; }
        }

        public class Herramientas : Producto
        {
            private string material;
            public Herramientas(string nombre, int precio, string material) : base(nombre, precio)
            {
                this.material = material;
            }

            public string Material { get => material; set => material = value; }
        }

        public class Aseo : Producto
        {
            private string uso;
            public Aseo(string nombre, int precio, string uso) : base(nombre, precio)
            {
                this.uso = uso;
            }

            public string Uso { get => uso; set => uso = value; }
        }

        List<Comida> listaComida = new List<Comida>();
        List<Herramientas> listaHerramientas = new List<Herramientas>();
        List<Aseo> listaAseo = new List<Aseo>();
        public int seleccionTipo;

        public Form1()
        {
            InitializeComponent();
        }

        private void From1_Load(object sender, EventArgs e)
        {
            listaComida.Add(new Comida("Arroz", 4500, "3 semanas"));
            listaHerramientas.Add(new Herramientas("Martillo", 45000, "Metal"));
            listaAseo.Add(new Aseo("Detergente", 5000, "Media tapa por uso"));

            comboBoxTipo.Items.Add("Comida");
            comboBoxTipo.Items.Add("Herramientas");
            comboBoxTipo.Items.Add("Aseo");
        }


        private void Agregar_click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            int precioProducto = int.Parse(txtPrecio.Text);
            string descripcionProducto = txtDescripcion.Text;

            switch(seleccionTipo)
            {
                case 0:
                    Comida comida = new Comida(nombreProducto,precioProducto,descripcionProducto);
                    listaComida.Add(comida);
                    break;
                case 1:
                    Herramientas herramienta = new Herramientas(nombreProducto, precioProducto, descripcionProducto);
                    listaHerramientas.Add(herramienta);
                    break;
                case 2:
                    Aseo aseo = new Aseo(nombreProducto, precioProducto, descripcionProducto);
                    listaAseo.Add(aseo);
                    break;
            }

            Cargar_Inventario();
        }

        private void Cargar_Inventario()
        {
            liProductos.Items.Clear();

            foreach (Comida comida in listaComida)
            {
                liProductos.Items.Add(comida.Nombre + "  " + comida.Precio + "  " + comida.Caducidad);
            }
            foreach (Herramientas herramienta in listaHerramientas)
            {
                liProductos.Items.Add(herramienta.Nombre + "  " + herramienta.Precio + "  " + herramienta.Material);
            }
            foreach (Aseo aseo in listaAseo)
            {
                liProductos.Items.Add(aseo.Nombre + "  " + aseo.Precio + "  " + aseo.Uso);
            }
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            Cargar_Inventario();
        }

        private void Comida_click(object sender, EventArgs e)
        {
            liProductos.Items.Clear();
            foreach (Comida comida in listaComida)
            {
                liProductos.Items.Add(comida.Nombre + "  " + comida.Precio + "  " + comida.Caducidad);
            }
        }

        private void Herramientas_click(object sender, EventArgs e)
        {
            liProductos.Items.Clear();
            foreach (Herramientas herramienta in listaHerramientas)
            {
                liProductos.Items.Add(herramienta.Nombre + "  " + herramienta.Precio + "  " + herramienta.Material);
            }
        }

        private void Aseo_click(object sender, EventArgs e)
        {
            liProductos.Items.Clear();
            foreach (Aseo aseo in listaAseo)
            {
                liProductos.Items.Add(aseo.Nombre + "  " + aseo.Precio + "  " + aseo.Uso);
            }
        }

        private void Seleccion_Tipo(object sender, EventArgs e)
        {
            seleccionTipo = comboBoxTipo.SelectedIndex;

            switch(seleccionTipo)
            {
                case 0:
                    lblDescripcion.Text = "Caducidad";
                    break;
                case 1:
                    lblDescripcion.Text = "Material";
                    break;
                case 2:
                    lblDescripcion.Text = "Uso";
                    break;
            }
        }
    }
}
