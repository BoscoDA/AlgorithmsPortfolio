using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment5Sorting
{
    public class SortingAlgorithms
    {
        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public void BubbleSort(int[] values)
        {
            #region Pseudocode
            //    Bubblesort(Data: values[])
            //    // Repeat until the array is sorted.
            //    Boolean: not_sorted = True
            //    While(not_sorted)
            //        // Assume we won't find a pair to swap.
            //        not_sorted = False
            //
            //        // Search the array for adjacent items that are out of order.
            //        For i = 0 To < length of values> -1
            //
            //            // See if items i and i - 1 are out of order.
            //            If(values[i] < values[i - 1]) Then
            //                // Swap them.
            //                Data: temp = values[i]
            //                values[i] = values[i - 1]
            //                values[i - 1] = temp
            //
            //                // The array isn't sorted after all.
            //                not_sorted = True
            //            End If
            //        Next i
            //    End While
            //    End Bubblesort
            #endregion

            bool notSorted = true;
            // while the array is not sorted
            while (notSorted) 
            {
                notSorted = false;
                //each value in the array is iterated through checking if it adjacent value is large
                //if it is, it swaps the two values
                for (int i = 0; i < values.Length-1; i++)
                {
                    //change to less than to sort greatest to smallest
                    if(values[i] > values[i + 1])
                    {
                        swap(values, i, i + 1);
                        notSorted = true;
                    }
                }
            }
        }

        public void SelectionSort(int[] values)
        {
            #region Pseudocode
            //Selectionsort(Data: values[])
            //    For i = 0 To < length of values> -1
            //        // Find the item that belongs in position i.
            //        < Find the smallest item with index j >= i.>
            //        < Swap values[i] and values[j].>
            //    Next i
            //End Selectionsort
            #endregion
            // iterates through each value of the input array
            for (int i = 0; i < values.Length-1; i++)
            {
                // x is used to hold the index of the smallest number not sorted
                int x = i;

                //iterates through the "unsorted" side of the array starting a j + 1 because a array of 1 value is sorted.
                //each iteration will make the unsorted side needed to be search smaller and the "sorted" side bigger. 
                for(int j = i + 1; j < values.Length; j++)
                {
                    if (values[x] > values[j])
                    {
                        x = j;
                    }
                }
                //swaps the values
                swap(values, i, x);
            }
        }

        public void InsertionSort(int[] values)
        {
            #region Pseudocode
            //          Insertionsort(Data: values[])
            //              For i = 0 To < length of values> -1
            //                  // Move item i into position
            //                  //in the sorted part of the array
            //                  < Find  the first index j where
            //                  j < i and values[j] > values[i].>
            //                  < Move the item into position j.>
            //              Next i
            //          End Insertionsort
            #endregion
            // for each element in the array this algorithm and swaps it until it is in its final place
            // sorting the array in place

            // goes through each item in the array
            // starts at 1 because a array of 1 item is sorted already
            for (int i = 1; i < values.Length; i++)
            {
                int j = i;
                // then takes item i and checks all the previous values in the "sorted" side of the array if they are larger than the current value
                // if it is it swaps them and it does this until i is in its final position.
                while(j > 0 && values[j-1] > values[j])
                {
                    int temp = values[j];
                    values[j] = values[j-1];
                    values[j-1] = temp;
                    j -= 1;
                }
            }
        }

        public void HeapSort(int[] values)
        {
            int size = values.Length;

            // i = last node (can be found by array.Length/2 - 1)
            // iterate for each node
            for (int i = size / 2 - 1; i >= 0; i--)
                ArrayToHeap(values, size, i);

            for (int i = size - 1; i > 0; i--)
            {
                swap(values, 0, i);

                ArrayToHeap(values, i, 0);
            }
        }

        private void ArrayToHeap(int[] values, int size, int root)
        {
            int largest = root; // Initialize largest as root
            int left = 2 * root + 1; // left child = 2*i + 1
            int right = 2 * root + 2; // right child = 2*i + 2

            if (left < size && values[left] > values[largest])
                largest = left;

            if (right < size && values[right] > values[largest])
                largest = right;

            
            if (largest != root)
            {
                swap(values, root, largest);

                //makes sure next node and childs fullfil heap requirements
                ArrayToHeap(values, size, largest);
            }
        }

        public void QuickSort(int[] arry, int lo, int hi)
        {
            #region Pseudocode
            //algorithm quicksort(A, lo, hi) is
            //    if lo < hi then
            //        p := pivot(A, lo, hi)
            //        left, right:= partition(A, p, lo, hi)  // note: multiple return values
            //        quicksort(A, lo, left - 1)
            //        quicksort(A, right + 1, hi)
            #endregion

            if (lo < hi)
            {
                int p = Pivot(arry, lo, hi);
                QuickSort(arry, lo, p - 1);
                QuickSort(arry, p+1, hi);
            }

        }

        public int Pivot(int[] arry, int lo, int hi)
        {
            /* This function takes last element as pivot, places the pivot element at its correct position in sorted array, and places all smaller (smaller than pivot) to left of pivot and all greater elements to right of pivot */

            //partition(arr[], low, high)
            //{
            // pivot (Element to be placed at right position)
            //pivot = arr[high];

            //i = (low – 1)  // Index of smaller element and indicates the 
            // right position of pivot found so far

            //for (j = low; j <= high - 1; j++)
            //{

            // If current element is smaller than the pivot
            //if (arr[j] < pivot)
            //{
            //i++;    // increment index of smaller element
            //swap arr[i] and arr[j]
            //}
            //}
            //swap arr[i + 1] and arr[high])
            //return (i + 1)
            //}

            int pivot = arry[hi];
            int i = (lo - 1);

            for(int j = lo; j <= hi - 1; j++)
            {
                if (arry[j] < pivot)
                {
                    i++;
                    swap(arry, i, j);
                }
            }
            swap(arry, i + 1, hi);
            return i + 1;
        }

        public void MergeSort(int[] values, int[] scratch, int start, int end)
        {
            #region Pseudocode
            //          Mergesort(Data: values[], Data: scratch[], Integer: start, Integer: end)
            //          //If the array contains only one item, it is already sorted.

            //          If(start == end) Then Return

            //              // Break the array into left and right halves.
            //              Integer: midpoint = (start + end) / 2

            //              // Call Mergesort to sort the two halves.
            //              Mergesort(values, scratch, start, midpoint)
            //              Mergesort(values, scratch, midpoint + 1, end)

            //              // Merge the two sorted halves.
            //              Integer: left_index = start
            //              Integer: right_index = midpoint + 1
            //              Integer: scratch_index = left_index
            //              While((left_index <= midpoint) And(right_index <= end))
            //                  If(values[left_index] <= values[right_index]) Then
            //                      scratch[scratch_index] = values[left_index]
            //                      left_index = left_index + 1
            //                  Else
            //                      scratch[scratch_index] = values[right_index]
            //                      right_index = right_index + 1
            //                  End If
            //                  scratch_index = scratch_index + 1
            //                  End While
            //              // Finish copying whichever half is not empty.
            //              For i = left_index To midpoint
            //                  scratch[scratch_index] = values[i]
            //                  scratch_index = scratch_index + 1
            //              Next i
            //              For i = right_index To end
            //                  scratch[scratch_index] = values[i]
            //                  scratch_index = scratch_index + 1
            //                  Next i
            //              // Copy the values back into the original values array.
            //              For i = start To end
            //                  values[i] = scratch[i]
            //              Next i
            //          End Mergesort
            #endregion

            if (start != end)
            {
                int midPoint = (start + end) / 2;

                MergeSort(values, scratch, start, midPoint);
                MergeSort(values, scratch, midPoint + 1, end);

                int leftIndex = start;
                int rightIndex = midPoint+1;
                int scratchIndex = leftIndex;
                while((leftIndex <= midPoint) && (rightIndex <= end))
                {
                    if (values[leftIndex] <= values[rightIndex])
                    {
                        scratch[scratchIndex] = values[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        scratch[scratchIndex] = values[rightIndex];
                        rightIndex++;
                    }
                    scratchIndex++;
                }

                for(int i = leftIndex; i <= midPoint; i++){
                    scratch[scratchIndex] = values[i];
                    scratchIndex++;
                }
                for (int i = rightIndex; i <= end; i++)
                {
                    scratch[scratchIndex] = values[i];
                    scratchIndex++;
                }

                for(int i = start; i <= end; i++)
                {
                    values[i] = scratch[i];
                }
            }
        }
    }
}
