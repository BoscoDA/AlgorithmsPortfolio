using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    // Singly Linked List
    //Node        [N] > [A] > [B] > [C] > null
    //Data        [0]   [5]   [9]   [10]
    //Pointer/Ref [A]   [B]   [C]   [null]
    //

    public class LinkedList
    {
        LinkedListNode? head;
        int count = 0;

        public LinkedList()
        {
            head = null;
        }

        public void AddNodeToFront(object data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.Next = head;
            head = node;

            count++;
        }

        public void PrintList()
        {
            LinkedListNode? runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;
            }
        }
    }

    class LinkedListNode
    {
        public object Data;
        public LinkedListNode? Next;

        public LinkedListNode(object data)
        {
            Data = data;
            Next = null;
        }
    }
}
