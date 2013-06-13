using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using TCS_business.MODEL;
using System.Windows.Forms;

namespace TCS_business.CONTROLER
{
    public class Game
    {
        private GameConfig gameConfig;
        private GameState gameState;
        private Board board;
        private Dice dice;
        private bool isRunning;
        private Thread gameThread;
        public GameState GameState
        {
            get { return gameState; }
        }
        public Board Board
        {
            get { return board; }
        }

        public GameConfig GameConfig
        {
            get { return gameConfig; }
            set
            {
                if (isRunning) throw new InvalidOperationException("It's impossible to change game properties during game");
                gameConfig = value;
            }
        }

        /// <summary>
        ///  Objects needed for synchronization
        /// </summary>
        private static Object endOfTurn = new Object();

        public Game()
        {
            this.gameConfig = new GameConfig();
            this.gameState = new GameState();
            this.dice = new Dice();
            this.isRunning = false;
        }


        /// <summary>
        ///  Surprisingly, this function starts the game
        /// </summary>
        public void Start()
        {
            this.board = BoardGenerator.Generate();
            board.Init(gameState);
            ApplicationController.Instance.InitializeGamePanel(board);
            this.isRunning = true;
            ApplicationController.Instance.DisableGameSettings();
            gameThread = new Thread(new ThreadStart(this.Loop));
            gameThread.IsBackground = true;
            gameThread.Start();
        }

        public void End()
        {
            Player player = null;
            foreach (Player p in gameState.PlayersList)
                if (player == null ||
                    player.Time == new TimeSpan(0, 0, 0) ||
                    (p.Time > new TimeSpan(0, 0, 0) && p.Cash > player.Cash)) player = p;
            MessageBox.Show("The winner is " + player.ToString());
            ApplicationController.Exit();
        }

        /// <summary>
        ///  Loop of the game
        /// </summary>
        private void Loop()
        {
            ApplicationController.Instance.UpdateBoardView(board);
            while (!IsEnd())
            {
                while (gameState.ActivePlayer.InJail)
                {
                    gameState.ActivePlayer.exitJail();
                    gameState.NextPlayer();
                }
                ApplicationController.Instance.SendMessage("Turn of player: " + gameState.ActivePlayer.ToString());
                ApplicationController.Instance.ShowTurnPrompt(gameState.ActivePlayer.ToString());
                Tuple<int, int> meshes = dice.Throw();
                ApplicationController.Instance.RollDice(meshes);
                Player p = gameState.ActivePlayer;
                board.MovePlayer(p, meshes.Item1 + meshes.Item2); // move player on the board
                ApplicationController.Instance.UpdateBoardView(board);
                ApplicationController.Instance.DisableBuyButton();
                board.Fields[board.Positions[p]].Action(p);
                ApplicationController.Instance.UpdatePlayerDataView(p);
                ApplicationController.Instance.UpdateBoardView(board);
                if (p.Cash < 0) End();
                p.Active = true;
                lock (endOfTurn) Monitor.Wait(endOfTurn);
                p.Active = false;
                Field activeField = board.PlayerPosition(gameState.ActivePlayer);
                if (activeField is IPurchasable && (activeField as IPurchasable).Owner == null)
                {
                    Auction auction = new Auction(gameState.PlayersList);
                    auction.StartAuction(gameState.ActivePlayer, activeField as IPurchasable);
                }
                ApplicationController.Instance.UpdatePlayerDataView(p);
                gameState.NextPlayer();
                ApplicationController.Instance.HideFieldInfoPanel();
                // update active player id
            }
            this.isRunning = false;
            End();
        }

        /// <summary>
        ///  Event that executes when user has run out of time
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public static void TurnEndEvent(object source, ElapsedEventArgs e)
        {
            lock (endOfTurn)
            {
                Monitor.Pulse(endOfTurn); // notify that time is over...
            }
        }

        /// <summary>
        ///  Simple function which checks whether there is in the game 
        ///  two or more players with positive amount of money
        /// </summary>
        /// <returns>
        ///  <c>true</c> if there is two or more such players, 
        ///  <c>false</c> otherwise
        /// </returns>
        private bool IsEnd()
        {
            int positive = 0;
            foreach (Player player in gameState.PlayersList)
            {
                if (player.Cash >= 0) positive++;
            }
            return positive < 2;
        }


        internal bool AllPlayersJoined() //tells whether the needed number of players joined the game 
        {
            return gameState.PlayersList.Count() == gameConfig.PlayersNumber;
        }

        /// <summary>
        /// <author> Anita Ciosek </author>
        /// Register player.
        /// </summary>
        public void RegisterNewPlayer(Player p)
        {
            gameState.AddPlayer(p);
        }
        public int NextPlayerId()
        {
            return gameState.PlayersList.Count;
        }
        internal void ResetPlayerList()
        {
            gameState.PlayersList.Clear();
        }

        public int PlayersNumber { get { return gameState.PlayersList.Count; } }

        internal void BuyField()
        {
            Player p = GameState.ActivePlayer;
            if (!(board.Fields[board.Positions[p]] is IPurchasable))
                throw new Exception("Cannot buy this field");
            (board.Fields[board.Positions[p]] as IPurchasable).Buy(p);
        }
    }
}
