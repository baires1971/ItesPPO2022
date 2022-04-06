using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    interface IAdministrativo //interface que define el metodo usarexcel que debe obligatoriamente ser implementado por la clase
    {                         //que utilice esta interface
        void UsarExcel();
        void UsarLogica();
    }

    interface IDocente
    {
        void UsarPedagogia();
        void UsarLogica();
    }
    internal class Directivo : Persona, IAdministrativo, IDocente  //siempre que una clase herede, primero se ponde la clase y despues recien las interfaces
    {
        public Directivo(string nombre, int _dni, double _altura, double _peso, DateTime nacimiento) : base(nombre, _dni, _altura, _peso, nacimiento)
        {

        }
        //Tenemos una ambiguedad en el metodo usarlogica(), a cual interface corresponde?, pues a ambas, y esto no puede ser
        //public void UsarLogica() { Console.WriteLine("Utilizo la logica"); }
        public void UsarExcel() { Console.WriteLine("Utilizo planillas de calculo"); }
        public void UsarPedagogia() { Console.WriteLine("Utilizo pedagogia"); }
        /*
         *Para solucionar la ambiguedad se escribe el nombre del metodo sin el modificador public y declarando a que interface corresponde
         *el problema es que al no ser public queda encapsulado como private por defecto y no se puede acceder desde fuera de la clase
         */
        void IAdministrativo.UsarLogica() { Console.WriteLine("Utilizo la logica"); }
        void IDocente.UsarLogica() { Console.WriteLine("Utilizo otro tipo de logica"); }
       
        //este metodo abstracto lo sobreescribimos para darle una implimentacion especifica para la clase profesor
        public override void Firmar() { Console.WriteLine("yo firmo como un directivo", this.Nombre); }

    }
}
