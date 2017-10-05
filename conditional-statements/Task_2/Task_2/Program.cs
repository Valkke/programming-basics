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
            string FirstName = "Uusi";
            string LastName = "Asiakas";
            Console.WriteLine(" " + FirstName + " "+ LastName);
            Console.WriteLine("Kirjoita Nimesi");
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();

            int number;
            Console.WriteLine("Kirjoita ikäsi");
            number = int.Parse (Console.ReadLine());
            if (number < 7)
                Console.WriteLine("Lippusi on ilmainen");
            else
            if (number > 65)
                    Console.WriteLine("Saat 50% alennuksen eli lippusi maksaa 8 euroa");
            
            else
            if (number > 6 && number < 16)
                Console.WriteLine("Saat 50% alennuksen eli lippusi maksaa 8 euroa");

            string jasenyys = "Oletko MTK:n jasen"





            Console.ReadLine();


           



        }
    }
}
