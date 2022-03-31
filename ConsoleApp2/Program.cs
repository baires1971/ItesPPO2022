using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* los atributos y metodos static o de clase, pertenecen a la clase, no forman parte de los objetos instanciados de dicha clase
              al crearse la aplicacion se reserva memoria ram para estas variables y metodos, aunque no exista ningun objeto de dicha clase
           */


            Profesor Juan = new Profesor("Juan", 30456778, 1.78d, 78);
            Profesor Jose = new Profesor("Jose", 34561223, 1.74d, 80);
            Profesor Amanda = new Profesor("Amanda", 32078555, 1.75d, 75);
            Console.WriteLine("El legajo con variable normal de Juan es: {0}", Juan.GetLegajoNormal());
            Console.WriteLine("El legajo con variable estatica de la clase Profesor es: {0}", Profesor.GetLegajo());
            Console.WriteLine("El legajo variable normal de Jose es: {0}", Jose.GetLegajoNormal());
            Console.WriteLine("El legajo con variable estatica de la clase Profesor es: {0}", Profesor.GetLegajo());
            Console.WriteLine("El legajo variable normal de Amanda es: {0}", Amanda.GetLegajoNormal());
            Console.WriteLine("El legajo con variable estatica de la clase Profesor es: {0}", Profesor.GetLegajo());
            Console.ReadKey();
        }



    }
}






