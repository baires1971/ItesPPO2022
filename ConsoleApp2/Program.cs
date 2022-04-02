using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Si tenemos un metodo en la clase padre y en la clase hijo escribimos un metodo con el mismo nombre y parametros, entonces el compilador
             * oculta el medoto de la clase padre y nos da una advertencia que debemos agregar al metodo la palabra new y el compilador toma estos metodos
             * como dos metodos totalmente diferentes. Si queremos que un metodo de nuestra clase sea implementado de forma diferente por las clases hijas
             * utilizamos el modificador virtual, entonces obligamos a las clases hijas de implementarlo de manera diferentes cada una. pero en la clase hija
             * para que el compilador interprete que el metodo es una modificacion del metodo padre y no un metodo diferente, hay que agregar el modificador override
             * Que un mismo metodo se comporte de manera diferente es un principio del poliformismo 
              
           */
            
            Profesor Juan = new Profesor("Juan", 27869324, 1.75d, 76d,DateTime.Parse("12/03/2000"));
            Alumno Maria = new Alumno("Maria", 30124665, 1.70d, 65d, DateTime.Parse("05/04/2000"));
            Profesor Jorge = Juan; //creamos dos referencias o punteros al mismo objeto
            Persona[] personas = new Persona[3];
            personas[0] = Juan;  //el metodo firmar() implementado en juan es distinto al firmar() de persona, entonces como el arreglo es del tipo persona
                                 //solo son accesibles las propiedades y metodos de esta clase y vemos el metodo firmar de la clase persona
            personas[1] = Maria; //como en alumno sobreescribimos el metodo firmar, el compilador toma que modificamos el metodo de la clase persona y al acceder al nuevo
                                 //metodo se comporta de manera distinta
            personas[2] = Jorge;
            for(int i = 0; i < personas.Length; i++) { personas[i].Firmar(); }


        }
    }
}






