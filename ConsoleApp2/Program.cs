using System;
using System.Collections.Generic;

namespace ConsoleApp2
{

    class Program
    {

        public delegate double Calcular(double numero);
        public delegate double Calcular2(double num1, double num2);
        static void Main(string[] args)
        {
            /* 
             * Las expresiones lambdas son funciones anonimas, para ejecutar tareas sencillas que no necesitan ser declaradas previamente
             * simplifica el codigo, se utilizan en delegados sencillos, metodos getter, setter, expresiones linq query, etc.
             * se codifican asi:   parametro => bloque sentencia
           */
            
            Alumno juan = new Alumno() { Edad = 21, Nombre = "Juan"};
            Alumno Maria = new Alumno() { Edad = 22, Nombre = "Maria" };
            Calcular operacion = new Calcular(Matematica.cuadrado);
            Console.WriteLine("El cuadrado de 2 es {0}", operacion(2));
            //ahora vamos a realizar los mismo pero sin apuntar al metodo cuadrado de la clase matematica
            Calcular operacion2 = new Calcular(num => num * num);
            Console.WriteLine(String.Empty);
            Console.WriteLine("El cuadrado de 2 es {0}", operacion(2));
            //ahora usamos una expresion lambda con dos parametros
            Calcular2 suma = new Calcular2((num1, num2) => num1 + num2);
            Console.WriteLine(String.Empty);
            Console.WriteLine("La suma de 4 y 8 es {0}", suma(4,8));

            //utilizamos expresiones lambda para filtrar valores de una lista y tambien para recorrerla
            List<int> lista = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            List<int> multiplosDeDos = lista.FindAll( num => num % 2 == 0);
            Console.WriteLine("Los numeros multiplos de dos son");
            multiplosDeDos.ForEach(num => Console.WriteLine(num)); 
            
            

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














