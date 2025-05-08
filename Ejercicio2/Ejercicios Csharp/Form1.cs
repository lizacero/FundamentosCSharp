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
        public class Habilidad
        {
            private string nombre;
            private int precio;

            public Habilidad(string nombre, int precio)
            {
                this.nombre = nombre;
                this.precio = precio;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public int Precio { get => precio; set => precio = value; }
        }

        List<Habilidad> habilidades = new List<Habilidad>();
        List<Habilidad> habilidadesAprendidas = new List<Habilidad>();
        private int puntos = 15;
        Habilidad bolaFuego = new Habilidad("Bola de fuego", 7);
        Habilidad curacion = new Habilidad("Curación", 3);
        Habilidad estocada = new Habilidad("Estocada", 4);
        Habilidad revivir = new Habilidad("Revivir", 12);

        public Form1()
        {
            InitializeComponent();
        }

        private void From1_Load(object sender, EventArgs e)
        {
            lblPuntos.Text = "Puntos: " + puntos.ToString();
            habilidades.Add(bolaFuego);
            habilidades.Add(curacion);
            habilidades.Add(estocada);
            habilidades.Add(revivir);

            Cargar_Lista(1, habilidades);
        }

        private void Cargar_Lista(int i, List<Habilidad> lista)
        {
            switch (i)
            {
                case 1:
                    liHabilidades.Items.Clear();
                    foreach(Habilidad habilidad in lista)
                    {
                        liHabilidades.Items.Add(habilidad.Nombre +"     "+ habilidad.Precio.ToString());
                    }
                    break;
                case 2:
                    liAprendidas.Items.Clear();
                    foreach (Habilidad habilidad in lista)
                    {
                        liAprendidas.Items.Add(habilidad.Nombre +"     "+ habilidad.Precio.ToString());
                    }
                    break;
            }
        }

        private void Aprender_Click(object sender, EventArgs e)
        {
            string habilidadAprender = txtHabilidad.Text;
            bool existe = false;
            int indice = 0;

            foreach(Habilidad habilidad in habilidades)
            {
                if (habilidadAprender.ToLower() == habilidad.Nombre.ToLower())
                {
                    existe = true;
                    indice = habilidades.IndexOf(habilidad);
                }
            }
            if (!existe)
            {
                MessageBox.Show("La habilidad no existe.");
            }
            else
            {
                if (habilidades[indice].Precio <= puntos)
                {
                    puntos -= habilidades[indice].Precio;
                    habilidadesAprendidas.Add(habilidades[indice]);
                    habilidades.RemoveAt(indice);

                    Cargar_Lista(1, habilidades);
                    Cargar_Lista(2, habilidadesAprendidas);
                    lblPuntos.Text =  "Puntos: " + puntos.ToString();
                }
                else
                {
                    MessageBox.Show("Puntos insuficientes.");
                }
            }
        }
    }
}
