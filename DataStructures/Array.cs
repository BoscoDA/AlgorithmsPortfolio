using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Arrays
    {
        // one dimensional array
        int[] arry = new int[5];

        // two dimensinal arry
        int[,] multiDimArry = new int[2, 3];
        int[,] multiDimArry2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 3, 4, 5 } };

        // jagged array
        int[][] jaggedArray = new int[6][];
        //jaggedArray[0] = new int[4]{1,2,3,4};

        public static bool ConsecutiveIntegers(int[] arr)
        {
            int result = 0;
            int minVal = arr[0];

            //find min and max val
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < minVal)
                {
                    minVal = arr[i];
                }
            }

            //check for consecutive
            for (int i = 0; i < arr.Length; i++)
            {

                // Original Implementation
                //if (FindInt(arr, minVal) == true)
                //{
                //    result = true;
                //}
                //else
                //{
                //    result = false;
                //    break;
                //}

                // Revised implementation for O(n) time
                result ^= minVal ^ arr[i];
                minVal++;
            }
            // Revised implementation for O(n) time
            if (result == 0)
            {
                return true;
            }
            return false;
        }

        public static bool FindInt(int[] arr, int num)
        {
            bool result = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
