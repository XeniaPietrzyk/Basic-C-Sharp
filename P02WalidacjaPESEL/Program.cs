using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02WalidacjaPESEL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj PESEL");
            
            Numer n = new Numer();
            n.numer = Console.ReadLine();
            n.WalidacjaPESEL();

            Console.ReadKey();
        }
    }
}
