using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS_business.MODEL;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for DiceTest
    /// </summary>
    [TestClass]
    public class DiceTest
    {
        public DiceTest() { }

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
        private const int NOTESTS = 600000;

        /// <summary>
        /// This test checks whether numbers of mashes 
        /// on dices are uniformly distributed
        /// </summary>
        [TestMethod]
        public void TestDiceDistriubtion()
        {
            Dice dice = new Dice();
            int[] firstDice = new int[7];
            int[] secondDice = new int[7];
            int diff = 25000;

            for (int i = 0; i < NOTESTS; ++i)
            {
                Tuple<int, int> meshes = dice.Throw();
                firstDice[meshes.Item1]++;
                secondDice[meshes.Item2]++;
            }

            for (int i = 1; i <= 6; ++i)
            {
                Assert.IsTrue(Math.Abs(firstDice[i] - NOTESTS / 6) < diff);
                Assert.IsTrue(Math.Abs(secondDice[i] - NOTESTS / 6) < diff);
            }
        }

        /// <summary>
        /// This test checks whether the number of mashes 
        /// is in correct range
        /// </summary>
        [TestMethod]
        public void TestDiceRange()
        {
            Dice dice = new Dice();
            for (int i = 0; i < NOTESTS; ++i)
            {
                Tuple<int, int> meshes = dice.Throw();
                int sum = meshes.Item1 + meshes.Item2;
                Assert.IsTrue(sum > 0 && sum <= 12);
            }
        }
    }
}
