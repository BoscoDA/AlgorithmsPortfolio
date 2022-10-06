

namespace FisherYatesCardShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("Unshuffled Deck of Cards: \n");
            Deck myDeck = new Deck();
            foreach(Card c in myDeck.cards)
            {
                c.DisplayCard();
            }
            myDeck.Shuffle();

            Console.WriteLine("\n\nShuffled deck using Fisher Yates Shuffle: \n");
            foreach (Card c in myDeck.cards)
            {
                c.DisplayCard();
            }

            Console.ReadKey();
        }
    }
}