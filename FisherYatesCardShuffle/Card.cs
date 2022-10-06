using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYatesCardShuffle
{
    public class Card
    {
        private string FaceValue { get; set; }
        private int Value { get; set; }
        private string Suit { get; set; }

        private ConsoleColor Color;

        public Card(string displayValue, string suit, int value)
        {
            FaceValue = displayValue;
            Suit = suit;
            Value = value;
            if (Suit.ToLower() == "diamonds" || Suit.ToLower() == "hearts")
            {
                Color = ConsoleColor.Red;
            }
            else
            {
                Color = ConsoleColor.Black;
            }
        }

        public void DisplayCard()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"{FaceValue} of {Suit}");
        }
        public int GetValue() { return Value; }
        public string GetFaceValue() { return FaceValue; }
        public string GetSuit() { return Suit; }

    }
}
