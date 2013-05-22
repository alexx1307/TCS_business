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
            this.board = new Board();
            this.isRunning = false;
        }


        /// <summary>
        ///  Surprisingly, this function starts the game
        /// </summary>
        public void Start()
        {
            board.Init(gameState);
            int seconds = gameConfig.TurnTime.Seconds;
            int minutes = gameConfig.TurnTime.Minutes;
            int miliseconds = seconds * 1000 + minutes * 60000;
            this.timer = new System.Timers.Timer(miliseconds);
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
                int meshes = dice.Throw();  // roll of the dice
                Player p = gameState.PlayersList.ElementAt(gameState.ActivePlayer);
                board.MovePlayer(p, meshes);// move player on the board
                ApplicationController.Instance.UpdateBoardView(board);
                ApplicationController.Instance.UpdatePlayerDataView(p);
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
                timer.Stop();               // end of the countdown
                gameState.ActivePlayer = (gameState.ActivePlayer + 1) % gameConfig.PlayersNumber;
                // update active player id
                MessageBox.Show(gameState.ActivePlayer.ToString());
                //TCSBusinessApplication.getInstance().GuiManager.UpdatePlayerListPanel();
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


        public int PlayersNumber { get; set; }

    }
}
