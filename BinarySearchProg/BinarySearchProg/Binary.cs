using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchProg
{
    public class Binary<B> where B : IComparable<B>
    {
        public B NodeData { get; set; }
        public Binary<B> LeftTree { get; set; }
        public Binary<B> RightTree { get; set; }
        public Binary(B nodedata)
        {
            this.NodeData = nodedata;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(B Item)
        {
            B currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(Item) > 0)
            {
                if(this.LeftTree == null)
                    this.LeftTree = new Binary<B>(Item);
                else
                    this.LeftTree.Insert(Item);
            }
            else
            {
                if(this.RightTree == null)
                    this.LeftTree= new Binary<B>(Item);
                else
                    this.RightTree.Insert(Item);
            }
        }

        public void Display()
        {
            if(this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if(this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(B element, Binary<B> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }
    }
}
