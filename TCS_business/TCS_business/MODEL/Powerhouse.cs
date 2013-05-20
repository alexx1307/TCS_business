using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing powerhouse on the board.
    /// </summary>
    public class Powerhouse : Field, IPayable, IPurchasable
    {
        Player owner;
        int cost;
        int stake;
        bool pledged;

        public void ChangePledged()
        {
            pledged = !pledged;
        }

        public override void Action(Player p)
        {
            if (p != owner)
            { //jak jest wlascicielem to nic nie robi
                //pobieranie oplaty od gracza 
            }
        }

        public int Stake //tu trzeba dorobic obliczanie stawki
        {
            get
            {
                return stake;
            }
            set
            {
                stake = value;
            }
        }

        Player IPurchasable.Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        int IPurchasable.Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        /// <summary>
        /// Buy this field.
        /// </summary>
        /// <param name="p">Player who is new owner</param>
        void IPurchasable.Buy(Player p)
        {
            owner = p;
        }
    }
}
