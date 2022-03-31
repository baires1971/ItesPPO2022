using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* podemos crear arreglos con objetos o de clases anonimas y recorrerlos con for() y foreach()    
           */

            //declaramos un array de manera explicita
            int[] datos = new int[3];
            datos[0] = 1;
            datos[1] = 2;
            datos[2] = 3;
            for (int i = 0; i < datos.Length; i++) { Console.WriteLine(datos[i]); }
            Console.WriteLine();

            int[] valores = { 2, 3, 4, 5 };
            foreach(int val in valores) { Console.WriteLine(val); }
            Console.WriteLine();

            //declaramos un array de manera implicita
            var numeros = new[] { 1, 3, 4, 5 };
            for(var i = 0; i < numeros.Length; i++) { Console.WriteLine(numeros[i]); }
            Console.WriteLine();

            //declaramos un array de objetos Profesor
            Profesor Juan = new Profesor("Juan", 30456778, 1.78d, 78);
            Profesor Jose = new Profesor("Jose", 23456789, 1.71d, 75);
            Profesor[] profesores = new Profesor[] { Juan, Jose };
            for( int i = 0; i < profesores.Length; i++) 
            {
                Console.WriteLine("El profesor {0} tiene una altura de {1}",profesores[i].Nombre, profesores[i].Altura);
            }
            Console.WriteLine();

            Profesor[] profesores_ver2 = new Profesor[2];
            profesores_ver2[0] = new Profesor("Juan", 30456778, 1.78d, 78);
            profesores_ver2[1] = new Profesor("Jose", 23456789, 1.71d, 75);

            Profesor[] profesores_ver3 = { new Profesor("Juan", 30456778, 1.78d, 78), new Profesor("Jose", 23456789, 1.71d, 75) } ;

            Profesor[] profesores_ver4 = new Profesor[2];
            profesores_ver4[0] = Juan;
            profesores_ver4[1] = Jose;
            foreach( Profesor profesor in profesores)
            {
                Console.WriteLine("El profesor {0} tiene una altura de {1}", profesor.Nombre, profesor.Altura);
            }
            Console.WriteLine();

            //declaramos un array de clases anonimas
            var datosAnonimos = new[]
            {
                new {Nombre = "Juan", Dni = 30456778, Altura =  1.78d, Edad =  78},
                new {Nombre = "Jose", Dni = 23456789, Altura = 1.71d, Edad = 75}
            };
            foreach(var dato in datosAnonimos) 
            {
              Console.WriteLine("El profesor {0} tiene una altura de {1}", dato.Nombre, dato.Altura);
            }

            Console.ReadKey();
        }



    }
}






