﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Define instructions
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen");

            Console.WriteLine("Syötä numero 1");
            string numero1 = Console.ReadLine();
            int numx = int.Parse(numero1);

            Console.WriteLine("Syötä numero 2");
            string numero2 = Console.ReadLine();
            int numy = int.Parse(numero2);

            Console.WriteLine("Syötä numero 3");
            string numero3 = Console.ReadLine();
            int numz = int.Parse(numero3);

            
            

            if (numx < numy)
            {
                if (numx < numz)
                 {
                    if (numy < numz)
                    {
                        Console.WriteLine($"{numx}, {numy}, {numz}");
                    }
                    else
                    {
                        Console.WriteLine($"{numx}, {numz}, {numy}");
                    }
                 }
                else 
                {            
                  Console.WriteLine($"{numz}, {numx}, {numy}");
                }
            }

            else
            {
                if (numx < numz)
                {
                    Console.WriteLine($"{numy}, {numx}, {numz}");
                }
                else
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"{numy}, {numz}, {numx}");
                    }
                    else
                    {
                        Console.WriteLine($"{numz}, {numy}, {numx}");
                    }
                }
            }

    
             Console.ReadKey();
     }
   }
}













