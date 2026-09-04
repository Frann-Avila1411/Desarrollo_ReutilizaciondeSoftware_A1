using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_Polimorfismo
{
    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato dice miau");
        }
    }
}
