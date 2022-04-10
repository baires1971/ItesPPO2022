using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    
    class Program
    {


        static void Main(string[] args)
        {
            /* 
             * Los delegados predicados son referencias a metodos y solo devuelven true o false. se usan para filtrar listas de valores
             * comprobando si una condicion es verdadera o falsa
           */
            List<double> listaNumeros = new List<double>();

            listaNumeros.AddRange(new double[] { 2, 6, 11, 17, 14, 21, 22, 25, 27, 32, 34, 42, 45, 49, 50, 52, 54, 60, 61, 66 });

            //Declaramos un predicado y lo apuntamos al metodo esmultiplo3 de la clase matematica
            Predicate<double> predicado = new Predicate<double>(Matematica.EsMultiplo3);
            //El metodo FindAll() de la clase lista toma como parametro un predicado y devuelve todos los elementos que cumplen 
            //con el predicado es decir que sean verdaderas
            List<double> listado = listaNumeros.FindAll(predicado);
            Console.WriteLine("Listado de numeros multiplos de 3");
            Console.WriteLine("=================================");
            foreach (double numero in listado)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("");

            List<Alumno> listadoAlumnos = new List<Alumno>();
            listadoAlumnos.Add(new Alumno() { Edad = 20, Nombre = "Juan" });
            listadoAlumnos.Add(new Alumno() { Edad = 32, Nombre = "Maria" });
            listadoAlumnos.Add(new Alumno() { Edad = 33, Nombre = "Jose" });
            listadoAlumnos.Add(new Alumno() { Edad = 21, Nombre = "Juana" });
            listadoAlumnos.Add(new Alumno() { Edad = 25, Nombre = "Marcos" });
            listadoAlumnos.Add(new Alumno() { Edad = 20, Nombre = "Laura" });

            Predicate<Alumno> predicado2 = new Predicate<Alumno>(Matematica.MayorA30);
            List<Alumno> listado2 = listadoAlumnos.FindAll(predicado2);
            Console.WriteLine("Listado de alumnos mayores de 30 años");
            Console.WriteLine("=================================");
            foreach (var alumno in listado2)
            {
                Console.WriteLine("El alumno {0} tiene {1} años",alumno.Nombre,alumno.Edad);
            }
            Console.WriteLine("");
        }
    }

    public class Matematica 
    {
        public static bool EsMultiplo3(double numero)
        {
            if (numero % 3 == 0) return true;
            else return false;
        }
        public static double cuadrado(double numero) { return numero * numero; }

        public static bool MayorA30(Alumno alumno) 
        {
            if (alumno.Edad > 30) return true;
            else return false;
        }
    }

    public class Alumno 
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
    }
}














