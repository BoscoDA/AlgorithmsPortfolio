using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Sorting
{
    public static class Utilities
    {
        public static int[] ReadFromTextFile(string path)
        {
            
            string [] temp = File.ReadAllLines(path);
            int[] output = new int[temp.Length];

            int i = 0;
            foreach(string line in temp)
            {
                output[i] = Convert.ToInt32(line.Trim());
                i++;
            }

            return output;
        }

        public static void PrintArray(this int[] objects)
        {
            foreach(int obj in objects)
            {
                Console.Write(obj.ToString() + " ");
            }
        }
    }
}
