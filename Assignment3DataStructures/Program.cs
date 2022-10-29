using System.Collections;
using System.IO.Pipes;

namespace Assignment3DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../../Data/Accounts.xml";

            // LIFO (Last-In, First-Out)
            // Can be implemented with a linked list or a dynamic array
            // Stack class implemented in C# ustilizes a dynamic array
            // No random access
            // Can peek at the top of the stack by no further.
            // When resized the stacks size is automatically increased by twice the initial
            // When you want to add a element you "push" adding it to the head of the stack
            // When you want to remove a element you "pop" it which removes and returns the first element of the stack
            // Depending on how the stack is implemented determines how it is stored in memory
            // Operation Speeds: Push: O(1)O(1) Pop: O(1)O(1) Peek: O(1)O(1)
            Stack<char> stack = new Stack<char>();

            // FIFO (First-In, First-Out)
            // Easiest to implement using a linked list, in C# the queue class utilizes a circular array
            // No random access
            // Can peek at the first item / head.
            // When full the queue's size increases by a default growth factor of 2 in C#
            // New elements are "enqeued" and added to the end of the quene
            // When you want to remove a element or use it you "dequeue" which removes and returns the first element of the queue
            // Depending on how the queue is implemented determines how it is stored in memory
            // Operation Speeds: Enqueue: O(1) Dequeue: O(1) Peek: O(1)
            Queue<char> queue = new Queue<char>();

            // Fixed Capacity, must know the size of the data beforehand. With only way to increase capacity creating a new array.
            // Zero Indexed (indexed from 0 to n-1)
            // Can be randomly accessed, as long as the index is within the bounds of the array
            // Are Contiguous Memory (stored in a block in one place), but also objects in C#
            // Operation speeds: Insert: O(1) Access: O(1) Search: O(n) Remove: O(n)
            Account[] arryAccounts = DataLoader.LoadXMLIntoArray(fileName);
            
            // Uses a "Hash Function" is used to map a key to location (bucket) in the data structure
            // A "Collision" is when a Hash Function returns a hash code to a bucket in the structure already holding a item, when this happens you need a collision policy.
            // Two popular collision stratogies are chaing and open addressing.
            // Hash Tables have a load factor which determines the maximum ratio of elements to buckets
            // Allows for lookup by key
            // Operation Speeds: Insert: O(1) Access: O(1) Delete: O(1) Search: O(1)
            Hashtable hashAccounts = DataLoader.LoadXMLIntoHashTable(fileName);


            //-----------------------Hash Table VS. Array-----------------------
            //Hashtables are more efficient than arrays when it comes to removing items and searching

            //If this was a online ticketing application...
            Console.WriteLine("-----------------------Hash Table VS. Array-----------------------");
            Console.WriteLine("Example 1: Login Feature - You would use a hash table because if the data is large enough and a key such and the data is stored with the email as the key it" +
                "will be 0(1) time to access the data rather than O(n) with an array.");
            Console.WriteLine("\nAccount Credentials: Email: blagadirov2@hangxomu.com Password: ILovePuppies");
            Console.WriteLine("--------Login--------");
            Console.Write("Email: ");
            string email = Console.ReadLine().ToString();
            Console.Write("\nPassword: ");
            string password = Console.ReadLine().ToString();
            Account tempHash = ((Account)hashAccounts[email]);

            Console.WriteLine("\nLogging in using HashTable...");
            if(tempHash == null)
            {
                Console.WriteLine("Incorrect email or password");
            }
            else if(tempHash.Password == password)
            {
                Console.WriteLine("Log in successful!");
            }
            else
            {
                Console.WriteLine("Incorrect email or password");
            }

            Console.WriteLine("\nExample 2: Raffle Winner - If you wanted to hold a contest/raffle for tickets you would want to use a array because you can randomly index it for a winner.");
            Random random = new Random();
            int winner = random.Next(arryAccounts.Length - 1);
            Account contestWinner = arryAccounts[winner];
            Console.WriteLine("The winner is... {0}", contestWinner.Name);



            // -----------------------Stack VS. Queue-----------------------

            // Are equivalent efficiency on operation, only difference in use is the FIFO and LIFO orders that they follow.

            //Uses - If you the order in which the came in is the order is also needs to come out, such as building a string you would use a queue.
            //If you wanted to check if the string was a palindrome you could use a stack to reverse the order.
            Console.WriteLine("-----------------------Stack VS. Queue-----------------------");

            string word = "array";

            Console.WriteLine($"Storing the string\"Array\" in a stack and queue");
            foreach (char c in word)
            {
                queue.Enqueue(c);
                stack.Push(c);
            }
            Console.WriteLine("\nStack output:");
            foreach(char c in stack)
            {
                Console.Write(c);
            }
            Console.WriteLine("\nQueue output:");
            foreach (char c in queue)
            {
                Console.Write(c);
            }


            Console.ReadKey();
        }
    }
}