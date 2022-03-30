using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* las propiedades en C# permiten encapsular los valores de los atributos de un objeto, no pudiendo acceder directamente desde 
               otra clase pero permiten utilizar una sintaxis mas sencilla que los metodos getter y setter para modificar estos atributos
            */
            Alumno juan;
            Alumno maria;
            juan = new Alumno();
            maria = new Alumno("Maria"); // podemos tener una sobrecarga de constructores de la clase Alumno
            juan.setNombre("Juan");
            maria.setNacimiento("4/4/2004");
            juan.Altura = 1.80;   //accedemos a la propiedad altura
            maria.Altura = juan.Altura;
            juan.Peso = 90;
            maria.Peso = 70;
            maria.Peso += 5; //puedo sumar, incrementar una propiedad como si accedieramos directamente a la variable del atributo
            Console.WriteLine("L edad de {0} es: {1} , la altura : {2} metros y el peso: {3} kilos", juan.getNombre(), juan.getEdad(), juan.Altura, juan.Peso);
            Console.WriteLine("La edad de {0} es: {1} , la altura : {2} metros y el peso: {3} kilos", maria.getNombre(), maria.getEdad(), maria.Altura, maria.Peso);
            Console.ReadKey();
        }
    }

    class Alumno
    {
        private string nombre;
        private DateTime nacimiento;
        private int dni;
        private double altura;
        const int ANIO = 365; //declaramos con la palabra reservada "const" a la variable ANIO como una constante, 
                              // cuyo valor no podemos cambiar en toda la ejecucion del programa
        public double Altura //declaramos la propiedad ALTURA, con los metodos get y set para controlar el valor que ingresa
        {                    // y el valor que sale del atributo "altura" a los objetos fuera de la clase alumno
            get { return this.altura; }
            set { this.altura = validarAltura(value); } //la palabra reservada value se usa para designar el valor de cualquier tipo que
        }                                          //asignamos a la propiedad altura de la clase alumno
        public double Peso { get; set; } //propiedad automatica. el compilador crea una variable privada "peso" del tipo double y con get le asigna un valor y 
                                         // con el metodo set recupera su valor quedaria como:
                                         // { get{ return this.peso;} set{ this.peso = value;} }      
        public Alumno()   //metodo especial denominado constructor de la clase, sirve para inicializar el estado interno del objeto
        {                 // este debe tener el mismo nombre que el de la clase y debe ser publico
            nombre = "";
            nacimiento = DateTime.Parse("06/02/2000");
            //Altura = 1.5;
            //Peso = 50;
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

        public void setNombre(string _nombre) // metodo setter, se utiliza para asignar datos al objeto
        {
            nombre = _nombre;
        }

        public string getNombre() // metodo getter, se utiliza para obtener datos del objeto
        {
            return nombre;
        }

        public void setNacimiento(string fecha)
        {
            this.nacimiento = DateTime.Parse(fecha);  // la palabra this es un alias para el nombre de la clase
        }

        private double validarAltura(double _altura)
        {
            if (_altura < 0) return 0;
            else return _altura;
        }

    }



}

