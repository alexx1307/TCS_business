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
        internal private GameState gameStateData;
        public Game(GameConfig gameConfig)
        {
            this.gameConfigData = gameConfig;
            this.gameStateData = new GameState();
        }

        public void Start()
        {
            throw new NotImplementedException();
            //todo: Kostek
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
