using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* cuando instanciamos objetos de una clase en particular, utilizamos la palabra new y el constructor de la clase
               para acceder a una propiedad debemos utilizar un metodo de acceso
            */
            Alumno juan;
            Alumno maria;
            juan = new Alumno();
            maria = new Alumno("Maria"); // podemos tener una sobrecarga de constructores de la clase Alumno
            juan.setNombre("Juan");
            maria.setNacimiento("4/4/2004");
            Console.WriteLine("la edad de {0} es: {1}", juan.getNombre(), juan.getEdad());
            Console.WriteLine("la edad de {0} es: {1}", maria.getNombre(), maria.getEdad());
            Console.ReadKey();
        }
    }

    class Alumno
    {
        string nombre;
        DateTime nacimiento;
        double altura;
        double peso;
        int dni;
        const int ANIO = 365; //declaramos con la palabra reservada "const" a la variable ANIO como una constante, 
                              // cuyo valor no podemos cambiar en toda la ejecucion del programa
        public Alumno()   //metodo especial denominado constructor de la clase, sirve para inicializar el estado interno del objeto
        {                 // este debe tener el mismo nombre que el de la clase y debe ser publico
            nombre = "";
            nacimiento = DateTime.Parse("06/02/2000");
            altura = 1.5;
            peso = 50;
            dni = 0;
        }

        public Alumno(string _nombre)
        {
            nombre = _nombre;
        }
        private int cantAnios(int dias)
        {
            return (dias / ANIO);
        }
        public int getEdad()
        {
            TimeSpan resultado;
            resultado = (TimeSpan)(DateTime.Now - nacimiento);
            return cantAnios(resultado.Days);
        }

        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNacimiento(string fecha)
        {
            this.nacimiento = DateTime.Parse(fecha);  // la palabra this es un alias para el nombre de la clase
        }

    }



}

