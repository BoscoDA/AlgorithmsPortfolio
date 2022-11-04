namespace Assignment1BigO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigOConstantTime();
            BigOLinearTime(40);
            BigOQuadraticTime(50);
        }

        /// <summary>
        /// This method illustrates constant time: O(1). The size of an input does not effect the time in which it will run. It will always just require one step.
        /// Constant time algorithms 
        /// </summary>
        public static void BigOConstantTime()
        {
            Console.WriteLine("This method operates in constant time: O(1)");
        }

        /// <summary>
        /// This method illustrates linear time because the rate at which the output grows is linear in relation to the size of n,
        /// the input of the method. Meaning as the input grows, the algorithm takes proportionally longer to complete. n can represent both the size
        /// of a structure being inputted or the number itself being intputted.
        /// </summary>
        public static void BigOLinearTime(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("This method runs in Linear Time: O(n)");
            }
        }

        /// <summary>
        /// This method illustrates quadratic time because the rate at which the ouput grows is n * n (n^2) because of the nest for loops.
        /// For each time that the first loop iterates it must then go through 0..n in the inner loop causing a quadratic relationship.
        /// </summary>
        public static void BigOQuadraticTime(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("This method runs in Quadratic Time: O(n^2)");
                }
            }
        }
    }
}