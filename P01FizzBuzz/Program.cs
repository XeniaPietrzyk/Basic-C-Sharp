using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int zakres = 100;
            for (int i = 0; i <= zakres; i++)
            {
                
                if (i%3==0 & i%5==0 & i!=0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i%5==0 & i!=0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i%3==0 & i!=0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
