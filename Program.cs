using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double cislo1;
            double cislo2;
            double result1;
            string znamenko;
            Console.WriteLine("Zadej znaménko");
            znamenko = Console.ReadLine();
            if(znamenko == "+") 
            {
                Console.WriteLine("Zadej prvni cislo");
                cislo1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadej druhe cislo");
                cislo2 = int.Parse(Console.ReadLine());
                result1 = cislo1 + cislo2;
                Console.WriteLine("Vysledek je " + result1);
            }
            if(znamenko == "-")
            {
                Console.WriteLine("Zadej prvni cislo");
                cislo1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadej druhe cislo");
                cislo2 = int.Parse(Console.ReadLine());
                result1 = cislo1 - cislo2;
                Console.WriteLine("Vysledek je " + result1);
            }
            if (znamenko == "*")
            {
                Console.WriteLine("Zadej prvni cislo");
                cislo1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadej druhe cislo");
                cislo2 = int.Parse(Console.ReadLine());
                result1 = cislo1 * cislo2;
                Console.WriteLine("Vysledek je " + result1);
            }
            if (znamenko == "/")
            {
                Console.WriteLine("Zadej prvni cislo");
                cislo1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadej druhe cislo");
                cislo2 = int.Parse(Console.ReadLine());
                result1 = cislo1 / cislo2;
                Console.WriteLine("Vysledek je " + result1);
            }
            
            Console.ReadKey();
        }
    }
}
