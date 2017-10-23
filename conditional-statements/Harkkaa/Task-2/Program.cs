using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1 - 9");
            
            for (int i = 1; i <= 9; i++) {
                for (int b = 1; b <= 9; b++)
                {
                    int tulos;
                    tulos = i * b;
                    Console.WriteLine($"{i} x {b} = {tulos}");
                                    }
            }
            Console.ReadKey();
        }
    }
}
