namespace HashTableAndBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            MyMapNode<string, string> para = new MyMapNode<string, string>(16);
            Console.WriteLine("Welcome To HASH TABLE and BINARY SEARCH TREE");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create BST \n2.Display \n3.Size \n4.Create Hash Table" +
                    "\n5.Hash Table for Paragragh \n6.Remove Hash value \n7.Exit");
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
                    case 5:
                        para.Add("0", "Paranoids");
                        para.Add("1", "are");
                        para.Add("2", "not");
                        para.Add("3", "paranoid");
                        para.Add("4", "because");
                        para.Add("5", "they");
                        para.Add("6", "are");
                        para.Add("7", "paranoid");
                        para.Add("8", "but");
                        para.Add("9", "because"); 
                        para.Add("10", "they");
                        para.Add("11", "keep");
                        para.Add("12", "putting");
                        para.Add("13", "themselves");
                        para.Add("14", "deliberately");
                        para.Add("15", "into");
                        para.Add("16", "paranoid");
                        para.Add("17", "avoidable");
                        para.Add("18", "situations");
                        string para0 = para.Get("0");
                        string para1 = para.Get("1");
                        string para2 = para.Get("2");
                        string para3 = para.Get("3");
                        string para4 = para.Get("4");
                        string para5 = para.Get("5");
                        string para6 = para.Get("6");
                        string para7 = para.Get("7");
                        string para8 = para.Get("8");
                        string para9 = para.Get("9");
                        string para10 = para.Get("10");
                        string para11 = para.Get("11");
                        string para12 = para.Get("12");
                        string para13 = para.Get("13");
                        string para14 = para.Get("14");
                        string para15 = para.Get("15");
                        string para16 = para.Get("16");
                        string para17 = para.Get("17");
                        string para18 = para.Get("18");
                        Console.WriteLine("0th index value: " + para0);
                        Console.WriteLine("1th index value: " + para1);
                        Console.WriteLine("2nd index value: " + para2);
                        Console.WriteLine("3rd index value: " + para3);
                        Console.WriteLine("4th index value: " + para4);
                        Console.WriteLine("5th index value: " + para5);
                        Console.WriteLine("6th index value: " + para6);
                        Console.WriteLine("7th index value: " + para7);
                        Console.WriteLine("8th index value: " + para8);
                        Console.WriteLine("9th index value: " + para9);
                        Console.WriteLine("10th index value: " + para10);
                        Console.WriteLine("11th index value: " + para11);
                        Console.WriteLine("12th index value: " + para12);
                        Console.WriteLine("13th index value: " + para13);
                        Console.WriteLine("14th index value: " + para14);
                        Console.WriteLine("15th index value: " + para15);
                        Console.WriteLine("16th index value: " + para16);
                        Console.WriteLine("17th index value: " + para17);
                        Console.WriteLine("18th index value: " + para18);
                        break;
                    case 6:
                        para.Remove("17", "avoidable");
                        Console.WriteLine("Value Deleted");
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}