using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class Bubble_Sort
    {
        //O(n^2)
        //element exchange method
        /*The Ref and out keywords in C# are used to pass arguments within a method or function.
        Both words indicate that the argument/parameter is passed by reference.
        By default, 
        parameters are passed to the method by value.
        Using these keywords (ref and out), 
        we can pass a parameter by reference.*/

        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //BubbleSort
        static public int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }
       
    }
}
