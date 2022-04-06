using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cuando trabajamos con estructuras, estas se almacenan en la pila o stack, como si fuera una variable primitiva o por valor
             * en cambio las clases se almacenan en el heap y se accede a ellas mediante referencias. las estructuras no tienen constructores
             *por defecto, el compilador no inicializa las propiedades hay que crear un constructor especifico. 
             *las estructuras no heredan de otras clases, pero si pueden implementar interfaces, son selladas (sealed). se utilizan cuando
             *hay que trabajar con grandes cantidades de datos en memoria, con distintos tipos primitivos, en virtud que son mas rapidos
             *que las clases
           */
            Auxiliar auxiliar = new Auxiliar();
            Auxiliar1 auxiliar1 = new Auxiliar1();
            auxiliar.SetHoras(24);
            auxiliar.SetDias(8);
            auxiliar1.SetHoras(24);
            auxiliar1.SetDias(8);
            Console.WriteLine("El auxiliar trabajo {0} horas durante {1} dias", auxiliar.GetHoras(), auxiliar.GetDias());
            Console.WriteLine("El auxiliar1 trabajo {0} horas durante {1} dias", auxiliar1.GetHoras(), auxiliar1.GetDias());
            Console.WriteLine("================================================================");
            auxiliar.IncrementarHoras(auxiliar, 100);
            auxiliar1.IncrementarHoras(auxiliar1 , 100);
            Console.WriteLine("Las horas modificadas en el objeto de la clase Auxiliar es {0}", auxiliar.GetHoras());
            Console.WriteLine("Las horas modificadas en la estructura del tipo Auxiliar1 es {0}", auxiliar1.GetHoras());

        }
    }
}

public class Auxiliar 
{
    private int horasTrabajadas;
    private int diasTrabajados;
    public Auxiliar() { }
    public void SetHoras (int horas) =>  this.horasTrabajadas = horas;
    public int GetHoras () => this.horasTrabajadas;
    public void SetDias (int dias) => this.diasTrabajados = dias;
    public int GetDias () => this.diasTrabajados;

    public void IncrementarHoras(Auxiliar auxiliar, int _horas )
    {
        auxiliar.SetHoras( horasTrabajadas + _horas );
    }

}

public struct Auxiliar1
{
    private int horasTrabajadas;
    private int diasTrabajados;
    public void Auxiliar() { }
    public void SetHoras(int horas) => this.horasTrabajadas = horas;
    public int GetHoras() => this.horasTrabajadas;
    public void SetDias(int dias) => this.diasTrabajados = dias;
    public int GetDias() => this.diasTrabajados;

    public void IncrementarHoras(Auxiliar1 auxiliar1, int _horas)
    {
        auxiliar1.SetHoras(horasTrabajadas + _horas);
    }
}










