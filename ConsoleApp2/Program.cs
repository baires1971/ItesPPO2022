using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /* Las Colecciones que pertenecen al namespace System.Collection.Generic, sirven para almacenar objetos
             * son clases genericas, permiten ordenar, añadir, eliminar, buscar, etc.
             * 
           */
            // creamos una lista de enteros
            List<int> listado = new List<int>();
            listado.Add(1);  //agregamos el numero 1 en la primera posicion de la lista
            listado.Add(2);
            listado.Add(3);
            for (int i = 0; i < listado.Count; i++) Console.WriteLine(listado[i]); 

            Console.WriteLine("======================================================================");

            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(1);
            lista.AddLast(3);  //agregamos el numero 3 en la ultima posicion de la linkedlist
            lista.AddLast(4);
            lista.AddLast(5);
            lista.AddFirst(9);
            LinkedListNode<int> unNodo = new LinkedListNode<int>(14); //creamos un nodo con el valor 14
            lista.AddFirst(unNodo);  //agregamos el nodo creado en la primera posicion de la linkedlist
            foreach (int i in lista) { Console.WriteLine(i); }
            Console.ReadKey();
            Console.WriteLine("======================================================================");
            lista.Remove(5); //removemos el numero 5 de la linkedlist
            for (LinkedListNode<int> nodo = lista.First; nodo != null; nodo = nodo.Next) 
            {
                int elemento = nodo.Value;
                Console.WriteLine(elemento);
            }
            Console.WriteLine("======================================================================");
            Queue<int> cola = new Queue<int>();
            cola.Enqueue(5); //agregamos el numero 5 al final de la cola
            cola.Enqueue(9);
            cola.Enqueue(7);
            foreach (int i in cola) { Console.WriteLine(i); }



        }
    }
        
}














