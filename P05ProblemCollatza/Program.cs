using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P05ProblemCollatza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę ciągu Collatza");
            ManagerCollatza mc = new ManagerCollatza();
            uint c = Convert.ToUInt32(Console.ReadLine());
            mc.c = c;
            mc.ObliczCiag();

            Console.ReadKey();
        }
    }
}
