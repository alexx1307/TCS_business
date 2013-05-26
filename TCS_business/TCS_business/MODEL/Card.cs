using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Abstract class representing card the player pulls the stack. 
    /// </summary>
    public abstract class Card
    {
        /// <summary>
        /// Construct new card.
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Action associated with the card. Must be overrided.
        /// </summary>
        /// <param name="p">Player who pull the card</param>
        public abstract void Action(Player p); 
    }
}
