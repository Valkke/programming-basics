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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Maatalousnayttelyn lipunhinta");
            int price = 16;
            float discount = 0.0f;



            int number;
            Console.Write("Ikä: ");
            Console.WriteLine("Kirjoita ikasi");
            number = int.Parse (Console.ReadLine());
            if (number < 7)
                Console.WriteLine("Lippusi on ilmainen");
            else
            if (number > 65)
                    Console.WriteLine("Saat 50% alennuksen eli lippusi maksaa 8 euroa");
            
            else
            if (number > 6 && number < 16)
                Console.WriteLine("Saat 50% alennuksen eli lippusi maksaa 8 euroa");

            if (number > 15 && number < 65)
            {

            Console.Write("Oletko varusmies? {Y/N}");
            if (Console.ReadLine ().ToUpper () == "Y")
                Console.Write($"Lippu maksaa {price * 0.50}euroa ");
            else 
            {
                Console.Write("Oletko MTK:n jasen? {Y/N}");
                if (Console.ReadLine().ToUpper() =="Y")
                discount = 0.15f;

                Console.Write("Oletko opiskelija?{Y/N}");
                if (Console.ReadLine().ToUpper() =="Y")
                {
                    discount = discount + 0.45f;
                }
                Console.WriteLine($"Lippusi hinta on {price - price * discount}euroa");
            }
        }
        Console.ReadKey();
   }
}
}




















