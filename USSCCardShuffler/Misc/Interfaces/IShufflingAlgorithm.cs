using System.Collections.Generic;
using USSCCardShuffler.Misc.Classes;

namespace USSCCardShuffler.Misc.Interfaces
{
    /// <summary>
    /// Интерфейс, представляющий алгоритм перетасовки
    /// </summary>
    public interface IShufflingAlgorithm
    {
        /// <summary>
        /// Перетасовать колоду
        /// </summary>
        /// <param name="name">Название колоды</param>
        /// <param name="decks">Словарь колод, из которого берем колоду для перетасовки</param>
        void ShuffleDeck(string name, Dictionary<string,List<Card>> decks);
    }
}