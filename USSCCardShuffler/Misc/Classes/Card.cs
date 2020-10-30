using USSCCardShuffler.Misc.Enums;

namespace USSCCardShuffler.Misc.Classes
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

        /// <summary>
        /// Equals переопределен для корректной работы Assert для ссылочных типов
        /// </summary>
        public override bool Equals(object? obj)
        {
            var toCompare = obj as Card;
            if (toCompare == null)
                return false;
            return Suit == toCompare.Suit & Value == toCompare.Value;
        }
    }
}