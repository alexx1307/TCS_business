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
        private GameConfig gameConfigData;
        private GameState gameStateData;
        private Board board;
        private Dice dice;
        private bool isRunning;


        public int PlayersNumber { 
            get { return gameStateData.PlayersList.Count; } 
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

        public Game(GameConfig gameConfig)
        {
            this.gameConfigData = gameConfig;
            this.gameStateData = new GameState();
            this.dice = new Dice();
            this.board = Board.GetInstance();
        }

        /// <summary>
        ///  Surprisingly, this function starts the game
        /// </summary>
        public void Start()
        {

            board.Init(gameStateData);
            int seconds = gameConfigData.TurnTime.Seconds;
            int minutes = gameConfigData.TurnTime.Minutes;
            int miliseconds = seconds * 1000 + minutes * 60000;
            this.timer = new System.Timers.Timer(miliseconds);
            this.timer.Elapsed += new ElapsedEventHandler(OnTimeoutEvent);
            this.isRunning = true;
            Loop();
            this.isRunning = false;
        }

        /// <summary>
        ///  Loop of the game
        /// </summary>
        private void Loop()
        {
            while (!IsEnd())
            {
                int meshes = dice.Throw();  // roll of the dice
                Player p = gameStateData.PlayersList[gameStateData.activePlayer];
                board.MovePlayer(p, meshes);// move player on the board
                timer.Start();              // begin to countdown
                Monitor.PulseAll(nextTurn); // notify all that new round has just begun!
                /*
                 * tu takie male zalozenie: watki graczy gdzies czekaja na waicie na nextTurn 
                 * i sprawdzaja czy activePlayer==ich id, jesli tak to moga grac, wpp.
                 * idzie spac dalej. Z tym, ze to trzeba jeszcze mocno przemyslec i dopracowac
                 * ja troche nie wiem jak to zrobic... :c
                 */
                Monitor.Wait(endOfTurn);    /* wait for the end of the turn 
                                             * (i.e. user ended his/her turn or run out of time) */
                timer.Stop();               // end of the countdown
                gameStateData.activePlayer += 1 % gameConfigData.playersNumber;
                // update active player id
            }
        }

        /// <summary>
        ///  Event that executes when user has run out of time
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private static void OnTimeoutEvent(object source, ElapsedEventArgs e)
        {
            Monitor.Pulse(endOfTurn); // notify that time is over...
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
            foreach (Player player in gameStateData.PlayersList)
            {
                if (player.Cash > 0) positive++;
            }
            return positive < 2;
        }


        internal bool AllPlayersJoined() //tells whether the needed number of players joined the game 
        {
            return gameStateData.PlayersList.Count() == gameConfigData.playersNumber;
        }

        /// <summary>
        /// <author> Anita Ciosek </author>
        /// Register player.
        /// </summary>
        internal void registerNewPlayer(Player p)
        {
            gameStateData.PlayersList.Add(p);
        }
        internal void resetPlayerList()
        {
            gameStateData.PlayersList.Clear();
        }
        public void setGameConfigData(GameConfig gameConfigData)
        {
            if (isRunning)
                throw new InvalidOperationException("Cannot change game config during execution");
            this.gameConfigData = gameConfigData;


        }


    }
}
