using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* podemos escribir un metodo de una clase con el modificador public, private y protected
             * protected hace que el metodo solo sea accesible por la clase donde lo declaramos y por las clases hijas de esta. no pudiendose
             * llamar desde otras clases, esta en una posicion intermedia entre private y public
              
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
            personas[1].Caminar; //si intentamos acceder al metodo caminar() de la clase persona no podemos porque es del tipo protected


        }
    }
}






