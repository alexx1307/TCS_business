using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_business.CONTROLER
{
    public abstract class GameBuilder
    {
        //todo: Zygmunt
        public static Game build() {  // throws an excpetion when fails to create a game
            
            return new Game();
        }

    }
}
