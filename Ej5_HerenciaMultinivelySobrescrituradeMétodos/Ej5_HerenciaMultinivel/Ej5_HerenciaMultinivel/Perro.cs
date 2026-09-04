using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5_HerenciaMultinivel
{
    public class Perro : Mamifero
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro dice guau");
        }
    }
}
