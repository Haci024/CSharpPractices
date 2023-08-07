using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int[] arr= {1,2,3,4};
            Console.WriteLine(EnBuyuk(arr));    
        }
        public static int EnBuyuk(int[] dizi)
        {

            int maxEleman = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > maxEleman)
                {
                    maxEleman = dizi[i];
                }
            }
            return maxEleman;
        }

    }
}
