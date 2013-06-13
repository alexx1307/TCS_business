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

        List<Player> activePlayers;
        Auction(List<Player> playersList)
        {
            this.activePlayers = playersList;
        }
        /// <summary>
        /// Method simulate an auction
        /// </summary>
        /// <param name="p">active player - This player will get turn after auction</param>
        void StartAuction(Player p, IPurchasable field)
        {    
            Player winner = null;
            int currentPrice = field.Cost;
            GameState gameState = ApplicationController.Instance.Game.GameState;
            Player currentPlayer;
            while(true){
            
                if(activePlayers.Count<1) return;
                while(!activePlayers.Contains( currentPlayer=gameState.NextPlayer())){}

                if(currentPlayer.Cash<currentPrice*MIN_INCREMENT){
                    activePlayers.Remove(currentPlayer);
                    continue;
                }
            int newPrice = ApplicationController.Instance.ShowAuctionDialog(currentPlayer, (int)(currentPrice*MIN_INCREMENT));
            if(newPrice==-1){
                activePlayers.Remove(currentPlayer);
            }else{
                currentPrice = newPrice;
                winner = currentPlayer;
            }
            if(activePlayers.Count==1 && winner!=null){
                ApplicationController.Instance.SendMessage("Player: "+winner+" wins! He pays "+currentPrice+" for "+field);
                field.BuyByAuction(winner,currentPrice);
                return;
            }
            
            }
            gameState.ActivePlayer = p;
        }
    }
}
