using System;

namespace MaxNumINArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2, 3, 4, 5};
            int maxNum = arr[0];
            Console.WriteLine(MaxNum());
            int MaxNum()
            {
              
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > maxNum)
                    {
                        maxNum = arr[i];
                    }

                }
                return maxNum;
           
               
            }
        }
    }
}
