using System;
using System.Collections;
using System.Text;

namespace PrimeNumb
{
    class PrimeNumbers
    {
        public long[] GetPrimeNumbersN(long DownNumber, long UpNumber){
            long[] ar = new long[UpNumber - DownNumber];
            for (long i = 0; i < UpNumber - DownNumber; i++)
            {
                ar[i] = DownNumber + i;
            }
            return ar;
        }
        public bool ChekPrimeNumber(long N){
            long rest = -1;
            long i = 1;
            while (i < N/2)
            {
                i++;
                rest = N % i;
                if (rest == 0) return false;
                
            }
            return true;
        }
    }
}
