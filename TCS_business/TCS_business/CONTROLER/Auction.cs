using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.MODEL;

namespace TCS_business.CONTROLER
{
    public class Auction
    {
        const double MIN_INCREMENT = 1.1;

        List<Player> activePlayers;
        public Auction(List<Player> playersList)
        {
            this.activePlayers = new List<Player>( playersList);
        }
        /// <summary>
        /// Method simulate an auction
        /// </summary>
        /// <param name="p">active player - This player will get turn after auction</param>
        public void StartAuction(Player p, IPurchasable field)
        {
            Player winner = null;
            int currentPrice = field.Cost;
            GameState gameState = ApplicationController.Instance.Game.GameState;
            activePlayers.Remove(p);
            Player currentPlayer;
            while (true)
            {

                if (activePlayers.Count < 1) break;
                while (!activePlayers.Contains(currentPlayer = gameState.NextPlayer())) { }

                if (currentPlayer.Cash < currentPrice * MIN_INCREMENT)
                {
                    activePlayers.Remove(currentPlayer);
                    continue;
                }
                int newPrice = ApplicationController.Instance.ShowAuctionDialog(currentPlayer, field, (int)(currentPrice * MIN_INCREMENT));
                if (newPrice == -1)
                {
                    activePlayers.Remove(currentPlayer);
                }
                else
                {
                    currentPrice = newPrice;
                    winner = currentPlayer;
                }
                if (activePlayers.Count == 1 && winner != null)
                {
                    field.BuyByAuction(winner, currentPrice);
                    gameState.ActivePlayer = p;
                    ApplicationController.Instance.ShowMessage("Player: " + winner + " wins! He pays " + currentPrice + " for " + field);
                    ApplicationController.Instance.UpdatePlayerDataView(winner);
                    ApplicationController.Instance.UpdateFieldInfoPanel(field, false, false);
                    break;
                }
            }
            gameState.ActivePlayer = p;
        }
    }
}
