using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* las clases abstractas generalmente inician una jerarquia de clases, tienen por lo menos 1 metodo abstracto, el cual 
             * es declarado en la clase abstracta pero no implementada. esto obliga a las clases hijas que heredan a implementar los metodos
             * abstractos. una clase abstracta puede tener metodos normales y abstractos a la vez
             *               
           */
            Profesor Juan = new Profesor("Juan", 23456789, 1.75d, 86d, DateTime.Parse("12/07/2001"));
            Alumno Carlos = new Alumno("Carlos", 26656897, 1.65d, 78d, DateTime.Parse("10/10/2000"));
            Directivo Francisco = new Directivo("Francisco", 33454847, 1.72d, 70d, DateTime.Parse("01/12/2002"));
            Juan.Firmar(); //metodo abstracto heredado de la clase persona e implementado para la clase Profesor
            Carlos.Firmar(); //metodo abstracto heredado de la clase persona e implementado para la clase Alumno
            Francisco.Firmar(); //metodo abstracto heredado de la clase persona e implementado para la clase Alumno

        }
    }
}












