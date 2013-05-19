using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Abstract class representing field on the board.
    /// </summary>
    public abstract class Field
    {
        string Description;

        /// <summary>
        /// Construct new field.
        /// </summary>
        /// <param name="s">Description of the field.</param>
        public Field(string s)
        {
            Description = s;
        }

        public Field()
        { }

        /// <summary>
        /// Method used to print the field.
        /// </summary>
        /// <returns>Description of the field.</returns>
        public override String ToString()
        {
            return Description;
        }

        /// <summary>
        /// Action associated with the field. Must be overrided.
        /// </summary>
        /// <param name="p">Player standing on the field.</param>
        public abstract void Action(Player p); 
    }
}
