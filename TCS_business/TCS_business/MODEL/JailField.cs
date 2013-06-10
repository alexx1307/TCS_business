using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    class JailField:Field
    {
        public JailField(string description) 
            : base(description)
        {}
        public override void Action(Player p)
        {
            CONTROLER.ApplicationController.Instance.Game.Board.MovePlayer(10, p);
            if (p.InJail)
            {
                //todo: poprawic
                if (p.Waited == 1) //czekał już jedną kolejkę, teraz czeka drugą i w następnym ruchu może iść
                {
                    p.InJail = false;
                    p.Waited = 0;
                    return;
                }
                else
                {
                    p.Waited++;
                }
            }
            else //gracz jest tylko odwiedzającym
            {
                return;
            }
        }
    }
}
