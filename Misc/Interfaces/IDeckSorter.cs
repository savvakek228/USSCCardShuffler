
using System.Collections.Generic;
using USSCTestApp.Misc.Classes;

namespace USSCTestApp.Misc.Interfaces
{
    public interface IDeckSorter
    {
        HashSet<Card> ShuffleDeck(HashSet<Card> cards);
    }
}