using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_business.CONTROLER
{
    public class GameConfig
    {
        public static readonly int maxPlayersNumber = 8;
        public static readonly TimeSpan maxTurnTime = new TimeSpan(0, 10, 0);
        TimeSpan turnTime;
        public int playersNumber;
        public TimeSpan TurnTime
        {
            get { return turnTime; }
        }
        public int PlayersNumber
        {
            get { return playersNumber; }
        }

        internal GameConfig(int playersNumber, TimeSpan turnTime)
        {
            this.turnTime = turnTime;
            this.playersNumber = playersNumber;
        }
    }

    public class GameConfigBuilder
    {
        TimeSpan turnTime;
        int playersNumber;

        public GameConfigBuilder()
        {
            turnTime = new TimeSpan(0, 0, 3);
            playersNumber = 2;
        }
        public GameConfig build()
        {
            return new GameConfig(playersNumber, turnTime);
        }
        public GameConfigBuilder setTurnTime(TimeSpan time)
        {

            turnTime = time;
            return this;
        }
        public GameConfigBuilder setRemainingPlayersNumber(int number)
        {
            playersNumber = number;
            return this;
        }

    }

}
