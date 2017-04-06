using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar;
            PrimeNumbers S = new PrimeNumbers();
            ar = S.GetPrimeNumbers(2, 40);
            for(int i=0; i<ar.Length; i++)
            {
                Console.WriteLine(ar[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
