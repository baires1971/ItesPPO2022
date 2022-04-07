using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    
    class Program
    {
        delegate void FuncionDelegado();
        delegate void FuncionDelegado2(int dato);
        static void Main(string[] args)
        {
            /* Los delegados son referencias a metodos, es decir funciones que delegan su funcionalidad a otro metodo
             * sirven para llamar a eventos en interfaces graficas, pueden llamar a distintos metodos ubicados en distintas clases
           */

            //instanciamos el objeto delegado apuntando el metodo estatico de la clase tenista
            FuncionDelegado delegado = new FuncionDelegado(Tenista.Jugar);
            //utilizamos el delegado
            delegado();
            //creamos un objeto alumno
            Alumno alumno = new Alumno();
            //apuntamos el delegado ya creado al metodo leer() del objeto alumno
            delegado = alumno.leer;
            delegado();
            FuncionDelegado2 delegado2 = new FuncionDelegado2(alumno.cuadrado);
            delegado2(3);

        }
    }

    public class Alumno 
    {
        public void leer() { Console.WriteLine("Estoy Estudiando Programacion"); }
        public void cuadrado(int numero) 
        {
            long resultado = numero * numero;
            Console.WriteLine("El cuadrado del numero {0} es {1}", numero, resultado);
        }
    
    }

    public class Tenista 
    {
        public static void Jugar() { Console.WriteLine("Estoy Jugando al Tenis"); }
    }
        
}














