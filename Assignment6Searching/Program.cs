using System.Diagnostics;

namespace Assignment6Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SearchingAlgorithms searcher = new SearchingAlgorithms();
            Stopwatch watch = new Stopwatch();
            int[] arr = new int[] { 2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,38,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,98,100 };

            watch.Start();
            int linearResult = searcher.LinearSearch(arr, 66);
            watch.Stop();
            TimeSpan linearTime = watch.Elapsed;
            watch.Reset();

            watch.Start();
            int binaryResult = searcher.BinarySearch(arr, 66);
            watch.Stop();
            TimeSpan binaryTime = watch.Elapsed;
            watch.Reset();

            watch.Start();
            int interpolationResult = searcher.InterpolationSearch(arr, 0, arr.Length - 1, 66);
            watch.Stop();
            TimeSpan interpolationTime = watch.Elapsed;
            watch.Reset();

            Console.WriteLine("---------------------------- Linear Search ----------------------------");
            Console.WriteLine(@"Description: The linear search algorithm iterates through each element
             of the data set comparing each element to the target until the 
             target is either found or the algorithm reaches the 
             end of the data set.");
            Console.WriteLine("\nAsymptotic Notation: Worst Case: O(n) Best Case: O(1) Average: O(n/2)\n");
            Console.WriteLine(@"Pseudocode:
Start LinearSearch(array, target)
    for i = 0 to array length
        if array[i] == target
            return i
        i++
    return -1
end LinearSearch");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("---------------------------- Binary Search ----------------------------");
            Console.WriteLine(@"Description: The Binary search algorithm requires a sorted data set.
             It compares the value in the middle of the data set to
             the value being searched for. If the values are not
             equal, the algorithm then checks to see which half
             of the data set will contain the target. This is
             then recursively or iteratively repeated until the
             target is found or the algorithm reachs the end of 
             the data set.");
            Console.WriteLine("\nAsymptotic Notation: O(logn)\n");
            Console.WriteLine(@"Pseudocode:
function binary_search(A, n, T) is
    L := 0
    R := n − 1
    while L ≤ R do
        m := floor((L + R) / 2)
        if A[m] < T then
            L := m + 1
        else if A[m] > T then
            R := m − 1
        else:
            return m
    return unsuccessful");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("---------------------------- Interpolation Search ----------------------------");
            Console.WriteLine(@"Description: Interpolation Search is a improvement over Binary Search for 
             sorted data sets that are uniformally distributed.
             Instead of starting a the middle the data set, it
             uses the formula for linear interpolation:
             y = y1 + ((y2-y1)/(x2-x1))(x-x1)
             x = target (T)
             y = probe 
             y1 = low index (L)
             x1 = array[low index] (a[L])
             y2 = high index (H)
             x2 = array[high index] (a[H])
             prode = a[L] + (x-a[L]/a[H]-a[L]) * (H - L)
             ");
            Console.WriteLine("\nAsymptotic Notation: Best Case: O(log log n) Worst Case: O(n)\n");
            Console.WriteLine(@"Pseudocode:
being LinearInterpolation(arr[], h, l, t
    probe = a[L] + (x-a[L]/a[H]-a[L]) * (H - L)
    if a[probe] = t
        return probe
    else if a[probe] < t
        return LinearInterpolation(arr[], probe -1, l, t)
    else if a[probe] > t
        return LinearInterpolation(arr[], h, probe + 1, t)
    return -1");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-------------------------- Summary --------------------------");
            Console.WriteLine("Runtimes: Linear {0}ms | Binary {1}ms | Interpolation {2}ms", linearTime.TotalMilliseconds, binaryTime.TotalMilliseconds, interpolationTime.TotalMilliseconds);
            Console.WriteLine("Linear Search is the slowest algorithm because it has no choice but to search through each element of the dataset" +
                "until it finds or doesn't find the target. While both Binary and Linear Interpolation searches both have ways to cut down the " +
                "number of elements it must search through." +
                "\n" +
                "Binary and interpolation search both follow the same general algorithm of splitting the set into two and then checking if the value at that point is" +
                "equal to, less, or greater than the target and adjusts its probe based off of that. The two methods vary in the way the probe index is" +
                "calculated, binary seach always calculates it by finding the middle of the set, while the interpolation method utilizes the equation" +
                "for linear interpolation to calculate the probe value. With this more accurate method of probing the data does need to be uniformally" +
                "distributed for the maximum preformance increase over binary search.");
            Console.ReadKey();
        }
    }
}