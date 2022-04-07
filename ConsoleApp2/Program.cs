using System;



namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /* Clases genericas con restricciones sirven para manejar cualquier tipo de datos, pero restringiendo su uso para ciertas
             * clases u objetos que nosotros queramos, por ejemplo si queremos crear un deposito que almacene solamente objetos de 
             * clases que tengan relacion con una universidad, no debiendo almacenar clases que no tengan que ver con el ambito academico
             * para ello a las clases de la universidad implementamos una interface especifica que no posean las demas clases
             * 
             * 
             *  
             * 
           */
            Deposito<Alumno> deposito = new Deposito<Alumno>();
            Deposito<Profesor> deposito2 = new Deposito<Profesor>();
            deposito.SetDato(new Alumno(100));
            deposito2.SetDato(new Profesor(30));
            //si queremos crear un deposito de la clase veterinario que no implementa la interface IUniversidad el compilador no nos permite
            Deposito<Veterinario> deposito3 = new Deposito<Veterinario>();
        }
    }
        
}

interface IUniversidad
{
    int GetLegajo();
}












