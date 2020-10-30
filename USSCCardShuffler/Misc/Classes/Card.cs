using USSCTestApp.Misc.Enums;

namespace USSCTestApp.Misc.Classes
{
    public class Card
    {
        public Suit Suit { get; }
        public Value Value { get;}

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
    }
}