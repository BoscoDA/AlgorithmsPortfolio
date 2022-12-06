using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Trees
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public Node? Root;

        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(int value)
        {
            Root = new Node(value);
        }

        public void BuildTreeFromArray(int[] arr, int i = 0)
        {
            Root = buildTreeFromArray(arr, i);
        }

        private Node buildTreeFromArray(int[] arr, int i = 0) 
        {
            Node? root = null;

            if (i < arr.Length)
            {
                root = new Node(arr[i]);
                root.Left = buildTreeFromArray(arr, 2 * i + 1);
                root.Right = buildTreeFromArray(arr, 2 * i + 2);
            }

            return root!;
        }

        public void PreorderPrint(Node? root)
        {
            if (root != null)

            {
                Console.Write(root.Value + " ");

                PreorderPrint(root.Left);

                PreorderPrint(root.Right);

            }
        }
    }

    public class BinarySearchTree
    {
        public Node? Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(int value)
        {
            Root = new Node(value);
        }

        public Node Insert(Node root, int value)
        {
            if (root == null)
            {
                return new Node(value);
            }
            Node? currentNode = root;
            if(value <= currentNode.Value)
            {
                currentNode.Left = Insert(currentNode.Left!, value);
            }
            else if(value >= currentNode.Value)
            {
                currentNode.Right = Insert(currentNode.Right!, value);
            }
            return root;
        }


        public void Remove()
        {

        }



        public void PreOrderTraversal(Node? root)
        {
            if (root != null)
            {
                Console.Write(root.Value + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }

        public void InOrderTraversal(Node? root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Value + " ");
                InOrderTraversal(root.Right);
            }
        }

        public void PostOrderTraversal(Node? root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.Write(root.Value + " ");
            }
        }

    }
}
