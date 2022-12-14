using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    internal class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node node = new Node(id);
            if (root == null)
                root = node;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftCount;
                        if (current == null)
                        {
                            parent.leftCount = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightCount;
                        if (current == null)
                        {
                            parent.rightCount = node;
                            return;
                        }
                    }
                }
            }
        }

        public void Display(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.item + " | ");
                Display(root.leftCount);
                Display(root.rightCount);
            }
        }
    }
}