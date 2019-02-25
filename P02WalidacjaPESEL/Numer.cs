using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02WalidacjaPESEL
{
    class Numer
    {
        public string numer;
        private int dlugoscNumeru;
        private double[] tabNumer;
        private double suma = 0;

        public Numer()
        {
            
        }

        public void WalidacjaPESEL()
        {
            dlugoscNumeru = numer.Length;

            if (dlugoscNumeru==11)
            {
                tabNumer = new double[dlugoscNumeru];

                for (int i = 0; i < dlugoscNumeru; i++)
                {
                    tabNumer = numer.Select(char.GetNumericValue).ToArray(); 
                }

                MnozeniePrzezWagi();
            }
            else
            {
                Console.WriteLine("Nieprawidłowa długość numeru");
            }
          
        }

        private void MnozeniePrzezWagi()
        {
            double[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            double[] iloczyn = new double[wagi.Length];
            

            for (int i = 0; i < wagi.Length; i++)
            {
                iloczyn[i] = (wagi[i]) * tabNumer[i];
                //Console.WriteLine(iloczyn[i]);
            }
            for (int i = 0; i < iloczyn.Length; i++)
            {
                suma += iloczyn[i];
                //Console.WriteLine(suma);
            }

            Sumowanie();
        }

        private void Sumowanie()
        {
            double wynik = suma / 10;

            if (suma % 10 == 0)
            {
                if (tabNumer[10] == 0)
                {
                    Console.WriteLine("Poprawny PESEL");
                    //SprawdzDate()
                }
                else
                {
                    Console.WriteLine("Niepoprawny PESEL");
                }
            }
            else
            {
                if (wynik - 10 == 0)
                {
                    Console.WriteLine("Poprawny PESEL");
                    //SprawdzDate()
                }
                else
                {
                    Console.WriteLine("Niepoprawny PESEL");
                }
            }
        }
        private void SprawdzDate()
        {

        }

        
        
    }
}
