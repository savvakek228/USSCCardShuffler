using System;
using SimpleInjector;
using USSCCardShuffler.Misc.Classes;
using USSCCardShuffler.Misc.Implementations;
using USSCCardShuffler.Misc.Interfaces;

namespace USSCCardShuffler
{
    class Program
    {
        private static Container IoCContainer;
        
        /// <summary>
        /// Конфигурация приложения(аналогично Startup в ASP.NET)
        /// Для реализации "конфигурябельности" воспользовался механизмом внедрения зависимости.
        /// IoC-контейнер Simple Injector позволяет нам внедрить зависимость между интерфейсом алгоритма сортировки, и той его реализацией,
        /// которая нам нужна. Для того чтобы сменить алгоритм сортировки, достаточно изменить одну строку в конфигурации.
        /// </summary>
        static void Config()
        {
            IoCContainer = new Container();
            IoCContainer.Register<IShufflingAlgorithm, SimpleDeckShuffler>();
            IoCContainer.Verify();
        }
        
        static void Main(string[] args)
        {
            Config();
            // на место IShufflingAlgorithm подставляется тот, который указан в конфиге.
            Console.WriteLine(IoCContainer.GetInstance<IShufflingAlgorithm>().GetType());
            Console.WriteLine("Для проверки API сортировщика колод, я написал юнит-тесты. Прошу взглянуть.");
        }
    }
}