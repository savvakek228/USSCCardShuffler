using System;
using System.Collections.Generic;
using System.Linq;
using USSCCardShuffler.Misc.Interfaces;

namespace USSCCardShuffler.Misc.Classes
{
    public class SimpleDeckShuffler : IShufflingAlgorithm
    {
        public void ShuffleDeck(string name, Dictionary<string,List<Card>> decks)
        {
            var rnd = new Random();
            if (!(decks.ContainsKey(name)))
            {
                Console.WriteLine("No such deck");
                return;
            }

            decks[name] = decks[name].OrderBy(x => rnd.Next()).ToList();
        }
    }
}