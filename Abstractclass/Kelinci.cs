using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Abstractclass
{
    public class Kelinci : Binatang
    {
        public override void Memakan()
        {
            Console.WriteLine("Kelinci memakan tumbuhan");
            Console.WriteLine("Pemakan tumbuhan disebut binatang Herbivora");
        }
    }
}
