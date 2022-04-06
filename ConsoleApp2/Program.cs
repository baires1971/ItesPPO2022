using System;



namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /* En .NET los objetos instanciados en memoria que ya no se utilizan son destruidos por el recolector de basura para liberar memoria
             * podemos decirle a nuestra clase que al momento que el objeto sea destruido o sacado de memoria se ejecute un codigo
             * especifico que nosotros queramos, como puede ser cerrar una conexion a una base de datos, cerrar un archivo en disco, conexion http, etc.
             * este metodo se llama destructor de la clase.
             *  
             * 
           */
            Fichero archivo = new Fichero();

        }
    }
}













