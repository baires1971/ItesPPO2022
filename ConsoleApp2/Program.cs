using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* podemos crear una clase que hereda las propiedades, metodos y el constructor de otra clase padre
               si la clase padre no tiene constructor la clase hija hereda el constructor por defecto  public Constructor(): base()
               podemos utilizar propiedades en las clases hijas que no creamos, pero que pertenecen a la clase padre
               cuando asignamos un objeto a una variable de la misma clase pero sin instanciar creamos dos referencias o punteros al mismo 
               objeto en memoria
               podemos asignar un objeto de una clase hija a un objeto de clase padre pero no al reves, y cualquier objeto a uno de la 
               clase object que es la clase padre de toda la jerarquia de clases de C#, este principio se llama de sustitucion
               podemos crear un arreglo de una clase padre y asignarle distintos objetos de sus clases hijas.
           */
            
            Profesor Juan = new Profesor("Juan", 27869324, 1.75d, 76d,DateTime.Parse("12/03/2000"));
            Alumno Maria = new Alumno("Maria", 30124665, 1.70d, 65d, DateTime.Parse("05/04/2000"));
            Console.WriteLine("Maria tiene una edad de {0} años", Maria.Edad); //edad no esta definido en la clase alumno
            Console.WriteLine();
            Profesor Jorge = Juan; //creamos dos referencias o punteros al mismo objeto
            Console.WriteLine("Jorge tiene como nombre: {0}", Jorge.Nombre);
            Persona Alguien = Juan;
            //Juan = Alguien; esta asignacion no se puede, asignar una clase padre a una hija
            Object Cualquiera = Juan;
            Cualquiera = Alguien; //esto esta permitido porque la clase object esta en la cuspide de la jerarquia de clases de C#
            Persona[] personas = new Persona[3];
            personas[0] = Juan;  //creamos un arreglo donde podemos tener varios objetos de distintas clases, profesor y alumno
            personas[1] = Maria;
            personas[2] = Jorge;
            // Alguien tiene todos los metodos de la clase persona pero no tiene el metodo de la clase profesor
            Console.WriteLine("la edad de alguien es: {0} pero no tiene legajo como Juan {1}",Alguien.Edad,Juan.Legajo);

            //

        }
    }
}






