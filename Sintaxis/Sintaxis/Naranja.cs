using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    class Naranja : Frutas
    {
        private string color;
        public Naranja(string nombre, string tamano, string color) : base(nombre, tamano)
        {
            this.color = color;
        }

        public string Color { get => color; set => color = value; }

        public override void Madurar()
        {
            this.color = "Naranja";
        }

    }
}
