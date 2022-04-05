using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* cuando una clase hereda de varias interfaces, pude ocurrir que dos o mas posean un metodo que tenga el mismo nombre, numero de parametros
             * y devuelva el mismo tipo de valor. En ese caso se produce una ambiguedad, cuando implementamos el metodo a que interface corresponde?
             * el compilador no arroja error, debemos implementar dos metodos uno para cada interface, pero de manera privada, lo cual no podemos
             * acceder a estos metodos desde fuera de la clase. para solucionar este problema tenemos que utilizar el principio de sustitucion.
              
           */

            Directivo Miguel = new Directivo("Miguel", 23456921, 1.73d, 78d, DateTime.Parse("12/07/2000"));
            Miguel.UsarPedagogia();  //metodo heredado de la interface IDocente
            Miguel.UsarExcel();      //metodo heredado de la interface IAdministrativo  
            //Miguel.UsarLogica();  //esta llamada esta mal, porque no se sabe a cual interface se hace referencia
            //debemos utilizar el principio de sustitucion
            IAdministrativo administrativo = Miguel;
            administrativo.UsarLogica(); //el metodo usarlogica() pertenece a la interface IAdministrativo
            IDocente docente = Miguel;
            docente.UsarLogica();  // el metodo usarlogica() pertenece a la interface IDocente

            Console.WriteLine(Miguel.Edad); //propiedad heredada de la clase persona
        }
    }
}












