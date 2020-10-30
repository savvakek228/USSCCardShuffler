using System;
using System.Collections.Generic;
using System.Linq;
using USSCTestApp.Misc.Classes;
using USSCTestApp.Misc.Interfaces;

namespace USSCTestApp.Misc.Implementations
{
    public class SimpleDeckSorter : IDeckSorter
    {
        public HashSet<Card> ShuffleDeck(HashSet<Card> cards)
        {
            var random = new Random();
            return cards.OrderBy(c => random.NextDouble()).ToHashSet();
        }
    }
}