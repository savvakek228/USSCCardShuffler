using System.Collections.Generic;
using USSCCardShuffler.Misc.Classes;

namespace USSCCardShuffler.Misc.Interfaces
{
    public interface IShufflingAlgorithm
    {
        void ShuffleDeck(string name, Dictionary<string,List<Card>> decks);
    }
}