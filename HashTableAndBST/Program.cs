namespace HashTableAndBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To BINARY SEARCH TREE");
            BinarySearchTree  binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display(binarySearchTree.ReturnRoot());
        }
    }
}