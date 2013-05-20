using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    interface IPurchasable
    {
        Player Owner
        {
            set;
            get;
        }
        int Cost
        {
            get;
            set;
        }

        void Buy(Player p);
    }
}
