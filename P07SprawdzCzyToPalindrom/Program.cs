using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07SprawdzCzyToPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź tekst:");
            string tekst = Console.ReadLine();  
            
            int dlugoscTekstu = tekst.Length;            
            string palindrom = new string(tekst.Reverse().ToArray());
                                     
            int wynik = string.Compare(tekst,palindrom);
            if (wynik==0)
            {
                Console.WriteLine("Słowo jest palindromem");
            }
            else
            {
                Console.WriteLine("Słowo nie jest palindromem");
            }
            Console.ReadKey();
        }
    }
}
