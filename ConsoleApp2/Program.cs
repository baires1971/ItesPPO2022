using System;



namespace ConsoleApp2
{
    //declaramos un enumerado con los dias de la semana
    enum Dias { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo}

    // declaramos un enumerado y le asignamos un valor a cada constante
    enum NivelGlucosa { Bajo = 100, Medio = 150, Alto = 200, MuyAlto = 300 }
    class Program
    {
        static void Main(string[] args)
        {
            /* Los tipos enumerados son un conjunto de constantes con nombres, sirven para manejar y manipular valores fijos o constantes
             * en un programa. Los tipos enumerados casi siempre se declaran a nivel o dentro de los nameespace para ser utilizados por 
             * varias clases. El compilador le asigna a cada constante de un tipo enumerado un valor de 0 ...n  
             * 
           */

            Dias dia_arrivo = Dias.Viernes;
            Console.WriteLine("El profesor Juan llegara al pais desde madrid el dia {0}", dia_arrivo);
            //string dia_partida = Dias.Miercoles;  esto no se puede porque enum no es string son constantes

            //Si por alguna razon se necesite almacenar en un tipo enumerado un valor nulo se hace de la siguiente manera
            Dias? valor_nulo = null;
            Console.WriteLine("El contenido del enumerado valor_nullo es {0}", valor_nulo);

            //para utilizar el valor numerico del enumerado tenemos que realizar un casting
            int glucosa = (int)NivelGlucosa.Medio * 2;
            Console.WriteLine("El nivel de glucosa es de {0}", glucosa);

        }
    }
}













