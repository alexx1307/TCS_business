using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_business.MODEL
{
    class GameState
    {
        public ConcurrentBag<Player> PlayersList = new ConcurrentBag<Player>();
        public int activePlayer;
    }
}
