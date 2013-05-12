using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Stores list of players in a game.
    /// </summary>
    class ListOfPlayers
    {
        public static List<Player> list = new List<Player>();
        byte counter = 0;

        /// <summary>
        /// Adds player to the list.
        /// </summary>
        /// <param name="p">Player to add.</param>
        public void Add(Player p)
        {
            p.Id = ++counter;
            list.Add(p);
        }

        /// <summary>
        /// Displays list of player.
        /// </summary>
        public void ShowList()
        {
            new TCS_business.VIEW.ListOfPlayersForm();
        }

    }
}
