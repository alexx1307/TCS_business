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
        string Description;

        /// <summary>
        /// Construct new card.
        /// </summary>
        /// <param name="s">Description of the card</param>
        Card(string s)
        {
            Description = s;
        }


        /// <summary>
        /// Method used to print the card.
        /// </summary>
        /// <returns>Description of the card</returns>
        public override String ToString()
        {
            return Description;
        }

        /// <summary>
        /// Action associated with the card. Must be overrided.
        /// </summary>
        /// <param name="p">Player who pull the card</param>
        public abstract void Action(Player p); 
    }
}
