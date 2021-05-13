using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree Program");
            BinarySTree<int> binarySearch = new BinarySTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);

            binarySearch.GetSize();
            binarySearch.Display();
            bool result = binarySearch.Search(63, binarySearch);
            Console.WriteLine();
            Console.WriteLine("The element 63 exists in the BST: " + binarySearch.Search(63, binarySearch));
            Console.Read();

        }
    }
}
