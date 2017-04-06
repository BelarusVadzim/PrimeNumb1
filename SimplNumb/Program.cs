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
            //ar = S.GetPrimeNumbers(2, 40);
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    Console.WriteLine(ar[i].ToString());
            //}
            string inputString = null;
            //bool result = false;

            while (inputString != "x")
            {
                Start = DateTime.Now;
                PrimeNumbersList.Clear();
                //    if (inputString == "x") break;
                //    result = S.ChekPrimeNumber(long.Parse(inputString));
                //    Console.WriteLine(result.ToString());
                //}

                ar = S.GetPrimeNumbersN(10, 200000);
                foreach (long a in ar)
                {
                    if (S.ChekPrimeNumber(a)) PrimeNumbersList.Add(a);
                   // if (S.ChekPrimeNumber(a)) Console.WriteLine(a.ToString());
                }
                //foreach (long a in PrimeNumbersList)
                //{
                //    Console.WriteLine(a.ToString());
                //}
                Fin = DateTime.Now;
                TSpan = DateTime.Now - Start;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(Math.Round(TSpan.TotalMilliseconds) + "мс");
                inputString = Console.ReadLine();
                //Console.ReadLine();
            }
        }
    }
}
