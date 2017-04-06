using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] ar;
            List<long> PrimeNumbersList = new List<long>();
            PrimeNumbers S = new PrimeNumbers();
            DateTime Start, Fin;
            
            TimeSpan TSpan;

            string inputString = null;
            //bool result = false;

            while (inputString != "x")
            {
                Start = DateTime.Now;
                PrimeNumbersList.Clear();
     

                ar = S.GetPrimeNumbersN(1999998, 2000000);
                foreach (long a in ar)
                {
                    if (S.ChekPrimeNumber(a)) PrimeNumbersList.Add(a);
                }
        
                Fin = DateTime.Now;
                TSpan = DateTime.Now - Start;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(Math.Round(TSpan.TotalMilliseconds) + " мс");
                inputString = Console.ReadLine();
            }
        }
    }
}
