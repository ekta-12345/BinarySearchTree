using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Generic Binary search tree is defined
    public class BinarySTree<T> where T : IComparable<T>// Icomparable method is defined to use CompareTo inside the program
    {
        public T NodeData { get; set; }
        public BinarySTree<T> LeftTree { get; set; }
        public BinarySTree<T> RightTree { get; set; }

        
        /// constructor and pass parameter
       
        public BinarySTree(T nodeData)
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }

        int LeftCount = 0;
        int RightCount = 0;
        bool result = false;

        public void Insert(T item)//create method and pass parameter item
        {
            T currentNodeValue = NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (LeftTree == null)
                    LeftTree = new BinarySTree<T>(item);
                else
                    LeftTree.Insert(item);
            }
            else
            {
                if (RightTree == null)
                    RightTree = new BinarySTree<T>(item);
                else
                    RightTree.Insert(item);
            }
        }

       
        /// Get size of Binary Search Tree
        
        public void GetSize()
        {
            Console.WriteLine("\nSize " + (1 + LeftCount + RightCount));
        }
        public void Display()
        {
            if (LeftTree != null)
            {
                LeftCount++;
                LeftTree.Display();
            }
            Console.Write(NodeData.ToString() + "-->");
            if (RightTree != null)
            {
                RightCount++;
                RightTree.Display();
            }
        }
        //search method to search a node in the binary search tree
        public bool Search(T element, BinarySTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                result = true;
            }

            else if (node.NodeData.CompareTo(element) < 0)
            {
                Search(element, node.RightTree);
            }
            else
            {
                Search(element, node.LeftTree);
            }
            return result;
        }
    }
}