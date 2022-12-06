using Assignment5Sorting;

namespace Assignment7Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vals = Utilities.ReadFromTextFile("../../../scores.txt");
            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms();
            sortingAlgorithms.QuickSort(vals, 0, vals.Length - 1);

            BinarySearchTree tree = new BinarySearchTree();
            foreach (int i in vals)
            {
                tree.Root = tree.Insert(tree.Root, i);
            }

            tree.PreOrderTraversal(tree.Root);

            Console.WriteLine("\n\n");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.BuildTreeFromArray(vals,0);

            binaryTree.PreorderPrint(binaryTree.Root);
            Console.ReadKey();
        }
    }
}