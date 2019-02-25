using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05ProblemCollatza
{
    class ManagerCollatza
    {
        public uint c;
        private List<uint> ciag = new List<uint>();
                     
        public void ObliczCiag()
        {
            ciag.Add(c);
            ElementyCiagu();
        }

        private void ElementyCiagu()
        {
            
            if (c == 1 || c == 0)
            {
                foreach (var item in ciag)
                {
                    Console.Write(item + ", ");
                }
                
            }
            else if (c%2==0)
            {
                ciag.Add(c / 2);
                KolejnyEtap();
            }
            else if (c%2!=0)
            {
                ciag.Add((c * 3) + 1);
                KolejnyEtap();
            }
            else
            {
                Console.WriteLine("Wprowadzono nieprawidłową liczbę");
            }
           
        }

        private void KolejnyEtap()
        {
            c = ciag[ciag.Count - 1];
            ElementyCiagu();
        }

        public void ObliczCiag(uint c)
        {
            for (uint i = c; i >=0; i = c)
            {
                if (i == 1 || i ==0)
                {
                    Console.WriteLine(c);
                    foreach (var item in ciag)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (i % 2 == 0)
                {
                    ciag.Add(i / 2);
                }
                else if (i%2!=0)
                {
                    ciag.Add((i * 3) + 1);
                }
                
            }
        }
    }
}
