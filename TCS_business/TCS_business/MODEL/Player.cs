using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.CONTROLER;


namespace TCS_business.MODEL
{   
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Class representing player in a game.
    /// </summary>
    public class Player
    {
        List<Field> fields;
        List<Card> cards;
        private string name;
        private System.Drawing.Color color;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Card> Cards
        {
            get { return cards; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int cash;
        public int Cash
        {
            get { return cash; }
            set { cash = value; }
        }
        private int waited = 0;
        public int Waited
        {
            get { return waited; }
            set { waited = value; }
        }

        private bool inJail = false;
        public bool InJail
        {
            get { return inJail; }
            set { inJail = value; }
        }
        
        /// <summary>
        /// Constructs new Player with the specified name.
        /// It sets default amount of Cash.
        /// </summary>
        /// <param name="s">Name of Player</param>
        public Player(string s, int id, System.Drawing.Color color, int cash)
        {
            this.color = color;
            Name = s;
            Cash = cash;
            Id = id;
            cards = new List<Card>();
        }

        /// <summary>
        /// Transfer specified amount of money to another Player.
        /// </summary>
        /// <param name="other">Who should receive the money</param>
        /// <param name="amount">How much to transfer</param>
        public void GiveCash(Player other, int amount)
        {
            Cash -= amount;
            other.Cash += amount;
        }


        /// <summary>
        /// Takes the player to the jail.
        /// </summary>
        public void GoToJail()
        {
            if (cards.Count > 0) cards.RemoveAt(0);
            else inJail = true; 
        }

        /// <summary>
        /// Takes the player out of jail.
        /// </summary>
        public void exitJail()
        {
            inJail = false;
        }

        public override String ToString()
        {
            return name;
        }
        public System.Drawing.Color Color { get { return color; } set { color = value; } }
    }
}
