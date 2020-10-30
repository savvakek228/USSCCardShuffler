using System.Collections.Generic;
using USSCTestApp.Misc.Enums;
using USSCTestApp.Misc.Interfaces;

namespace USSCTestApp.Misc.Classes
{
    public class FrenchStandardDeck : IDeck
    {
        private string _name;
        public HashSet<Card> Cards { get; } = new HashSet<Card>();
        
        public FrenchStandardDeck(){}

        public FrenchStandardDeck(string name)
        {
            _name = name;
            Fill();
        }
        
        public void Fill()
        {
            for (var i = Suit.Clubs; i <= Suit.Hearts; i++)
            {
                for (var j = Value.Two; j <= Value.Ace; j++)
                {
                    Cards.Add(new Card(i, j));
                }
            }
        }
    }
}