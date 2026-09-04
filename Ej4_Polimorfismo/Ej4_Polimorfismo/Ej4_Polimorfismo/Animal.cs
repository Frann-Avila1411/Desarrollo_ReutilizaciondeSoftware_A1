using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_Polimorfismo
{
    public class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
}
