using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    class Auction
    {
        List<Player> playersList;
        Auction(List<Player> playersList)
        {
            this.playersList = playersList;
        }
        /// <summary>
        /// Method simulate an auction
        /// </summary>
        /// <param name="p">active player - This player will get turn after auction</param>
        void StartAuction(Player p, IPurchasable field)
        {
            int currentPrice = field.Cost;
            GameState gameState = CONTROLER.ApplicationController.Instance.Game.GameState;
            Player currentPlayer = gameState.NextPlayer();




            gameState.ActivePlayer = p;
        }
    }
}
