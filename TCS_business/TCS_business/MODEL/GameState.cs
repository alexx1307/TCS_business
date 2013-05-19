using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_business.MODEL
{
    public class GameState
    {
        private List<Player> playersList = new List<Player>();
        private int activePlayer;

        public int ActivePlayer { get { return activePlayer; } set { activePlayer = value; } }
        public int PlayersJoined()
        {
            return playersList.Count;
        }
        public GameState()
        {
        }
        public List<Player> PlayersList { get { return playersList; }  }
    }
}
