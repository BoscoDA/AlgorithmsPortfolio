using System.Security.Cryptography.X509Certificates;
using Algorithms;

namespace AlgorithmsPortfolio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shuffled Array utilizing the Fisher Yates Shuffle");
            string[] letters = { "A", "B", "C", "D", "E","F" };
            //letters.DoFisherYatesShuffle();
            letters.DoFisherYatesAlternateShuffle();

            foreach(string l in letters)
            {
                Console.Write(l + " ");
            }

            Console.ReadKey();
        }
    }
}