using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.MODEL;

namespace TCS_business.CONTROLER
{
    public class Auction
    {
        const double MIN_INCREMENT=1.1;

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
            GameState gameState = ApplicationController.Instance.Game.GameState;
            Player currentPlayer = gameState.NextPlayer();

            int newPrice = CONTROLER.ApplicationController.Instance.ShowAuctionDialog(currentPlayer, (int)(currentPrice*MIN_INCREMENT));
            if(newPrice==-1){
                playersList.Remove(currentPlayer);
            }else{

            }

            gameState.ActivePlayer = p;
        }
    }
}
