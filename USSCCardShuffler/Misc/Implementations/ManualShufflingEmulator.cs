﻿using System;
using System.Collections.Generic;
using System.Linq;
using USSCCardShuffler.Misc.Classes;
using USSCCardShuffler.Misc.Interfaces;

namespace USSCCardShuffler.Misc.Implementations
{
    /// <summary>
    /// Эмуляция перетасовки вручную
    /// </summary>
    public class ManualShufflingEmulator : IShufflingAlgorithm
    {
        ///<inheritdoc/>
        public void ShuffleDeck(string name, Dictionary<string, List<Card>> decks)
        {
            if (!(decks.ContainsKey(name)))
            {
                Console.WriteLine("No such deck");
                return;
            }

            var temp = new List<Card>();
            var counter = 0;
            do
            {
                for (var i = decks[name].Count / 2; i < decks[name].Count; i++)
                {
                    temp.Append(decks[name][i]);
                }

                for (var i = 0; i < decks[name].Count / 2; i++)
                {
                    temp.Append(decks[name][i]);
                }

                counter++;
            } while (counter != 3);
            
            decks[name] = temp;
        }
    }
}