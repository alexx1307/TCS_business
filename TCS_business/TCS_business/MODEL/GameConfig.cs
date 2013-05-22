using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_business.MODEL
{
    public class GameConfig
    {
        public static readonly int maxPlayersNumber = 8;
        public static readonly TimeSpan maxTurnTime = new TimeSpan(0, 9, 59);        
        public static readonly int defaultStartCash = 1000;
        public static readonly int maxStartCash = 3000;
        public static readonly TimeSpan defaultTurnTime = new TimeSpan(0, 0, 8);
        public static readonly int defaultPlayersNumber = 2;
        private TimeSpan turnTime;
        private int playersNumber;
        private int startCash;
        public TimeSpan TurnTime
        {
            get { return turnTime; }
            private set { if (value == null) { turnTime = defaultTurnTime; } else { turnTime = value; } }
        }
        public int PlayersNumber
        {
            get { return playersNumber; }
            private set { if (value == null) { playersNumber = defaultPlayersNumber; } else { playersNumber = value; } }
        }
        public int StartCash
        {
            get { return startCash; }
            private set { if (value == null) { startCash = defaultStartCash; } else { startCash = value; } }
        }

        public GameConfig(int playersNumber, TimeSpan turnTime, int startCash)
        {
            this.TurnTime = turnTime;
            this.PlayersNumber = playersNumber;
            this.startCash = startCash;
        }
        public GameConfig()
        {
            this.TurnTime = defaultTurnTime;
            this.PlayersNumber = defaultPlayersNumber;
            this.StartCash = defaultStartCash;
        }
    }
}
