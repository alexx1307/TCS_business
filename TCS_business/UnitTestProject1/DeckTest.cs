using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS_business.MODEL;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for DeckTest
    /// </summary>
    [TestClass]
    public class DeckTest
    {
        public DeckTest() { }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// Number of test cases
        /// </summary>
        private const int NOTESTS = 500000;

        /// <summary>
        /// This test checks whether each card appears only once
        /// </summary>
        [TestMethod]
        public void TestDeckCardAppearsOnlyOnce()
        {
            for (int i = 0; i < NOTESTS; ++i)
            {
                Deck deck = new Deck();
                HashSet<Card> appeard = new HashSet<Card>();
                for (int j = 0; j < Deck.NOCARDS; ++j)
                {
                    Card c = deck.NextCard();
                    Assert.IsFalse(appeard.Contains(c));
                    appeard.Add(c);
                }
            }
        }

        /// <summary>
        /// This test checks whether for a second time
        /// the deck has a different order
        /// </summary>
        [TestMethod]
        public void TestDeckDifferentOrder()
        {
            Deck deck = new Deck();
            Card[] order = new Card[Deck.NOCARDS];

            for (int i = 0; i < Deck.NOCARDS; ++i)
                order[i] = deck.NextCard();

            for (int i = 0; i < Deck.NOCARDS; ++i)
                if (order[i] != deck.NextCard()) return;

            Assert.Fail();
        }

        /// <summary>
        /// This test checks whether a card appears on each position
        /// with the same probability
        /// </summary>
        [TestMethod]
        public void TestDeckDistribution()
        {
            Deck deck = new Deck();
            Card card = deck.NextCard(); // draw one card

            deck = new Deck();
            int[] counter = new int[Deck.NOCARDS];
            int diff = 30000;

            for (int i = 0; i < NOTESTS; ++i)
                for (int j = 0; j < Deck.NOCARDS; ++j)
                    if (deck.NextCard() == card) counter[j]++;

            for (int i = 0; i < Deck.NOCARDS; ++i)
                Assert.IsTrue(Math.Abs(counter[i] - NOTESTS / Deck.NOCARDS) < diff);
        }
    }
}
