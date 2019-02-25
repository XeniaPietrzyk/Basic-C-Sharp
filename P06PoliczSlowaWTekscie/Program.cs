using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P06PoliczSlowaWTekscie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ścieżkę pliku tekstowego");

            try
            {
                string sciezka = Console.ReadLine();
                string tekst =  File.ReadAllText(sciezka);

                string[] tekstSlowa = tekst.Split(' ');
                                
                int licznikSlow = 0;
                for (int i = 0; i < tekstSlowa.Length; i++)
                {
                    licznikSlow++;
                }

                Console.WriteLine(licznikSlow);
            }
            catch (Exception)
            {
                Console.WriteLine("Nieprawidłowa ścieżka pliku");
            }

            Console.ReadKey();
                        
        }
    }
}
