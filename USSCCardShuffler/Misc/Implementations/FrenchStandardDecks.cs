using System.Collections.Generic;
using System.Linq;
using USSCCardShuffler.Misc.Classes;
using USSCCardShuffler.Misc.Enums;
using USSCCardShuffler.Misc.Interfaces;

namespace USSCCardShuffler.Misc.Implementations
{
    public class FrenchStandardDecks : IDecks
    {
        public Dictionary<string, List<Card>> Decks { get; } = new Dictionary<string, List<Card>>();

        ///<inheritdoc/>
        public void AddAndFillDeck(string name)
        {
            var resCards = new List<Card>();
            for (var i = Suit.Clubs; i <= Suit.Hearts; i++)
            {
                for (var j = Value.Two; j <= Value.Ace; j++)
                {
                    resCards.Add(new Card(i, j));
                }
            }
            Decks.Add(name, resCards);
        }

        ///<inheritdoc/>
        public void DeleteDeck(string name)
        {
            Decks.Remove(name);
        }

        ///<inheritdoc/>
        public List<string> DisplayDeckNames()
        {
            return Decks.Keys.ToList();
        }

        ///<inheritdoc/>
        public List<Card> GetCardsByName(string name)
        {
            return Decks.FirstOrDefault(x => x.Key == name).Value;
        }
    }
}