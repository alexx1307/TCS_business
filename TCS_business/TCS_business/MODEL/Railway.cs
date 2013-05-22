using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    public enum RailwayList //chcialam zeby szlo w takiej kolejnosci jak na planszy, ale wybaczcie nie jestem w stanie okreslic kierunkow
    { //wiec mozna poprawic jak jest zle albo calkiem usunac
        NORTH,
        EAST,
        SOUTH,
        WEST
    }

    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing railway on the board.
    /// </summary>
    public class Railway : Field, IPayable, IPurchasable
    {
        Player owner;
        int cost;
        int stake;
        bool pledged;

        public Railway(string p):base(p)
        {
        }

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



        public int Stake //tutaj stawka bedzie zalezna od ilosci posiadanych kolei
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
