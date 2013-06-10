using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.CONTROLER;

namespace TCS_business.MODEL
{
    /// <summary>
    /// This class reprezents Policeman field on the board
    /// </summary>
    class PolicemanField : Field
    {
        public PolicemanField(String d) : base(d) { }

        /// <summary>
        /// Change player's information about being in jail and 
        /// moves him to the Jail field on the board
        /// </summary>
        /// <param name="p">Player who goes to jail</param>
        public override void Action(Player p)
        {
            if (p.Cards.Count > 0)
            {
                ApplicationController.Instance.ShowInformation(
                    "You were close going to jail, but happily you had the " +
                    "\"Go out from jail card\"");
                p.Cards.RemoveAt(0);
            }
            else
            {
                ApplicationController.Instance.Game.Board.MovePlayer(10, p);
                p.GoToJail();
                ApplicationController.Instance.ShowInformation("You go to jail!");
            }
        }
    }
}
