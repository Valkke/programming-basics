﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            Console.Write("Syötä luku ");
            string userInput;
            userInput = Console.ReadLine();

            int.evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            if (evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero (evalutedNumber) on negatiivinen");

            }
            else if (evaluatedNumber > 0)
                Console.WriteLine($"Numero (evalutedNumber) on positiivinen");
            else
            {
                Console.WriteLine($"Numero (evalutedNumber) on nolla");
            }
       

            Console.WriteLine("Syötit arvon {0}",userInput);
            Console.WriteLine($"Syötit arvon {userInput}");
            Console.ReadKey();

       }
    }
}
