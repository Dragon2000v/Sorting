using System;

namespace Sorting_Algorithms
{
    class Program
    {     

         static void Main(string[] args)
         {
            Console.WriteLine("1 BubbleSort\n2 QuickSort\n3 TreeSort");
            Console.Write("Enter choice: ");
            var choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("BubbleSort");
                Console.Write("Enter array elements: ");
                var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
                var array = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    array[i] = Convert.ToInt32(parts[i]);
                }

                Console.WriteLine("Sorted array: {0}", string.Join(", ", Bubble_Sort.BubbleSort(array)));
            }
            else if (choice == 2)
            {
                Console.Write("Amount of elements = ");
                var len = Convert.ToInt32(Console.ReadLine());
                var a = new int[len];
                for (var i = 0; i < a.Length; ++i)
                {
                    Console.Write("a[{0}] = ", i);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ",Quick_Sort.QuickSort(a)));
            }
            else if(choice == 3)
            {
                Console.Write("Amount of element = ");
                var n = int.Parse(Console.ReadLine());

                var a = new int[n];
                var random = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(0, 100);
                }

                Console.WriteLine("Random Array: {0}", string.Join(" ", a));

                Console.WriteLine("Sorted Array: {0}", string.Join(" ",Tree_Sort.TreeSort(a)));
            }
             
         }       
    }
}
