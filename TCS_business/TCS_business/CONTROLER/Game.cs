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
        ///  Counts time of each turn
        /// </summary>
        private System.Timers.Timer timer;

        /// <summary>
        ///  Objects needed for synchronization
        /// </summary>
        private static Object endOfTurn = new Object();
        private static Object nextTurn = new Object();

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
            int minutes = gameConfig.PlayerTime;
            int miliseconds = minutes * 60000;
            this.timer = new System.Timers.Timer(1000);
            this.timer.Elapsed += new ElapsedEventHandler(OnTimeoutEvent);
            this.isRunning = true;
            
            gameThread = new Thread(new ThreadStart(this.Loop));
            gameThread.IsBackground = true;
            gameThread.Start();

        }

        /// <summary>
        ///  Loop of the game
        /// </summary>
        private void Loop()
        {
            while (!IsEnd())
            {
                while (gameState.ActivePlayer.InJail)
                {
                    gameState.ActivePlayer.exitJail();
                    gameState.ActivePlayerIndex = (gameState.ActivePlayerIndex + 1) % gameConfig.PlayersNumber;
                }
                ApplicationController.Instance.SendMessage("Tura gracza: " + gameState.ActivePlayer.ToString());
                int meshes = dice.Throw();  // roll of the dice
                int second = dice.Throw2();
                ApplicationController.Instance.RollDice(meshes, second);
                meshes += second;
                Player p = gameState.PlayersList.ElementAt(gameState.ActivePlayerIndex);
                board.MovePlayer(p, meshes);// move player on the board
                ApplicationController.Instance.UpdateBoardView(board);
                board.Fields[board.Positions[p]].Action(p);
                ApplicationController.Instance.UpdateBoardView(board);


                timer.Start();              // begin to countdown
                //MessageBox.Show("a");
                lock (nextTurn)
                {
                    Monitor.PulseAll(nextTurn); // notify all that new round has just begun!
                }
                /*
                    * tu takie male zalozenie: watki graczy gdzies czekaja na waicie na nextTurn 
                    * i sprawdzaja czy activePlayer==ich id, jesli tak to moga grac, wpp.
                    * idzie spac dalej. Z tym, ze to trzeba jeszcze mocno przemyslec i dopracowac
                    * ja troche nie wiem jak to zrobic... :c
                    */
                //MessageBox.Show("b");
                lock (endOfTurn)
                {
                    Monitor.Wait(endOfTurn);    /* wait for the end of the turn */
                }                           /* (i.e. user ended his/her turn or run out of time) */
                //MessageBox.Show("c");
                ApplicationController.Instance.UpdatePlayerDataView(p);
              
                timer.Stop();               // end of the countdown
                gameState.ActivePlayerIndex = (gameState.ActivePlayerIndex + 1) % gameConfig.PlayersNumber;
                // update active player id
            }
            this.isRunning = false;
        }

        /// <summary>
        ///  Event that executes when user has run out of time
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public static void OnTimeoutEvent(object source, ElapsedEventArgs e)
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
                if (player.Cash > 0) positive++;
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
            gameState.PlayersList.Add(p);
        }
        public int NextPlayerId()
        {
            return gameState.PlayersList.Count;
        }
        internal void ResetPlayerList()
        {
            gameState.PlayersList.Clear();
        }

        public int PlayersNumber { get { return ApplicationController.Instance.Game.GameState.PlayersList.Count; } }

        internal void BuyField()
        {
            Player p = GameState.ActivePlayer;
            if (!(board.Fields[board.Positions[p]] is IPurchasable))
                throw new Exception("Cannot buy this field");
            (board.Fields[board.Positions[p]]as IPurchasable).Buy(p);
        }

        internal void Auction()
        {
            //throw new NotImplementedException();
        }
    }
}
