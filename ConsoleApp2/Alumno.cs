using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Alumno
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
