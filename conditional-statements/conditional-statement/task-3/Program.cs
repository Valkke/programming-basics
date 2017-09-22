﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)

        { // Define instructions

            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");

            bool isNumber;

            do

            {

                Console.Write("Syötä luku: ");

                string userInput;

                userInput = Console.ReadLine();

                // define variables

                int evaluatedNumber;

                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // program logic


                if (evaluatedNumber % 2 == 0)

                {

                    Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");

                }

                else

                {

                    Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");

                }
                if (isNumber == true)

                {

                    if (evaluatedNumber < 0)

                    {

                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");

                    }

                    else if (evaluatedNumber > 0)

                    {

                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");

                    }

                    else

                    {

                        Console.WriteLine($"Numero {evaluatedNumber} on nolla");

                    }



                }

                else

                {

                    Console.WriteLine("Syötit muuta kuin numeroita!");

                }

            } while (isNumber == false);

            Console.ReadKey();
        }
    }
}







