using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret");

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{i}\t{Math.Round(Math.Sqrt(i), 2):f2}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
