using System;

namespace BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] arr, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    if(arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
