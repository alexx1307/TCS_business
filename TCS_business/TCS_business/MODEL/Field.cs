using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Abstract class representing field on the board.
    /// </summary>
    public abstract class Field
    {
        private string description;
        private string name;

        public string Name { get { return name; } }
        public string Description 
        { 
            get 
            {
                return description;
            } 
            set {} 
        }
        /// <summary>
        /// Construct new field.
        /// </summary>
        /// <param name="s">Description of the field.</param>
        public Field(string s)
        {
            name = s;
            MakeDescription();
        }

        public Field()
        {
        }
        void MakeDescription()
        {
            description = name;
            if (this is IPurchasable)
            {
                description += " " + (this as IPurchasable).Cost;
            }
        }
        public void ChangeDescriptionLabel()
        {
            if (this is IPurchasable)
            {
                description = name + "\n" + (this as IPurchasable).Cost;
            }
        }
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
