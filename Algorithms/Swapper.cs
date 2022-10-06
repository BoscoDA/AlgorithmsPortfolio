using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Swapper
    {
        /// <summary>
        /// Swaps the values in the inputted indexes i and j
        /// </summary>
        /// <param name="objects"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void SwapValuesAtIndices(this object[] objects, int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
