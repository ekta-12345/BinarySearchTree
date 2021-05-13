using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySTree<T> where T: IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySTree<T> LeftTree { get; set; }
        public BinarySTree<T> RightTree { get; set; }
        public BinarySTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool res = false;
        public void Insert(T val)
        {
            T currentNodeValue = this.NodeData;
            if((currentNodeValue.CompareTo(val)>0))
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySTree<T>(val);
                else
                    this.LeftTree.Insert(val);

            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySTree<T>(val);
                else
                    this.RightTree.Insert(val);

            }
        }
            
        public void Display()
        {
            if (this.LeftTree!=null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if(this.RightTree!=null)
            {
                this.rightCount++;
                this.RightTree.Display();

            }
        }
                   
    }
}
