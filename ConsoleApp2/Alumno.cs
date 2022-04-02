using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Alumno: Persona
    {
        //---------PROPIEDADES-----------------
        public int Matricula { get; set; }
        //--------CONSTRUCTOR DE CLASE-----------
        public Alumno(string nombre, int dni, double altura, double peso, DateTime nacimiento):base(nombre, dni,altura, peso, nacimiento)  
        {
        
        }
        //---------------METODOS-----------------

        //agregamos el modificador override para indicar que estamos modificando el metodo firmar de la clase padre
        public override void Firmar() { Console.WriteLine("yo firmo como el alumno {0}", this.Nombre); }
    }
}
