using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Abstractclass
{
    public class Bunglon : Binatang
    {
        public override void Memakan()
        {
            Console.WriteLine("Bunglon memakan serangga");
            Console.WriteLine("Pemakan serangga disebut binatang Insektivora");
        }
    }
}
