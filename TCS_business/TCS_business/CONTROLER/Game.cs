using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS_business.MODEL;

namespace TCS_business.CONTROLER
{
    public class Game
    {
        private readonly GameConfig gameConfigData;
        internal GameState gameStateData;
        private Board board;

        public Game(GameConfig gameConfig)
        {
            this.gameConfigData = gameConfig;
            this.gameStateData = new GameState();
        }


        public void Start()
        {
            board = Board.GetInstance();
            board.Init(gameStateData);
            loop();
        }

        private void loop()
        {
            while (!IsEnd())
            {
                //???
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
            foreach (Player player in gameStateData.PlayersList)
            {
                if (player.Cash > 0) positive++;
            }
            return positive < 2;
        }

        //todo: Zygmunt 

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
    }
}
