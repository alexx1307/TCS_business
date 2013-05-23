using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public int Stake
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
