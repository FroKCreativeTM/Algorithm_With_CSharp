using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static int fibWithRecur(int n)
        {
            if (n <= 1)
                return n;
            else
                return fibWithRecur(n - 1) + fibWithRecur(n - 2);
        }

        static int betterFibo(int n)
        {
            int[] list = new int[n + 1];

            list[0] = 0;

            if(n > 0)
            {
                list[1] = 1;

                for(int i = 2; i <= n; i++)
                {
                    list[i] = list[i - 1] + list[i - 2];
                }
            }

            return list[n];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(betterFibo(10));
        }
    }
}
