using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    class Frutas
    {
        //ATRIBUTOS
        private string nombre;
        private string tamano;

        //MÉTODOS
        public Frutas(string nombre, string tamano)
        {
            this.nombre = nombre;
            this.tamano = tamano;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }

        public string Tamano { get => tamano; set => tamano = value; }

        public virtual void Madurar() 
        {
            //polimorfismo
        }
    }
}
