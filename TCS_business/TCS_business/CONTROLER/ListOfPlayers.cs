using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.CONTROLER
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Stores list of players in a game.
    /// </summary>
    class ListOfPlayers
    {
        public static List<MODEL.Player> list = new List<MODEL.Player>();
        public byte counter = 0;

        /// <summary>
        /// Adds player to the list. Sets ID of a player.
        /// </summary>
        /// <param name="p">Player to add.</param>
        public void Add(MODEL.Player p)
        {
            p.Id = ++counter;
            list.Add(p);
        }

    }
}
