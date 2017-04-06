using System;
using System.Collections;
using System.Text;

namespace PrimeNumb
{
    class PrimeNumbers
    {
        int[] ar = new int[1];
        //test
        public int[] GetPrimeNumbers(int DownNumber, int UpNumber)
        {
            int[] ar= new int[UpNumber-DownNumber];
            Loadm(DownNumber, UpNumber);
            return list(work(DownNumber, UpNumber), DownNumber);
        }

        private void Loadm(int DownNumber, int UpNumber)
        {
            ar = new int[UpNumber - DownNumber];
            for (int i = DownNumber; i < UpNumber; i++)
            {
                ar[i-DownNumber] = i;
            }
           
        }
        private int[] work(int DownNumber, int UpNumber)
        {
            ArrayList br = new ArrayList();
            br.Add(0);
            for (int i = 0; i < UpNumber-DownNumber; i++)
            {
                Console.WriteLine(i.ToString());
               int a = 1;
               while (ar[i] * (i + a) < UpNumber)
               {
                    bool m = true;
                    for (int r = 0; r < br.Count; r++)
                    {
                      if (ar[i] * (i + a) == (int)br[r])
                        
                    {
                      m = false;
                      r = br.Count;
                    }
                    }
                     if (m)
                    {
                        br.Add(ar[i] * (i + a));
                    }
                    a++;
                }

             }
            for (int i = 0; i < br.Count; i++)
            {
                for (int r = 0; r < UpNumber-DownNumber; r++)
                {
                    if (ar[r] == (int)br[i])
                    {
                        ar[r] = 0;
                        r = UpNumber;
                    }
                }

            }
           return ar;
        }
        private int[] list(int []tr, int DownNumber)
        {
            ArrayList br = new ArrayList();
            for (int i = 0; i < tr.Length; i++)
            {
                if (tr[i] != 0)
                {
                   br.Add(tr[i]);
                }
            }

            ar = new int[br.Count];
            for (int i = 0; i < ar.Length; i++ )
            {
                if ((int)br[i] > DownNumber)
                {
                    ar[i] = (int)br[i];
                }
            }
            return ar;
        }
    }
}
