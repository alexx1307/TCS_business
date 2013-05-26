﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author>Anita Ciosek</author>
    /// Situation where player must go to jail.
    /// </summary>
    class GoToJailCard : Card
    {
        string description;
        public GoToJailCard()
        {
            description = "Go to jail";
        }

        public override void Action(Player p)
        {
            p.GoToJail();
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