﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    class StartField : Field
    {
        public StartField(string description, int position)
            : base(description, position)
        { }
        public override void Action(Player p)
        {
        }
    }
}
