﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.CONTROLER;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing bank in a game.
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// Get loan pledging a field.
        /// </summary>
        /// <param name="p">Player who wants to receive the loan.</param>
        /// <param name="c">City to pledge.</param>
        void GetLoan(Player p, City c)
        {
            c.ChangePledged();
            //daj graczowi za to jakies pieniadze
        }

        void Repurchase(Player p, City c)
        {
            c.ChangePledged();
            //pobierz od gracza jakies pieniadze
        }

        /// <summary>
        /// Pay tax to the bank.
        /// </summary>
        /// <param name="p">Player who pays.</param>
        /// <param name="amount">Amount of money to pay.</param>
        public void Pay(Player p, int amount)
        {
            p.Cash -= amount;
        }
    }
}
