using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS_business.MODEL;
using TCS_business.CONTROLER;
using System.Drawing;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for BoardTest
    /// </summary>
    [TestClass]
    public class BoardTest
    {
        public BoardTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        /// This test checks if the MovePlayer method doesn't move 
        /// player who is currently in jail
        /// </summary>
        [TestMethod]
        public void TestBoardMovePlayerInJail()
        {
            Board board = new Board();
            Game game = new Game();
            Player player = new Player("test", 0, Color.Black, 0, 60);
            game.RegisterNewPlayer(player);
            board.Init(game.GameState);

            player.GoToJail();
            int old = board.Positions[player];

            board.MovePlayer(player, new Random().Next(1, 13));
            Assert.AreEqual(old, board.Positions[player]);

            board.MovePlayer(new Random().Next(Board.NOFIELDS), player);
            Assert.AreEqual(old, board.Positions[player]);
        }

        /// <summary>
        /// This method simply tests if the MovePlayer 
        /// method moves a player
        /// </summary>
        [TestMethod]
        public void TestBoardMovePlayer()
        {
            Board board = new Board();
            Game game = new Game();
            Player player = new Player("test", 0, Color.Black, 0, 60);
            game.RegisterNewPlayer(player);
            board.Init(game.GameState);

            int old = board.Positions[player];
            int r = new Random().Next(1, 13);
            board.MovePlayer(player, r);
            Assert.AreEqual(old + r, board.Positions[player]);

            r = new Random().Next(0, Board.NOFIELDS);
            board.MovePlayer(r, player);
            Assert.AreEqual(r, board.Positions[player]);
        }

        private const int NOITERATIONS = 100000;
        private static readonly Random random = new Random();

        /// <summary>
        /// This test checks whether player gets cash for 
        /// passing through the start
        /// </summary>
        [TestMethod]
        public void TestBoardCashForStart()
        {
            Board board = new Board();
            Game game = new Game();
            int startCash = 0;
            Player player = new Player("test", 0, Color.Black, startCash, 60);
            game.RegisterNewPlayer(player);
            board.Init(game.GameState);

            int sum = 0;
            for (int i = 0; i < NOITERATIONS; ++i)
            {
                int r = random.Next(1, 12);
                board.MovePlayer(player, r);
                sum += r;
            }

            int expectedCash = sum / Board.NOFIELDS * Board.CASHFORSTART;
            Assert.AreEqual(expectedCash, player.Cash);
        }
    }
}
