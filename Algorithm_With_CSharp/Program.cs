using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;

namespace Algorithm_With_CSharp
{

    class Program
    {
        static bool isNumberInList(List<int> list, int length, int answer)
        {
            for (int i = 0; i < length; i++)
            {
                if (list[i] == answer)
                {
                    return true;
                }
            }
            return false;
        }

        static bool MyBinarySearch(List<int> list, int length, int answer)
        {
            int low = 0, high = length;
            int idx = 0;

            while(low <= high && idx == 0)
            {
                int mid = (low + high) / 2;
                
                if(list[mid] == answer)
                {
                    return true;
                }

                else if(answer < list[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            } 
            return false;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(7);
            list.Add(11);
            list.Add(5);
            list.Add(3);
            list.Add(8);

            Console.WriteLine(MyBinarySearch(list, list.Count, 5));
        }
    }
}
