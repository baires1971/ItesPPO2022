using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* cuando declaramos como publico el metodo calculararea, este se puede usar fuera del ambito de la clase cuadrado
               en cambio la propiedad lado no puede ser accedida fuera de la clase, en virtud a la propiedad de encapsulamiento 
               que tienen los objetos.
            */
            Cuadrado figura;
            figura = new Cuadrado();
            Console.WriteLine("el area del cuadrado es: {0}", figura.CalcularArea());
            Console.ReadKey();
        }
    }

    class Cuadrado
    {
        private double lado = 10; // cuando declaramos private a una propiedad o metodo este no puede ser accedido desde 
                                  // fuera de la clase contenedora. Si no especificamos nada por defecto C# toma como 
                                  // privadas todas las propiedades y metodos, siguiendo el concepto de encapsulamiento	

        public double CalcularArea()
        {
            return lado * lado;
        }

    }



}








