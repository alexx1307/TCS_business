using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing powerhouse on the board.
    /// </summary>
    public class Powerhouse :   IPurchasable,IPayable
    {
        public Powerhouse(string s)
            : base(s)
        { }
        public new int Stake
        {
            get
            {
                CONTROLER.Game game = CONTROLER.ApplicationController.Instance.Game;
                Board Board = game.Board;
                int owned = 0;
                    if ((Board.Fields[12] as IPurchasable).Owner == this.Owner)
                        owned++;
                    if ((Board.Fields[28] as IPurchasable).Owner == this.Owner)
                        owned++;
                return 50 * owned;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
