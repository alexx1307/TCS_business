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

        private Dice dice = new Dice();
        public Dice Dice { get { return dice; } }
        public int PlayersJoined()
        {
            return playersList.Count;
        }

        public List<Player> PlayersList { get { return playersList; }  }
        
    }
}
