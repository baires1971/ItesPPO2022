using System;



namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /* Programacion Generica se caracteriza para la reutilizacion del codigo, creando clases genericas que pueda manejar cualquier
             * tipo de objetos
             * 
             *  
             * 
           */
            Deposito<int> deposito = new Deposito<int>();
            Deposito<Alumno> deposito2 = new Deposito<Alumno>();
            deposito.SetDato(4);
            deposito.SetDato(2);
            deposito.SetDato(10);
            deposito2.SetDato(new Alumno("Juan", 23));
            deposito2.SetDato(new Alumno("Maria", 18));
            Console.WriteLine("El deposito tiene en la ultima posicion el numero: {0}", deposito.GetLast());
            Console.WriteLine("El primer alumno se llama {0} y tiene {1} años", deposito2.GetDato(0).Nombre, deposito2.GetDato(0).Edad);
        }
    }
}













