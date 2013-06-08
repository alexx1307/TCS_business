using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_business.MODEL
{
    /// <summary>
    /// This class holds information about configuration of a game
    /// </summary>
    public class GameConfig
    {
        #region default values
        public const int defaultStartCash = 1000;

        /// <summary>
        /// default time for a player for a game (in minutes)
        /// </summary>
        public const int defaultPlayerTime = 10;
        public const int defaultPlayersNumber = 2;
        #endregion

        #region constraints
        public const int maxPlayersNumber = 4;
        public const int minPlayersNumber = 2;
        public const int maxPlayerTime = 20;
        public const int minPlayerTime = 2;
        public const int maxStartCash = 3000;
        public const int minStartCash = 500;
        #endregion

        /// <summary>
        /// time for a player for a game (in minutes)
        /// </summary>
        private int playerTime;
        private int playersNumber;
        private int startCash;

        #region getters, setters
        public int PlayerTime { get { return playerTime; } }
        public int PlayersNumber { get { return playersNumber; } }
        public int StartCash { get { return startCash; } }
        #endregion

        /// <summary>
        /// Constructs a new GameConfig instance from given values
        /// </summary>
        /// <param name="playersNumber">Number of players</param>
        /// <param name="playerTime">Time for a player for a game in minutes</param>
        /// <param name="startCash">The initial capital</param>
        public GameConfig(int playersNumber, int playerTime, int startCash)
        {
            this.playerTime = playerTime;
            this.playersNumber = playersNumber;
            this.startCash = startCash;
        }

        /// <summary>
        /// Constructs a new GameConfig instance from defaults values
        /// </summary>
        public GameConfig()
        {
            playerTime = defaultPlayerTime;
            playersNumber = defaultPlayersNumber;
            startCash = defaultStartCash;
        }
    }
}
