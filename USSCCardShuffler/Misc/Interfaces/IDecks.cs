using System.Collections.Generic;
using USSCCardShuffler.Misc.Classes;

namespace USSCCardShuffler.Misc.Interfaces
{
    /// <summary>
    /// Интерфейс, представляющий операции над колодами
    /// </summary>
    public interface IDecks
    {
        /// <summary>
        /// Добавление и заполнение колоды.
        /// </summary>
        /// <param name="name">Название колоды</param>
        void AddAndFillDeck(string name);

        /// <summary>
        /// Удаление колоды.
        /// </summary>
        /// <param name="name">Название колоды</param>
        void DeleteDeck(string name);

        /// <summary>
        /// Вывести список названий колод
        /// </summary>
        /// <returns>Список названий колод</returns>
        List<string> DisplayDeckNames();

        /// <summary>
        /// Получить список карт по названию колоды
        /// </summary>
        /// <param name="name">Название колоды</param>
        /// <returns>Список карт в колоде с указанным названием</returns>
        List<Card> GetCardsByName(string name);
    }
}