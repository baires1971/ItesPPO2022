using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Profesor: Persona
    {
        //-------------------PROPIEDADES---------------
        public int Legajo { get; set; }
        //---------CONSTRUCTOR DE LA CLASE-------------------
        public Profesor(string nombre, int dni, double altura, double peso, DateTime nacimiento) : base(nombre, dni, altura, peso, nacimiento)
        {
            this.Legajo = 100;
        }
        //-----------------METODOS------------------------------
    }
}
