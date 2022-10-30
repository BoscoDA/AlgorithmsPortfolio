# PROG 366 Algorithms Portfolio

This is first and foremost a portfolio  documenting my progress learning algorithms throughout the my fall 2022 semester at Columbia College Chicago. When finished it will be a semi-living library of algorithms and algorithm information for easy to access future use.

## Week 2 - 

This weeks assignmented required implenting methods that illustrate my understanding of three big-O time complexities:
  1. Constant Time: O(1)
  2. Linear Time: O(n)
  3. Quadratic time: O(n^2)

The methods exemplifying each of these can be found in the Algorithms library in the project in BigOExamples
  
## Week 5 - Fisher Yates Shuffle

The Fisher Yates shuffle is algorithm for generating a random unbiased permutation, every permutation is equally likely, of a finite sequence. The original form of the algorithm could be carried out as follows:

  1. Write down the numbers from 1 through N.
  2. Pick a random number k between one and the number of unstruck numbers remaining (inclusive).
  3. Counting from the low end, strike out the kth number not yet struck out, and write it down at the end of a separate list.
  4. Repeat from step 2 until all the numbers have been struck out.
  5. The sequence of numbers written down in step 3 is now a random permutation of the original numbers.
  
If implemented in code it would result in a run time of O(n^2) because each loop in step three it would have to loop through the array counting the entrices to strike out the needed one. To adapt this algorithm to computers the striking out of entrices was changed to moving the struck entrices to the end of the array by swapping them with the last unstruck number. Making the change to shuffle the array in place by swapping values reduces the time complexity to O(n), n being the size of the array being shuffled. This modern implementation of the Fisher Yates Shuffle, also know as the Knuth Shuffle is implemented below as extension methods in C#:
      
```cs
    public static void DoFisherYatesShuffle(this object[] objects)
        {
            for(int i = objects.Length-1; i > 0; i--)
            {
                //j is a random index chosen from the unsorted side of the array. this length is represented by i
                int j = GetRandNumBetweenZeroAnd(i);
                //operating on the array in place allows for the time complexity to be O(n), n being the size of the input array
                objects.SwapValuesAtIndices(i, j);
            }
        }
        
    private static int GetRandNumBetweenZeroAnd(int i)
        {
            return randNum.Next(i + 1);
        }
        
    public static void SwapValuesAtIndices(this object[] objects, int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
```

An example of the Fisher Yates shuffle in the context of a simple console application which generates a deck of cards and them shuffles was also completed for this week.

[Example Application](https://github.com/BoscoDA/AlgorithmsPortfolio/tree/master/FisherYatesCardShuffle "Named link title")

## Week 7 & 8 - Data Structures

### Arrays
Zero Indexed (indexed from 0 to n-1).
Arrays have a fixed Capacity, meaning you must know the size of the data beforehand. The only way to increase the capacity of a array is by creating a new array.
Array's can be randomly accessed, as long as the index is within the bounds of the array.
Array's are Contiguous Memory (stored in a block in one place), but in C# they are also objects.

Types of Arrays:
- Single Dimensional: A single line of elements.
- Multidimensional: Creates a matrix of elements.
- Jagged: An array of arrays

Operations:
- Insert: Adds element to the end of the array. O(1) time complexity.
- Access: Returns the element of a given index. O(1) time complexity.
- Search: Iterates through the array until a given index is located. O(n) time complexity.
- Remove: Seaches for given index, removes it and then reconstructs the array 1 index shorter. O(n) time complexity.

Here is a nice infograpghic demonstrating a array: ![Array](DSA-array.png)

### Stacks
Stacks follow LIFO, meaning Last-In, First-Out.
They can be implemented with either a linked list or a dynamic array.
The Stack class in C# is implemented through a dynamic array.
Stacks do not allow random access, but you can peek at the top of the stack, but nothing further!
When resized the stacks size is automatically increased by twice the initial size.
Depending on how the stack is implemented determines how it is stored in memory.

Operations:
- Push: Adds a element to the top of the stack. Time Efficiency: O(1)O(1). 
- Pop: Removes and returns the top element of the stack: Time Efficiency: O(1)O(1). 
- Peek: Allows you to look at the top element of the stack. Time Efficiency: O(1)O(1).

Here is a nice infograpghic demonstrating a Stack: ![Stack](stacks.png) 

### Queues
Queues follow FIFO, meaning First - In, First - Out.
They are easiest to implement using a linked list, but can also be implemented using a array, in C# the queue class utilizes a circular array
Queues do not allow random access, but you can peek at the head of the queue, but nothing further!
When full the queue's size increases by a default growth factor of 2 in C#.
Depending on how the queue is implemented determines how it is stored in memory.

Special Types:
- Deque: Insertion and removal can be done on both ends of the queue. Does not follow FIFO.
- Circular Queue: The last element points back to the head of the queue.
- Priority Queue: Each element is given a priority and is served with this priority in mind.

Operation: 
- Enqueue: Add a element to the tail/end of the queue. Time Efficiency: O(1).
- Dequeue: Removes and returns the element at the head of the queue. Time Efficiency: O(1)
- Peek: Returns the head of the queue. Time Efficiency: O(1)

Here is a nice infograpghic demonstrating a Queue: ![Queue1](q1.png) ![Queue2](q2.jpeg) 

### Hash Tables
A abstract data type that contains a collections of keys and a collections of values. 
A "Hash Function" is used to map a key to location (bucket) in the data structure.
"Hashing" is when you use a hash function to index a hash table.
A "Collision" is when a Hash Function returns a hash code to a bucket in the structure already holding a item, when this happens you need a collision policy.
Two popular collision stratogies are chaining and open addressing.
Hash Tables have a load factor which determines the maximum ratio of elements to buckets.
Allows for lookup by key.
Great for fast look ups and the flexibility of its keys.

Collision Resolution Strategies
- Separe Chaining (Closed Addressing): Uses a structure such as a linked list as the bucket to hold multiple entries in a singles index.
- Open Addressing: Uses only the hash table.
  - Linear Probing
  - Quadratic Probing
  - Double Hashing
- Coalesced Hashing
- Cuckoo Hashing
- Hopscotch Hashing
- 2-Choice Hashing
- Robin Hood Hashing: Moves elements slowly away from prefered as new elements come in that could make better use of that place in the table.

Operation Speeds: 
- Insert: O(1) 
- Access: O(1) 
- Delete: O(1) 
- Search: O(1)
  
Here is a nice infograpghic demonstrating a Hash Table: ![Hash](hash.jpeg) ![Hash2](map.png) 

###Assigntment 3 - Data Structures
In my application you will see a stack and queue with the same items created and a array and hash table with the same large amount of data read into them. The stack and queue deomonstrate that their unique ues come from the direction you want the data back in, FIFO or LIFO. The array and hash table examples show how the hash table excels at lookups over the array.
