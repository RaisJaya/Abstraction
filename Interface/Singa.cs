using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Singa : IBinatang
    {
        public void Memakan()
        {
            Console.WriteLine("Singa memakan daging");
            Console.WriteLine("Pemakan daging disebut binatang Omnivora");
        }
    }
}
