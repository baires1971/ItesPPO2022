using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Podemos pasar un objeto como parametro en un metodo o funcion, como las clases, objetos y arrays son del tipo referencia
             cualquier cambio que hagamos dentro del metodo afectara al objeto definido exteriormente al metodo

            */
            Alumno juan;
            Alumno maria;
            Profesor hugo; //la clase profesor esta definida en un archivo independiente llamado profesor.cs
            juan = new Alumno();
            maria = new Alumno("Maria"); // podemos tener una sobrecarga de constructores de la clase Alumno
            hugo = new Profesor("hugo", 12333432, 1.7, 90);
            CambiarAlturaProfesor(hugo, 1.8d);
            juan.setNombre("Juan");
            maria.setNacimiento("4/4/2004");
            juan.Altura = 1.80;   //accedemos a la propiedad altura
            maria.Altura = juan.Altura;
            juan.Peso = 90;
            maria.Peso = 70;
            maria.Peso += 5; //puedo sumar, incrementar una propiedad como si accedieramos directamente a la variable del atributo
            juan.Password = "1234";
            juan.Dni = 30456789;
            Console.WriteLine("L edad de {0} es: {1} , la altura : {2} metros y el peso: {3} kilos", juan.getNombre(), juan.getEdad(), juan.Altura, juan.Peso);
            Console.WriteLine("La edad de {0} es: {1} , la altura : {2} metros y el peso: {3} kilos", maria.getNombre(), maria.getEdad(), maria.Altura, maria.Peso);
            Console.WriteLine("El color de los ojos de Maria son {0}", maria.Ojos);
            Console.WriteLine("El D.N.I. de Juan es: {0}", juan.Dni);
            Console.WriteLine("El nombre del profesor de la materia se llama {0} ", hugo.Nombre);
            Console.WriteLine("La altura del profesor es de {0} ", hugo.Altura);
            Console.ReadKey();
        }

        static void CambiarAlturaProfesor(Profesor profesor, double altura)
        {
            profesor.Altura = altura;
        }

    }
}






