using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* podemos crear clases anonimas con las siguientes restricciones: no pueden contener atributos publicos, 
             los atributos deben estar inicializados y no pueden ser static, no se pueden definir metodos   
           */


            Profesor Juan = new Profesor("Juan", 30456778, 1.78d, 78);
            var Jose = new { Nombre = "Jose", Dni = 43555709, Altura = 1.72d, Peso = 76 };//jose es de una clase anonima
            var Amanda = new { Nombre = "Amanda", Dni = 32078555, Altura = 1.75d, Peso = 75 };
            //como las clases anonimas de jose y amanda, tienen los atributos de igual cantidad, tipo y orden, son la misma clase anonima
            Jose = Amanda;//como son de la misma clase anonima podemos hacer esta asignacion
            Console.WriteLine("El profesor {0} mide {1} metros de altura y pesa {2} kilogramos", Jose.Nombre,Jose.Altura, Jose.Peso);
            Console.WriteLine("La profesora {0} mide {1} metros de altura y pesa {2} kilogramos", Amanda.Nombre, Amanda.Altura, Amanda.Peso);
            Console.ReadKey();
        }



    }
}






