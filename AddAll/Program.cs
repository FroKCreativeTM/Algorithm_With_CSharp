using System;

namespace AddAll
{
    class Program
    {
        static int summation(int n, in int[] arr)
        {
            int idx;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result = result + arr[i];
            }

            return result;
        }

        static void Main(string[] args)
        { 
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            Console.WriteLine(summation(arr.Length, arr));
        }
    }
}
