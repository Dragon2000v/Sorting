using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class Quick_Sort
    {
        /*  Worst time O(n^2)
            Best time O(n log n) (normal split)
            or O(n) (dividing into 3 parts)
            Average time O(n log n)
            Memory cost O(n) auxiliary
            O(log n) auxiliary*/
        //method for swapping array elements
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //method returning the index of the reference element
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //quick sort
        public static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
    }
}
