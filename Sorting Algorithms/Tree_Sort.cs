using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class Tree_Sort
    {
        /*Efficiency The procedure for adding an object to a binary tree has an 
         * average algorithmic complexity of the order of O(log(n)). Accordingly, 
         * for n objects, the complexity will be O(n log(n)), 
         * which classifies sorting using a binary tree as a "quick sort" group.*/
        public static int[] TreeSort(int[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }

            return treeNode.Transform();
        }
    }
}
