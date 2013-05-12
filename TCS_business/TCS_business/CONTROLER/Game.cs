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
            
            //porownanie ilosci zarejestrowanych graczy z wartoscia z gameConfig.playersNumber
            return false; //prowizoryczna wartosc zeby uruchomic program
        }

        /// <summary>
        /// <author> Anita Ciosek </author>
        /// </summary>
        internal void registerNewPlayer()
        {
            new VIEW.AddPlayer();
        }
    }
}
