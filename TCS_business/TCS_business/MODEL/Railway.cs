using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.CONTROLER;
namespace TCS_business.MODEL
{
    public enum RailwayList //chcialam zeby szlo w takiej kolejnosci jak na planszy, ale wybaczcie nie jestem w stanie okreslic kierunkow
    { //wiec mozna poprawic jak jest zle albo calkiem usunac
        NORTH,
        EAST,
        SOUTH,
        WEST
    }

    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing railway on the board.
    /// </summary>
    public class Railway : IPurchasable, IPayable 
    {

        public Railway(string p):base(p)
        {
        }

        public new int Stake
        {
            get
            {
                Game game = ApplicationController.Instance.Game;
                Board Board = game.Board;
                int owned = 0;
                for (int i = 5; i < 40; i += 10)
                {
                    if ((Board.Fields[i] as IPurchasable).Owner == this.Owner)
                        owned++;
                }
                return 50 * owned;
            }
            set
            {
            }
        }
    }
}
