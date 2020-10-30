using System.Collections.Generic;
using USSCCardShuffler.Misc.Classes;

namespace USSCCardShuffler.Misc.Interfaces
{
    public interface IDeck
    {
        void AddAndFillDeck(string name);
        
        void ShuffleDeck(string name);

        void DeleteDeck(string name);

        List<string> DisplayDeckNames();

        List<Card> GetCardsByName(string name);
    }
}