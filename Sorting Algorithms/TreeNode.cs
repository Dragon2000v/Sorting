using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class TreeNode
    {
        public TreeNode(int data)
        {
            Data = data;
        }

        //data
        public int Data { get; set; }

        //left branch of the tree
        public TreeNode Left { get; set; }

        //right branch of the tree
        public TreeNode Right { get; set; }

        //recursively adding a node to a tree
        public void Insert(TreeNode node)
        {
            if (node.Data < Data)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Insert(node);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Insert(node);
                }
            }
        }

        //converting tree to sorted array
        public int[] Transform(List<int> elements = null)
        {
            if (elements == null)
            {
                elements = new List<int>();
            }

            if (Left != null)
            {
                Left.Transform(elements);
            }

            elements.Add(Data);

            if (Right != null)
            {
                Right.Transform(elements);
            }

            return elements.ToArray();
        }
    }
}
