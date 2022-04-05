using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* una clase puede ser obligada a tener un comportamiento determinado mediante la implementacion de interfaces
             * Básicamente nos permiten definir un "contrato" sobre el que podemos estar seguros de que, las clases que las implementen, lo van a cumplir.
             * las intefaces declaran solamente propiedades o metodos, por definicion son siempre publicos. pero su implementacion y codificacion
             * queda bajo la responsabilidad de la clase que hereda la interface. es decir la interface nos dice que metodos tiene que tener la clase
             * pero no impone como hacerlos. Siempre la clase hereda de una clase padre y despues de una, dos o mas interfaces.
             * 
             */

            Directivo Miguel = new Directivo("Miguel", 23456921, 1.73d, 78d, DateTime.Parse("12/07/2000"));
            Miguel.UsarPedagogia();  //metodo heredado de la interface IDocente
            Miguel.UsarExcel();      //metodo heredado de la interface IAdministrativo  
            Console.WriteLine(Miguel.Edad); //propiedad heredada de la clase persona
        }
    }
}






