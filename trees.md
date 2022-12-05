# Trees
Trees organize values hierarchically. Each vale in the tree is called a node and each node may bave child nodes.
A node that has child nodes connected to it is called a parent node. The first value/node is call the root. The root
has no parent nodes. 

The depth of a tree is the number of links/nodes from the root to the node you are measuring. The Height of a tree
is the number of links/nodes from the root to the furthest node.

![Alt Text](https://www.tutorialspoint.com/data_structures_algorithms/images/binary_tree.jpg)

## Binary Tree
A binary trees is a specific type of tree where each node may have at most two child nodes conneted to it, one to the left
and one to the right. There can be duplicate values. 

### Implementation
- Each level is filled up before another level is added
- The bottom tier is filled in from left to right

## Binary Search Tree
Also known as a ordered or sorted binary tree, it is a rooted binary tree which stores values less than the root in the left
subtree and values which are larger than the root in the right subtree. Each subtree in the tree must also follow this pattern.
There can be no duplicate values.

### Implementation
Filled up by values larger of the root/parent going to the right and the values smaller than the root/parent going
to the left. Each level does not need to be filled fully before moving on to the next.

### Traversal
There are three way to traverse a binary tree:
1. Pre-Order: Root Node -> Left Child -> Right Child
2. In-Order: Left Child -> Root Node -> Right Child
3. Post-Order: Left Child -> Right Child -> Root Node

## Heaps
A heap is a specialized tree-based data strucutre. In a heap, the highest or lowest priority element is always stored at the
root. Heaps are commonly used as a implementation for a priotiy queue and for heap sort.

### Max Heap
In a max heap the largest value is always at the top, then each parent in both the left and right subtrees are smaller than the
root and bigger than its children.

### Min Heap
In a min heap the smallest value is always at the top, then each parent in both the left and right subtrees are larger than the
root and smaller than their respective child nodes.

### Get
Returns the root's value, so either the max or min of the heap. 
Time Complexity: O(1)

### Remove
Removes the root of the heap, either the smallest or largest value, and then moves the right most item of the bottom level
to the top to be the new root. After this it verifies the need heap still fufills the requirements need to be a heap, moving
the new root into place.

### Insert
Adds a new element to the end of the heap in the first available space. If this violates the heap quality sift up the new element
until the property has been restored.

### Heapify
Process for turning a array into a heap.
