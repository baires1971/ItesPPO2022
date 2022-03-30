using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cuando tenemos un codigo muy grande cuando lo guardamos para continuar otro dia podemos poner comentarios //TODO 
              en el lugar donde lo dejamos, o si en los lugares donde vamos a codificar nuevas funcionalidades
              las cuales las podemos ubicar cuando volvamos a abrir el archivo, mediante el menu:  Ver ->  Lista de Tareas
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
            juan.Password = "1234";
            juan.Dni = 30456789;
            Console.WriteLine("L edad de {0} es: {1} , la altura : {2} metros y el peso: {3} kilos", juan.getNombre(), juan.getEdad(), juan.Altura, juan.Peso);
            Console.WriteLine("La edad de {0} es: {1} , la altura : {2} metros y el peso: {3} kilos", maria.getNombre(), maria.getEdad(), maria.Altura, maria.Peso);
            Console.WriteLine("El color de los ojos de Maria son {0}", maria.Ojos);
            Console.WriteLine("El D.N.I. de Juan es: {0}", juan.Dni);
            Console.ReadKey();
        }
    }

    partial class Alumno
    {
        private string nombre;
        private DateTime nacimiento;
        private int dni;
        private double altura;
        private string password;
        const int ANIO = 365; //declaramos con la palabra reservada "const" a la variable ANIO como una constante, 
                              // cuyo valor no podemos cambiar en toda la ejecucion del programa

        public string Ojos //declaramos una propiedad automatica de solo lectura
        {
            get;
        }
        public string Password //propiedad de solo escritura
        {
            set { password = value; }
        }

        //TODO: TENGO QUE AGREGAR UN ATRIBUTO NUEVO
        public int Dni //creamos la propiedad Dni utilizando la anotacion lambda
        {
            get => this.dni;
            set => this.dni = value;
        }
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
            this.Altura = 1.5;
            this.Peso = 50;
            this.dni = 0;
            this.password = "ites2022";
            this.Ojos = "Azules";
        }

        public Alumno(string _nombre)
        {
            nombre = _nombre;
            nacimiento = DateTime.Parse("06/02/2000");
            this.Altura = 1.5;
            this.Peso = 50;
            this.dni = 0;
            this.password = "ites2022";
            this.Ojos = "marrones";
        }

    }
    partial class Alumno
    {
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
            //TODO: TENGO QUE AGREGAR UNA VARIABLE 
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

