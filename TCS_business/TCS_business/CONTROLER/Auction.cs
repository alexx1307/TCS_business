﻿using System;
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

        private void win(Player winner,IPurchasable field, int currentPrice)
        {
            field.BuyByAuction(winner, currentPrice);
          
            ApplicationController.Instance.ShowMessage("Player: " + winner + " wins! He pays " + currentPrice + " for " + field);
            ApplicationController.Instance.UpdatePlayerDataView(winner);
            ApplicationController.Instance.UpdateFieldInfoPanel(field, false, false);
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

                if (activePlayers.Count < 1)
                {
                    if (winner != null)
                    {
                        win(winner,field,currentPrice);
                        break;
                    }
                }
                int count = 0;
                while (!activePlayers.Contains(currentPlayer = gameState.NextPlayer()))
                {
                    if (count++ > 10)
                    {
                        gameState.ActivePlayer = p;
                        return;
                    }
                }
                
                if (currentPlayer.Cash < (int)(currentPrice * MIN_INCREMENT))
                {
                    activePlayers.Remove(currentPlayer);
                    continue;
                }
                if (activePlayers.Count > 1 || (activePlayers.Count == 1 && winner == null))
                {
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
                }
                if (activePlayers.Count == 1 && winner != null)
                {
                    gameState.ActivePlayer = p;
                    win(winner,field,currentPrice);
                    break;
                }
            }
            gameState.ActivePlayer = p;
        }
    }
}
