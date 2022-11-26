using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Searching
{
    public class SearchingAlgorithms
    {
        /// <summary>
        /// A Binary Search function that takes in a sorted integer array and a integer Target.
        /// Returns the index of the target if present, and -1 if it is not found. 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        public int BinarySearch(int[] arr, int T)
        {
            #region Pseudocode
            //function binary_search(A, n, T) is
            //L := 0
            //R:= n − 1
            //while L ≤ R do
            //m:= floor((L + R) / 2)
            //if A[m] < T then
            //L := m + 1
            //else if A[m] > T then
            //R := m − 1
            //else:
            //return m
            //return unsuccessful
            #endregion
            int left = 0;
            int right = arr.Length - 1;

            while(left <= right)
            {
                int middle = (left + right) / 2;

                if(arr[middle] < T)
                {
                    left = middle + 1;
                }
                else if(arr[middle] > T)
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }

        public int LinearSearch(int[] arr, int t)
        {
            #region Pseudocode
            //Begin
            //1) Set i = 0
            //2) If Li = T, go to line 4
            //3) Increase i by 1 and go to line 2
            //4) If i<n then return i
            //End
            #endregion

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == t)
                {
                    return i;
                }
            }
            //default returns -1 because it is impossible and will denote when a element is not present in the array being searched
            return -1;
        }

        public int InterpolationSearch(int[]arr, int low, int high, int target)
        {
            //Must be sorted
            //Must have equal distribution between elements
            //Calculates first search index by: 
            if(low <= high && target >= arr[low] && target <= arr[high])
            {
                int pos = low + (((high - low) / (arr[high] - arr[low])) * (target - arr[low]));

                if (arr[pos] == target)
                {
                    return pos;
                }

                else if (arr[pos] < target)
                {
                    return InterpolationSearch(arr, pos + 1, high, target);
                }

                else if (arr[pos] > target)
                {
                    return InterpolationSearch(arr, low, pos - 1, target);
                }
            }

            return -1;
        }
    }
}
