using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// Class representing Jail field on the board
    /// </summary>
    class JailField : Field
    {
        /// <summary>
        /// Dict of players that are in jail, if value is <c>true</c> player should leave jail, 
        /// otherwise he or she must wait additional one turn
        /// </summary>
        private readonly Dictionary<Player, bool> players = new Dictionary<Player, bool>();

        public JailField(string d) : base(d) { }

        /// <summary>
        /// Checks whether players is only a vistor, if not tests whether he can go out 
        /// from jail or not
        /// </summary>
        /// <param name="p">Player who's on the jail field</param>
        public override void Action(Player p)
        {
            if (!p.InJail) return;

            if (players.ContainsKey(p)) // player has already waited one turn
            {
                if (players[p])
                {
                    players.Remove(p);
                    p.exitJail();
                }
                else players[p] = true;
            }
            else players.Add(p, false);
        }
    }
}
