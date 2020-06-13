using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Kelinci : IBinatang
    {
        public void Memakan()
        {
            Console.WriteLine("Kelinci memakan tumbuhan");
            Console.WriteLine("Pemakan tumbuhan disebut binatang Herbivora");
        }
    }
}
