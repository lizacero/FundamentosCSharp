using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    class Banano : Frutas
    {
        private string color;
        public Banano(string nombre, string tamano, string color) : base(nombre, tamano)
        {
            this.color = color;
        }

        public override void Madurar()
        {
            this.color = "Amarillo";
        }
    }
}
