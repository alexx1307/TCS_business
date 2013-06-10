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
                return 100;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
