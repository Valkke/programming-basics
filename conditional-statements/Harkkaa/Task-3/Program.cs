using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua");
            Random rnd = new Random();
            for (int laskuri = 0; laskuri < 4; laskuri++)
            {
                Console.WriteLine("Rivi {0}:{1}", laskuri + 1, luvutListaan(rnd));
            }
            
            
                Console.ReadLine();
                    }
                    
                        static string luvutListaan (Random XXX)
                    
            
            {
                int arpa = 0;
                string msg = "";
                for (int luku = 0; luku < 5; luku++)
                {
                    arpa = XXX.Next(51);
                    msg += string.Format("{0},", muotoileLuku(arpa));
                }
            return msg;
            }
                static string muotoileLuku(int x) 
                {
                  if (x < 10)
                return "0" + x.ToString();
                  else
                return x.ToString();

        
                       
        }
    }
}
