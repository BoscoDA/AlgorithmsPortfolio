using Assignment5Sorting;

namespace Assignment7Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] vals = new int[] {10,5,20,4,8,15,25 };
            Node root = null;
            foreach (int i in vals)
            {
                root = BinarySearchTree.Insert(root!, i);
            }

            BinarySearchTree.PreOrderTraversal(root!);
            Console.WriteLine("\nRemoved 4: ");
            BinarySearchTree.Remove(root, 4);
            BinarySearchTree.PreOrderTraversal(root!);
            Console.WriteLine("\nRemoved 8: ");
            BinarySearchTree.Remove(root!, 8);
            BinarySearchTree.PreOrderTraversal(root!);
            Console.WriteLine("\nRemoved 20: ");
            BinarySearchTree.Remove(root!, 20);
            BinarySearchTree.PreOrderTraversal(root!);

            Console.WriteLine("\n\nBinary Tree of the Scores from the sorting assignment output in preorder:\n");

            int[] vals2 = Utilities.ReadFromTextFile("../../../scores.txt");
            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms();
            sortingAlgorithms.QuickSort(vals2, 0, vals2.Length - 1);

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.BuildTreeFromArray(vals2,0);

            binaryTree.PreorderPrint(binaryTree.Root);
            Console.ReadKey();
        }
    }
}