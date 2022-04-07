using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Profesor: IUniversidad
    {
        private int legajo;
        public Profesor(int legajo) { this.legajo = legajo; }
        public int GetLegajo() { return legajo; }

    }
}
