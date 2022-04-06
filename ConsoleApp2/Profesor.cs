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
        
        //este metodo abstracto lo sobreescribimos para darle una implimentacion especifica para la clase profesor
        //con el modificador sealed estamos sellando el metodo y todas las clases hijas que hereden este metodo no podran modificarlo o sobreescribirlo
        public sealed override void Firmar() { Console.WriteLine("yo firmo como el profesor {0}", this.Nombre); }

                
        
                        
    }

    internal class Erudito : Profesor 
    {
        public Erudito(string nombre, int dni, double altura, double peso, DateTime nacimiento) : base(nombre, dni, altura, peso, nacimiento) 
        {
        
        }
        public override void Firmar() //el compilador da error al intentar sobreescribir el metodo heredado firmar()
        {
            base.Firmar();
        }

    }

}
