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
        ListOfPlayers PlayersList = new ListOfPlayers();
        private readonly GameConfig gameConfigData;

        public Game(GameConfig gameConfig)
        {
            this.gameConfigData = gameConfig;
        }

        public void Start()
        {
            throw new NotImplementedException();
            //todo: Kostek
        }

        //todo: Zygmunt 

        internal bool AllPlayersJoined() //tells whether the needed number of players joined the game 
        {
            
            return PlayersList.counter == gameConfigData.playersNumber;
        }

        /// <summary>
        /// <author> Anita Ciosek </author>
        /// Register player.
        /// </summary>
        internal void registerNewPlayer(Player p)
        {
            PlayersList.Add(p);
        }
    }
}
