using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms();

            int[] vals = Utilities.ReadFromTextFile("../../../scores.txt");

            //Bubble Sort ------------------------------------------------------------------------------------------
            watch.Start();
            sortingAlgorithms.BubbleSort(vals);
            watch.Stop();

            TimeSpan bubble = watch.Elapsed;

            Console.WriteLine("---------------------------------------- BubbleSort ----------------------------------------");
            Console.WriteLine(@"Description: Bubble sort starts at the beginning of an array and swaps the first two
             elements if the first is greater than the second. Moving to the next pair, the
             same comparison is made.");
            Console.WriteLine("\nAsymptotic notation: O(n^2) average and worst case.\n");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(@"---------------------------------------- Pseudocode --------------------------------------- 
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
End Bubblesort");

            Console.WriteLine("---------------------------------------- Array Sorted ----------------------------------------");
            Console.WriteLine("\nRuntime: " + "{0}", bubble.TotalMilliseconds +"ms");

            Console.WriteLine("\nPress any key for next algorithm...");
            Console.ReadKey();
            Console.Clear();


            // Insertion Sort -------------------------------------------------------------------------------------
            vals = Utilities.ReadFromTextFile("../../../scores.txt");
            watch.Restart();
            watch.Start();
            sortingAlgorithms.InsertionSort(vals);
            watch.Stop();
            TimeSpan insertion = watch.Elapsed;

            Console.WriteLine("---------------------------------------- Insertion Sort ----------------------------------------");
            Console.WriteLine(@"Description: Insertion sort is a simple sorting algorithm that builds the final sorted set 
             one item at a time. It is efficient on small data sets but is much less efficient
             on large sets than quicksort, heapsort, or merge sort.");
            Console.WriteLine("\nAsymptotic notation: Best Case O(n), and worst case O(n^2).\n");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(@"---------------------------------------- Pseudocode --------------------------------------- 
Insertionsort(Data: values[])
    For i = 0 To < length of values> -1
        // Move item i into position
        //in the sorted part of the array
        < Find  the first index j where
        j < i and values[j] > values[i].>
        < Move the item into position j.>
    Next i
End Insertionsort");

            Console.WriteLine("---------------------------------------- Array Sorted ----------------------------------------");
            Console.WriteLine("\nRuntime: " + "{0}", insertion.TotalMilliseconds + "ms");

            Console.WriteLine("\nPress any key for next algorithm...");
            Console.ReadKey();
            Console.Clear();

            // Selection Sort -------------------------------------------------------------------------------------
            vals = Utilities.ReadFromTextFile("../../../scores.txt");
            watch.Restart();
            watch.Start();
            sortingAlgorithms.SelectionSort(vals);
            watch.Stop();
            TimeSpan selection = watch.Elapsed;

            Console.WriteLine("---------------------------------------- Selection Sort ----------------------------------------");
            Console.WriteLine(@"Description: Sorts an array by repeatedly finding the minimum element (considering ascending order)
             from the unsorted part and putting it at the beginning. Selection sort
             is a in-place comparison sorting algorithm. It is inefficient on large lists,
             and generally performs worse than insertion sort. ");
            Console.WriteLine("\nAsymptotic notation: O(n^2) average and worst case.\n");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(@"---------------------------------------- Pseudocode --------------------------------------- 
Selectionsort(Data: values[])
    For i = 0 To < length of values> -1
    // Find the item that belongs in position i.
    < Find the smallest item with index j >= i.>
    < Swap values[i] and values[j].>
    Next i
End Selectionsort");

            Console.WriteLine("---------------------------------------- Array Sorted ----------------------------------------");
            Console.WriteLine("\nRuntime: " + "{0}", selection.TotalMilliseconds + "ms");

            Console.WriteLine("\nPress any key for next algorithm...");
            Console.ReadKey();
            Console.Clear();


            // Quick Sort ----------------------------------------------------------------------------------------
            vals = Utilities.ReadFromTextFile("../../../scores.txt");
            watch.Restart();
            watch.Start();
            sortingAlgorithms.QuickSort(vals, 0, vals.Length - 1);
            watch.Stop();
            TimeSpan quick = watch.Elapsed;

            Console.WriteLine("---------------------------------------- Quick Sort ----------------------------------------");
            Console.WriteLine(@"Description: The quicksort algorithm is a comparison-based sort-in-place divide-and-conquer 
             strategy. Divide-and-conquer means that a larger group is separated into smaller
             groups that can be more easily processed or handled. In quicksort an element is
             chosen from the array to act as a ""pivot"". The pivot separates the array into two parts,
             and each element in the subsections is compared to the pivot for sorting. The algorithm
             recursively calls itself on the subdivided sections until all elements are sorted.");
            Console.WriteLine("\nAsymptotic notation: O(nlogn) on average and O(n^2) worst case.\n");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(@"---------------------------------------- Pseudocode --------------------------------------- 
algorithm quicksort(A, lo, hi) is
    if lo < hi then
        p := pivot(A, lo, hi)
        left, right:= partition(A, p, lo, hi)  // note: multiple return values
        quicksort(A, lo, left - 1)
        quicksort(A, right + 1, hi)");

            Console.WriteLine("\n---------------------------------------- Array Sorted ----------------------------------------");
            Console.WriteLine("\nRuntime: " + "{0}", quick.TotalMilliseconds + "ms");

            Console.WriteLine("\nPress any key for next algorithm...");
            Console.ReadKey();
            Console.Clear();

            // Merge Sort ----------------------------------------------------------------------------------------
            vals = Utilities.ReadFromTextFile("../../../scores.txt");
            int[] scratch = new int[vals.Length];
            watch.Restart();
            watch.Start();
            sortingAlgorithms.MergeSort(vals,scratch,0,vals.Length-1);
            watch.Stop();
            TimeSpan merge = watch.Elapsed;

            Console.WriteLine("---------------------------------------- Merge Sort ----------------------------------------");
            Console.WriteLine(@"Description: Like quicksort, mergesort uses a divide-and-conquer strategy. Instead
             of picking a dividing item and splitting the items into two groups holding items that
             are larger and smaller than the dividing item, mergesort splits the items into two
             halves holding an equal number of items. It then recursively calls itself to sort the
             two halves. When the recursive calls to mergesort return, the algorithm merges the two
             sorted halves into a combined sorted list.");
            Console.WriteLine("\nAsymptotic notation: O(nlogn) average and worst case.\n");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(@"---------------------------------------- Pseudocode --------------------------------------- 
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
End Mergesort");

            Console.WriteLine("---------------------------------------- Array Sorted ----------------------------------------");
            Console.WriteLine("\nRuntime: " + "{0}", merge.TotalMilliseconds + "ms");

            Console.WriteLine("\nPress any key for next algorithm...");
            Console.ReadKey();
            Console.Clear();

            // Heap Sort ----------------------------------------------------------------------------------------
            vals = Utilities.ReadFromTextFile("../../../scores.txt");
            watch.Restart();
            watch.Start();
            sortingAlgorithms.HeapSort(vals);
            watch.Stop();
            TimeSpan heap = watch.Elapsed;

            Console.WriteLine("---------------------------------------- Heap Sort ----------------------------------------");
            Console.WriteLine(@"Description: Heapsort is a comparison-based sort-in-place algorithm that takes no extra
             storage. It is often described as an improved selection sort. It has an O(n log n)
             run time. Asymptotically O(n log n) is the fastest possible for an algorithm that
             sorts by using comparisons (although quicksort usually runs a bit faster). 
             
             The algorithm builds a heap. It then repeatedly swaps the first and last items 
             in the heap and rebuilds the heap excluding the last item. During each pass, 
             one item is removed from the heap and added to the end of the array where the 
             items are placed in sorted order.");
            Console.WriteLine("\nAsymptotic notation: O(nlogn) average and worst case.\n");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(@"---------------------------------------- Pseudocode --------------------------------------- 
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
End Heapsort");

            Console.WriteLine("---------------------------------------- Array Sorted ----------------------------------------");
            Console.WriteLine("\nRuntime: " + "{0}", heap.TotalMilliseconds + "ms");

            Console.WriteLine("\nPress any key for next algorithm...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("----------------------------------------  Summary ----------------------------------------");
            Console.WriteLine("Bubble sort runtime: " + "{0}", bubble.TotalMilliseconds + "ms");
            Console.WriteLine("Insertion sort runtime: " + "{0}", insertion.TotalMilliseconds + "ms");
            Console.WriteLine("Selection sort runtime: " + "{0}", selection.TotalMilliseconds + "ms");
            Console.WriteLine("Quick sort runtime: " + "{0}", quick.TotalMilliseconds + "ms");
            Console.WriteLine("Heap sort runtime: " + "{0}", heap.TotalMilliseconds + "ms");
            Console.WriteLine("Merge sort runtime: " + "{0}", merge.TotalMilliseconds + "ms");

            Console.ReadKey();
            
        }
    }
}
    
