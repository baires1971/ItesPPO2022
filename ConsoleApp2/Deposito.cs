using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Deposito<T>  //especificamos una clase generica con un generico, que es una letra por convencion es una T, que significa                  
    {                           // cualquier tipo de objeto
                                // 
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
