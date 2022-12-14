namespace HashTableAndBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            Console.WriteLine("Welcome To BINARY SEARCH TREE");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create BST \n2.Display \n3.Size \n4.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        binarySearchTree.Insert(56);
                        binarySearchTree.Insert(30);
                        binarySearchTree.Insert(70);
                        Console.WriteLine("Tree Created");
                        break;
                    case 2:
                        binarySearchTree.Display(binarySearchTree.ReturnRoot());
                        break;
                    case 3:
                        Console.WriteLine("The size of binary tree is : " + binarySearchTree.size());
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}