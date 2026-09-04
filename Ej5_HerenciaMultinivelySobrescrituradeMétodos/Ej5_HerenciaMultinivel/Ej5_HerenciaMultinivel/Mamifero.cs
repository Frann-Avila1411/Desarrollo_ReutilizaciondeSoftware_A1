using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5_HerenciaMultinivel
{
    public class Mamifero : Animal
    {
        public void Alimentar()
        {
            Console.WriteLine("El mamífero se alimenta.");
        }
    }
}
