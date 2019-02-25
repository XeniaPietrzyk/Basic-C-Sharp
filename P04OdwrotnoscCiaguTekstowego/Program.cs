using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04OdwrotnoscCiaguTekstowego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź tekst:");
            string tekst = Console.ReadLine();
            int dlugoscTekstu = tekst.Length;

            for (int i = 0; i <= dlugoscTekstu; i++)
            {
                Console.Write(tekst[i]);
            }
            
            Console.ReadKey();
        }
    }
}
