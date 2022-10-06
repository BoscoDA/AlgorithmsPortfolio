using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;

namespace FisherYatesCardShuffle
{
    public class Deck
    {
        public Card[] cards = new Card[52];
        public int Count => cards.Length;

        private enum Suits
        {
            Spades,
            Diamonds,
            Clovers,
            Hearts
        }

        private enum Values
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,

        }
        public Deck()
        {
            cards = Build();
        }

        public void Shuffle()
        {
            cards.DoFisherYatesShuffle();

        }

        private Card[] Build()
        {
            Card[] temp = new Card[52];
            int cardCount = 0;
            for (int j = 0; j < 4; j++)
            {
                Suits Suit = (Suits)j;
                
                for (int k = 1; k <= 13; k++)
                {
                    Values Value = (Values)k;
                    temp[cardCount] = (new Card(Value.ToString(), Suit.ToString(), (int)Value));
                    cardCount++;
                }
            }
            return temp;
        }
    }
}
