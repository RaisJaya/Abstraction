using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.Abstractclass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pengaksesan yang menggunakan Abstract Class

            /*Binatang binatang;

            binatang = new Singa();
            binatang.Memakan();
                 Console.WriteLine();
                 Console.WriteLine("----------------------------------------------");
                 Console.WriteLine();
            binatang = new Kelinci();
            binatang.Memakan();
                 Console.WriteLine();
                 Console.WriteLine("----------------------------------------------");
                 Console.WriteLine();
            binatang = new Bunglon();
            binatang.Memakan();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();*/

            //Pengaksesan yang menggunakan Interface

            IBinatang binatang;

            binatang = new Singa();
            binatang.Memakan();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();
            binatang = new Kelinci();
            binatang.Memakan();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();
            binatang = new Bunglon();
            binatang.Memakan();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();

            Console.ReadKey();
        }
    }
}
