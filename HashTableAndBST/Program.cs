namespace HashTableAndBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            Console.WriteLine("Welcome To HASH TABLE and BINARY SEARCH TREE");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create BST \n2.Display \n3.Size \n4.Create Hash Table \n5.Exit");
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
                    case 4:
                        hash.Add("0", "To");
                        hash.Add("1", "be");
                        hash.Add("2", "or");
                        hash.Add("3", "not");
                        hash.Add("4", "to");
                        hash.Add("5", "be");
                        string hash0 = hash.Get("0");
                        string hash1 = hash.Get("1");
                        string hash2 = hash.Get("2");
                        string hash3 = hash.Get("3");
                        string hash4 = hash.Get("4");
                        string hash5 = hash.Get("5");
                        Console.WriteLine("0th index value: " + hash0);
                        Console.WriteLine("1th index value: " + hash1);
                        Console.WriteLine("2nd index value: " + hash2);
                        Console.WriteLine("3rd index value: " + hash3);
                        Console.WriteLine("4th index value: " + hash4);
                        Console.WriteLine("5th index value: " + hash5);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}