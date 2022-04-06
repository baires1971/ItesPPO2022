using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Persona   //declaro esta clase como abstracta
    {

        //---------------CONSTANTES----------------

        private const int ANIO = 365;

        //------------PROPIEDADES-------------------

        private int dni;
        private double altura;
        private double peso;
        public string Nombre { get; set; }
        public int Dni { get { return this.Dni; } set { this.Dni = validarDni(value); } }

        public double Altura { get { return this.Altura; } set { this.Altura = validarAltura(value);} }

        public double Peso { get { return this.Peso; } set { this.Peso = validarPeso(value); } }

        public int Edad { get { return this.getEdad(); } }

        public DateTime Nacimiento { get; set; }

        private DateTime nacimiento;
        //----------------CONSTRUCTOR DE CLASE---------------------------------

        public Persona(string nombre, int _dni, double _altura, double _peso, DateTime nacimiento)
        {
            this.Nombre = nombre;
            this.dni = _dni;
            this.altura = _altura;
            this.peso = _peso;
            this.Nacimiento = nacimiento;
            
        }

        //-------------METODOS----------------------
        private double validarAltura(double altura)
        {
            if (altura < 0) return 0;
            else return altura;
        }

        private int validarDni(int dni )
        {
            if (dni < 5000000) return 0;
            else return dni;
        }

        private double validarPeso(double peso) 
        {
            if (peso < 0) return 0;
            else return peso;
        }

        private int getEdad() 
        {
            TimeSpan resultado;
            resultado = (TimeSpan)(DateTime.Now - this.Nacimiento);
            return (resultado.Days / ANIO);  
            
        }

        //el metodo Firmar() esta declarado como abstracto, debe ser implementado por las clases que hereden de persona
        
        public abstract void Firmar();

        
    }
}
