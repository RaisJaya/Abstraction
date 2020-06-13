using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Abstractclass
{
    public class Singa : Binatang
    {
        public override void Memakan()
        {
            Console.WriteLine("Singa memakan daging");
            Console.WriteLine("Pemakan daging disebut binatang Omnivora");
        }
    }
}
