using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cuando no queremos que una clase que creamos pueda ser heredara de otra clase hija, o si queremos que cuando creamos una clase
             * que hereda de otra y no podamos sobreescribir algun metodo en particular, utilizamos el modificar sealed, 
             * es decir creamos clases o metodos sellados, con clases o metodos que no se pueden heredar o sobreescribir.
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












