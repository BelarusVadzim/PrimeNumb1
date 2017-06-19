﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumb
{
    class PrimeNumbersWorker
    {


        //private List<long> GetNumbers(long DownNumber, long UpNumber) {
        //    List<long> ar = new List<long>();
        //    for (long i = 0; i < UpNumber - DownNumber; i++) {
        //        ar.Add(DownNumber + i );
        //    }
        //    return ar;
        //}

        /// <summary>
        /// Метод получает массив натуральных чисел заданного диапаона
        /// </summary>
        /// <param name="DownNumber">Нижняя граница диапазона</param>
        /// <param name="UpNumber">Верхняя граница диапазона</param>
        /// <returns>Возвращает массив натуральных чисел</returns>
        private Queue<long> GetNumbers1(long DownNumber, long UpNumber) {
            Queue<long> ar = new Queue<long>();
            for (long i = 0; i < UpNumber - DownNumber; i++) {
                ar.Enqueue(DownNumber+i);
            }
            return ar;
        }

        /// <summary>
        /// Метод проверяет является ли число простым
        /// </summary>
        /// <param name="N">Число которое нужно проверить</param>
        /// <returns>Возвращает true если числоо простое</returns>
        private bool ChekPrimeNumber(long N){
            long rest = -1;
            long i = 1;
            while (i < N/2)
            {
                i ++;
                rest = N % i;
                if (rest == 0) return false;
            }
            return true;
        }

        private object threadLock = new object();

        /// <summary>
        /// Однопоточный метод находит все простые числа в заданном диапазоне
        /// </summary>
        /// <param name="DownNumber">Минимальное значение диапазона</param>
        /// <param name="UpNumber">Максимальное значение диапазона</param>
        /// <returns>Список простых чисел</returns>
        public List<long> GetPrimeNumbersList(long DownNumber, long UpNumber) {
            List<long> result = new List<long>();
            Queue<long> naturalNumbersLiat = GetNumbers1(DownNumber, UpNumber);
            Console.WriteLine("Количество чисел в диапазоне " + naturalNumbersLiat.Count);
            foreach (long a in naturalNumbersLiat) {
                if (ChekPrimeNumber(a))
                    result.Add(a);
            }

            return result;
        }



        /// <summary>
        /// Многопоточный метод находит все простые числа в заданном диапазоне
        /// </summary>
        /// <param name="DownNumber">Минимальное значение диапазона</param>
        /// <param name="UpNumber">Максимальное значение диапазона</param>
        /// <returns>Список простых чисел</returns>
        public List<long> GetPrimeNumbersListMulti(long DownNumber, long UpNumber) {
            List<long> result = new List<long>();
            Queue<long> naturalNumbersLiat = GetNumbers1(DownNumber, UpNumber);
            Console.WriteLine("Количество чисел в диапазоне " + naturalNumbersLiat.Count);
                Parallel.ForEach<long>(naturalNumbersLiat, a => {
                        if (ChekPrimeNumber(a))
                        lock (threadLock) {
                            result.Add(a);
                        }
                }
                );
            return result;
        }




    }
}
