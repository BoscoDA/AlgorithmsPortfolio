using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FisherYatesShuffle
    {
        //random class is a pseudo-random number generator
        //"pseudo-random numbers are chosen with equal probability from a finite set of numbers"
        //"based on a modified version of Donald E. Knuth's subtractive random number generator algorithm" 
        //the same man who is credited for popularizing the fisher yates shuffle in cs field
        //https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-6.0
        private static Random randNum = new Random();
        
        /// <summary>
        /// Implements the Fisher Yates shuffle to shuffle the inputted array. 
        /// This version sorts starting at the last element of the array going down the first.
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="objects"></param>
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

        //following the single responsibility principle the swap could be moved to another class
        //private static void Swap(object[] objects, int i, int j)
        //{
        //    object temp = objects[i];
        //    objects[i] = objects[j];
        //    objects[j] = temp;
        //}

        /// <summary>
        /// Implements the Fisher Yates shuffle to shuffle the inputted array.
        /// This version sorts starting at the first element of the array, working its way to the end.
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="objects"></param>
        public static void DoFisherYatesAlternateShuffle(this object[] objects)
        {
            //iterates through n-2 times because the last element of the array will be the only one left at the end with no other elements
            //in the unshuffled half to swap with
            for (int i = 0; i < objects.Length-2; i++)
            {
                int j = GetRandNumBetweenZeroAnd((objects.Length - i)-1);
                objects.SwapValuesAtIndices(i, i+j);
            }
        }

        /// <summary>
        /// Returns a pseudo-random number between 0 -> parameter (uninclusive)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static int GetRandNumBetweenZeroAnd(int i)
        {
            return randNum.Next(i + 1);
        }
    }
}
