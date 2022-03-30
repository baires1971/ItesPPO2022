using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Profesor
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        public Profesor(string nombre, int dni, double altura, double peso)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Altura = altura;
            this.Peso = peso;
        }

    }
}
