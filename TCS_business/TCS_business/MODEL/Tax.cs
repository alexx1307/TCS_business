using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing ring field and paid parking on the board.
    /// </summary>
    public class Tax : Field, IPayable
    {
        int stake;

        public override void Action(Player p)
        {
              //pobieranie oplaty od gracza 
        }



        public int Stake
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
    }
}
