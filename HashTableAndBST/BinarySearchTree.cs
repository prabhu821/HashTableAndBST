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

        //CREATE AND INSERT 
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

        //DISPLAY
        public void Display(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.item + " | ");
                Display(root.leftCount);
                Display(root.rightCount);
            }
        }

        //SIZE
        public int size()
        {
            return size(root);
        }
        public int size(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return (size(node.leftCount) + 1 + size(node.rightCount));
            }
        }
    }
}