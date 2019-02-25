using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbę:");
            
            try
            {
                int liczba = Convert.ToInt32(Console.ReadLine());
                uint wynik = 1;
                uint i;

                if (liczba == 0)
                {
                    wynik = 1;
                    Console.WriteLine("{0}! = {1}", liczba, wynik);
                }
                else
                {
                    for (i = 2; i <= liczba; i++)
                    {
                        wynik *= i;
                    }
                    Console.WriteLine("{0}! = {1}", liczba, wynik);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Błędnie wprwadzono liczbę"); 
            }
                       
            Console.ReadKey();
        }
    }
}
