using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrimeNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            long startValue = 0, endValue = 0;
            if (args.Length == 2) {
                Console.WriteLine("StartValue is " + args[0]);
                Console.WriteLine("EndValue is " + args[1]);

                startValue = long.Parse(args[0]);
                endValue = long.Parse(args[1]);

            } 
            else return;
            PrimeNumbersWorker primeNumbersWorker = new PrimeNumbersWorker();


            DateTime StartTime = DateTime.Now;
            TimeSpan TSpan;
            Console.WriteLine();
            Console.WriteLine();
            List<long> PrimeNumbersList = new List<long>();

            PrimeNumbersList = primeNumbersWorker.GetPrimeNumbersSieveOfEratosthenes(startValue, endValue);
            TSpan = DateTime.Now - StartTime;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Решето Эратосфена");
            Console.WriteLine(Math.Round(TSpan.TotalMilliseconds) + "мс ушло на поиск простых чисел");
            Console.WriteLine("Найдено простых чисел - " + PrimeNumbersList.Count);
            Console.WriteLine("Последнее из найденых простых чисед - " + PrimeNumbersList[PrimeNumbersList.Count - 1]);
            Console.WriteLine();
            Console.WriteLine();

            StartTime = DateTime.Now;
            PrimeNumbersList = primeNumbersWorker.GetPrimeNumbersSieveOfEratosthenes1(startValue, endValue);
            TSpan = DateTime.Now - StartTime;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Решето Эратосфена 1");
            Console.WriteLine(Math.Round(TSpan.TotalMilliseconds) + "мс ушло на поиск простых чисел");
            Console.WriteLine("Найдено простых чисел - " + PrimeNumbersList.Count);
            Console.WriteLine("Последнее из найденых простых чисед - " + PrimeNumbersList[PrimeNumbersList.Count - 1]);
            Console.WriteLine();
            Console.WriteLine();






            StartTime = DateTime.Now;
            PrimeNumbersList = new List<long>();
            PrimeNumbersList = primeNumbersWorker.GetPrimeNumbersList(startValue, endValue);
            TSpan = DateTime.Now - StartTime;
            Console.WriteLine("Однопоточный бруттофорс");
            Console.WriteLine(Math.Round(TSpan.TotalMilliseconds) + "мс ушло на поиск простых чисел");
            Console.WriteLine("Найдено простых чисел - " + PrimeNumbersList.Count);
            Console.WriteLine("Последнее из найденых простых чисед - " + PrimeNumbersList[PrimeNumbersList.Count - 1]);
            Console.WriteLine();
            Console.WriteLine();


            StartTime = DateTime.Now;
            PrimeNumbersList = primeNumbersWorker.GetPrimeNumbersListMulti(startValue, endValue);
            TSpan = DateTime.Now - StartTime;
            Console.WriteLine("Многопоточный бруттофорс");
            Console.WriteLine(Math.Round(TSpan.TotalMilliseconds) + "мс ушло на поиск простых чисел");
            Console.WriteLine("Найдено простых чисел - " + PrimeNumbersList.Count);
            Console.WriteLine("Последнее из найденых простых чисед - " + PrimeNumbersList[PrimeNumbersList.Count - 1]);
            Console.ReadKey();
            foreach (var i in PrimeNumbersList) {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
