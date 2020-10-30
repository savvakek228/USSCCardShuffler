using System;
using System.Collections.Generic;
using NUnit.Framework;
using SimpleInjector;
using USSCCardShuffler.Misc.Classes;
using USSCCardShuffler.Misc.Enums;
using USSCCardShuffler.Misc.Implementations;
using USSCCardShuffler.Misc.Interfaces;

namespace USSCCardShufflerUnitTests
{
    [TestFixture]
    public class SimpleShufflingAPITests
    {
        private FrenchStandardDecks _decks = new FrenchStandardDecks();
        private readonly Container DIContainer = new Container();
        
        [SetUp]
        public void InitializeFixture()
        {
            _decks.AddAndFillDeck("Deck 1");
            _decks.AddAndFillDeck("Deck 2");
        }

        [Test]
        public void AddingTest()
        {
            Assert.IsTrue(_decks.Decks.ContainsKey("Deck 1") & _decks.Decks.ContainsKey("Deck 2"));
            var resCards = new List<Card>();
            for (var i = Suit.Clubs; i <= Suit.Hearts; i++)
            {
                for (var j = Value.Two; j <= Value.Ace; j++)
                {
                    resCards.Add(new Card(i, j));
                }
            }
            
            Assert.AreEqual(resCards,_decks.Decks["Deck 1"]);
            Assert.AreEqual(resCards,_decks.Decks["Deck 2"]);
        }
        
        [Test]
        public void RemovingTest()
        {
            _decks.DeleteDeck("Deck 1");
            Assert.IsFalse(_decks.Decks.ContainsKey("Deck 1"));
        }

        [Test]
        public void DisplayingTest()
        {
            var names = _decks.DisplayDeckNames();
            Assert.AreEqual(names, _decks.Decks.Keys);
        }

        [Test]
        public void GettingCardByNameTest()
        {
            var cards = _decks.GetCardsByName("Deck 1");
            Assert.AreEqual(cards,_decks.Decks["Deck 1"]);
        }

        [Test]
        public void SimpleShufflingTest()
        {
            var initialDeck = _decks.Decks["Deck 1"];
            DIContainer.Register<IShufflingAlgorithm,SimpleDeckShuffler>();
            DIContainer.Verify();
            DIContainer.GetInstance<IShufflingAlgorithm>().ShuffleDeck("Deck 1", _decks.Decks);
            Assert.AreNotEqual(_decks.Decks["Deck 1"],initialDeck);
        }

        [TearDown]
        public void OnFixtureTearDown()
        {
            _decks.Decks.Clear();
        }
        
    }
}