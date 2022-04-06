using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Fichero
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;
        string ubicacion = @"C:\Users\Usuario\Documents\texto.txt";
        
        public Fichero() 
        {
            try
            {
                archivo = new StreamReader(ubicacion); //abrimos un flujo de datos desde el archivo en disco
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
                return;
            }
            
            while((linea = archivo.ReadLine()) != null) 
            {
               Console.WriteLine(linea);
               
            }
        
        }
        // la tilde se obtiene oprimiendo la tecla alt + 126
        ~Fichero() 
        {
          archivo.Close(); //cerramos el flujo de datos desde el archivo en disco
        }
    }
}
