using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    class ListOfPlayers
    {
        public static List<Player> list = new List<Player>();
        byte counter = 0;

        public void Add(Player p)
        {
            p.Id = ++counter;
            list.Add(p);
        }

        public void ShowList()
        {
            new TCS_business.VIEW.ListOfPlayersForm();
        }

    }
}
