using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author>Anita Ciosek</author>
    /// Situation where player can get some money.
    /// </summary>
    class GetCard : Card
    {
        string description;
        int get;
        public GetCard(string s, int i)
        {
            description = s;
            get = i;
        }

        public override void Action(Player p)
        {
            p.Cash += get;
        }

        /// <summary>
        /// Method used to print the card.
        /// </summary>
        /// <returns>Description of the card</returns>
        public override string ToString()
        {
            return description;
        }
    }
}
