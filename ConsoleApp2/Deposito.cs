using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //declaramos una clase generica con restricciones , donde puede manejar cualquier objeto tipo T pero esta obligado a implementar 
    //la interface IUniversidad
    internal class Deposito<T> where T:IUniversidad                   
    {                           
                                 
        List<T> almacen;
        public Deposito()
        {
            almacen = new List<T>();

        }

        public void SetDato(T dato) { almacen.Add(dato); }
        public T GetDato(int indice)
        {
            if (indice < almacen.Count) return almacen[indice];
            else return almacen.First();
        }
        public int GetCount() => almacen.Count;
        
        public int GetLast() => almacen.Count - 1;
        public List<T> GetDatos() { return almacen; }
    }
}
