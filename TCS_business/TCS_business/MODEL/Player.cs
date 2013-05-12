using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Class representing player in a game.
    /// </summary>

    public class Player
    {
        //List<Field> fields;
        //List<Card> cards;
        public string Name;
        public byte Id;
        public int Cash;
        Boolean inJail = false;

        /// <summary>
        /// Constructs new Player with the specified name.
        /// It sets default amount of Cash.
        /// </summary>
        /// <param name="s">Name of Player</param>
        public Player(string s)
        {
            Name = s;
            Cash = 1000;
        }

        /// <summary>
        /// Transfer specified amount of money to another Player.
        /// </summary>
        /// <param name="other">Who should receive the money</param>
        /// <param name="amount">How much to transfer</param>
        void GiveCash(Player other, int amount)
        {
            Cash -= amount;
            other.Cash += amount;
        }


        /// <summary>
        /// Takes the player to the jail.
        /// </summary>
        void goToJail()
        {
            // jesli posiada karte ze nie idzie do wiezienia to nie idzie i usuwa karte
            inJail = true;
        }

        /// <summary>
        /// Takes the player out of jail.
        /// </summary>
        void exitJail()
        {
            inJail = false;
        }
    }
}
