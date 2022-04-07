using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Alumno
    {
        public double Edad { get; set; }
        public string Nombre { get; set; }

        public Alumno(string _nombre, int _edad) 
        {
           this.Nombre = _nombre;
           this.Edad = _edad;
        }
    }
}
