using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_business.CONTROLER
{
    public abstract class GameBuilder     // This class should have methods which will expand game class before build (ex. when we add web functionality)
    {
        //todo: Zygmunt
        public static Game build() {  // throws an excpetion when creating game failed
            
            return new Game();
        }

    }
}
