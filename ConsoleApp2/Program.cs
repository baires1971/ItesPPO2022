using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  declaramos una variable figura como un objeto de la clase cuadrado
                luego creamos el objeto o instanciamos la clase con la orden new
                el metodo calculararea() no puede ser accedido con la declaracion "." del
                objeto figura 	

           */
            Cuadrado figura;
            figura = new Cuadrado();
            Console.WriteLine("el area del cuadrado es: {0}", figura);
        }
    }

    class Cuadrado
    {
        double lado = 10; // propiedad de la clase cuadrado en este caso privado por defecto

        double CalcularArea(double lado) // metodo de la clase cuadrado que calcula su area
        {
            return lado * lado;
        }

    }



}






