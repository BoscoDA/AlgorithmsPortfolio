# Sorting Algorithms

This assignments implements the six common sorting algorithms, bubble sort, insertion sort, selection sort, quick sort, merge sort, and heap sort.

## Bubble Sort
### Description
Bubble sort starts at the beginning of an array and swaps the first two elements if the first is greater than the second. Moving to the next pair, 
the same comparison is made.

### Asymptotic notation
O(n^2) average and worst case.

### Pseudocode
```
Bubblesort(Data: values[])
// Repeat until the array is sorted.
Boolean: not_sorted = True
While(not_sorted)
    // Assume we won't find a pair to swap.
    not_sorted = False
            
    // Search the array for adjacent items that are out of order.
    For i = 0 To < length of values> -1
            
    // See if items i and i - 1 are out of order.
    If(values[i] < values[i - 1]) Then
        // Swap them.
        Data: temp = values[i]
        values[i] = values[i - 1]
        values[i - 1] = temp
            
        // The array isn't sorted after all.
        not_sorted = True
    End If
    Next i
End While
End Bubblesort
```
## Insertion Sort
### Description
Insertion sort is a simple sorting algorithm that builds the final sorted set 
one item at a time. It is efficient on small data sets but is much less efficient
on large sets than quicksort, heapsort, or merge sort.
             
### Asymptotic notation
Best Case O(n), and worst case O(n^2).

### Pseudocode
```
Insertionsort(Data: values[])
    For i = 0 To < length of values> -1
        // Move item i into position
        //in the sorted part of the array
        < Find  the first index j where
        j < i and values[j] > values[i].>
        < Move the item into position j.>
    Next i
End Insertionsort
```
## Selection Sort
### Description
Sorts an array by repeatedly finding the minimum element (considering ascending order)
from the unsorted part and putting it at the beginning. Selection sort
is a in-place comparison sorting algorithm. It is inefficient on large lists,
and generally performs worse than insertion sort.

### Asymptotic notation
O(n^2) average and worst case.

### Pseudocode
```
Selectionsort(Data: values[])
    For i = 0 To < length of values> -1
    // Find the item that belongs in position i.
    < Find the smallest item with index j >= i.>
    < Swap values[i] and values[j].>
    Next i
End Selectionsort
```

## Quick Sort

### Description
The quicksort algorithm is a comparison-based sort-in-place divide-and-conquer 
strategy. Divide-and-conquer means that a larger group is separated into smaller
groups that can be more easily processed or handled. In quicksort an element is
chosen from the array to act as a ""pivot"". The pivot separates the array into two parts,
and each element in the subsections is compared to the pivot for sorting. The algorithm
recursively calls itself on the subdivided sections until all elements are sorted.

### Asymptotic notation
O(nlogn) on average and O(n^2) worst case.

### Pseudocode

#### Quick Sort
```
algorithm quicksort(A, lo, hi) is
    if lo < hi then
        p := pivot(A, lo, hi)
        left, right:= partition(A, p, lo, hi)  // note: multiple return values
        quicksort(A, lo, left - 1)
        quicksort(A, right + 1, hi)
```

#### Pivot
```
//This function takes last element as pivot, places the pivot element at its correct position in sorted array, and places all smaller (smaller than pivot) to left of pivot and all greater elements to right of pivot */

partition(arr[], low, high)
{
  pivot (Element to be placed at right position)
  pivot = arr[high];

  i = (low – 1)  // Index of smaller element and indicates the 
  // right position of pivot found so far

  for (j = low; j <= high - 1; j++)
  {

    // If current element is smaller than the pivot
    if (arr[j] < pivot)
    {
      i++;    // increment index of smaller element
      swap arr[i] and arr[j]
    }
  }
  swap arr[i + 1] and arr[high])
  return (i + 1)
}
```
## Merge Sort
### Description
Like quicksort, mergesort uses a divide-and-conquer strategy. Instead
of picking a dividing item and splitting the items into two groups holding items that
are larger and smaller than the dividing item, mergesort splits the items into two
halves holding an equal number of items. It then recursively calls itself to sort the
two halves. When the recursive calls to mergesort return, the algorithm merges the two
sorted halves into a combined sorted list.

### Asymptotic notation
O(nlogn) average and worst case.

### Pseudocode
```
Mergesort(Data: values[], Data: scratch[], Integer: start, Integer: end)
    //If the array contains only one item, it is already sorted.
    If(start == end) Then Return

    // Break the array into left and right halves.
    Integer: midpoint = (start + end) / 2

    // Call Mergesort to sort the two halves.
    Mergesort(values, scratch, start, midpoint)
    Mergesort(values, scratch, midpoint + 1, end)

    // Merge the two sorted halves.
    Integer: left_index = start
    Integer: right_index = midpoint + 1
    Integer: scratch_index = left_index
    While((left_index <= midpoint) And(right_index <= end))
        If(values[left_index] <= values[right_index]) Then
            scratch[scratch_index] = values[left_index]
            left_index = left_index + 1
        Else
            scratch[scratch_index] = values[right_index]
            right_index = right_index + 1
        End If
        scratch_index = scratch_index + 1
    End While
    // Finish copying whichever half is not empty.
    For i = left_index To midpoint
        scratch[scratch_index] = values[i]
        scratch_index = scratch_index + 1
    Next i
    For i = right_index To end
        scratch[scratch_index] = values[i]
        scratch_index = scratch_index + 1
    Next i
    // Copy the values back into the original values array.
    For i = start To end
        values[i] = scratch[i]
    Next i
End Mergesort
```

## Heap Sort
### Description
Heapsort is a comparison-based sort-in-place algorithm that takes no extra
storage. It is often described as an improved selection sort. It has an O(n log n)
run time. Asymptotically O(n log n) is the fastest possible for an algorithm that
sorts by using comparisons (although quicksort usually runs a bit faster). 

The algorithm builds a max heap. It then repeatedly swaps the first and last items 
in the heap and rebuilds the heap excluding the last item. During each pass, 
one item is removed from the heap and added to the end of the array where the 
items are placed in sorted order.

#### What is a heap? 
A heap is a specialized tree-based data structure. Let's look at definitions for these terms from Essential Algorithms (p. 175-176).
A heap is a complete binary tree where every node holds a value that is at least as large as the values in all of its children.
A binary tree is a tree where every node is connected to, at most, two children.
In a complete tree (binary or otherwise), all of the tree's levels are completely filled, except possibly the last level, 
where all of the nodes are pushed to the left.
One useful feature of complete binary trees is that you can easily store them in an array using a simple formula.
- Start by placing the root node at index 0.
- Then, for any node with index i, place its children at indices 2 x i + 1 and 2 x i + 2.
- If a node has index j, then its parent has index ⌊ (j-1)/2⌋, where ⌊ ⌋ means to truncate the result to the next-smallest integer.

### Asymptotic notation
O(nlogn) average and worst case.

### Pseudocode
#### Heap Sort
```
Heapsort(Data: values)
    <Turn the array into a heap.>
 
    For i = <length of values> - 1 To 0 Step -1
        // Swap the root item and the last item.
        Data: temp = values[0]
        values[0] = values[i]
        values[i] = temp
 
        <Consider the item in position i to be removed from the heap,
         so the heap now holds i - 1 items. Push the new root value
         down into the heap to restore the heap property.>
    Next i
End Heapsort
```
#### Heapify
```
Heapify(int[] values, int size, int root)

            int largest = root; // Initialize largest as root
            int left = 2 * root + 1; // left child = 2*i + 1
            int right = 2 * root + 2; // right child = 2*i + 2

            if (left < size && values[left] > values[largest])
                largest = left;

            if (right < size && values[right] > values[largest])
                largest = right;

            
            if (largest != root)

                swap(values, root, largest);

                //makes sure next node and childs fullfil heap requirements
                ArrayToHeap(values, size, largest);

end Heapify
```
