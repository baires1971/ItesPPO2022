using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    interface IAdministrativo //interface que define el metodo usarexcel que debe obligatoriamente ser implementado por la clase
    {                         //que utilice esta interface, siempre es publico
        void UsarExcel();
        
    }

    interface IDocente 
    {
        void UsarPedagogia();
      
    }
    internal class Directivo:Persona, IAdministrativo, IDocente  //siempre que una clase herede, primero se ponde la clase y despues recien las interfaces
    {
        public Directivo(string nombre, int _dni, double _altura, double _peso, DateTime nacimiento) : base(nombre, _dni, _altura, _peso, nacimiento) 
        {
        
        }
    
        public void UsarExcel() { Console.WriteLine("Utilizo planillas de calculo");}
        public void UsarPedagogia() { Console.WriteLine("Utilizo pedagogia"); }
        
    }
}
