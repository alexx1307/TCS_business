using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing question mark field on the board.
    /// </summary>
    class Chance : Field
    {
        public Chance(string p):base(p)
        {
        }
        public override void Action(Player p) {
            //pociagnij karte i wykonaj dla niej akcje
        } 

    }
}
