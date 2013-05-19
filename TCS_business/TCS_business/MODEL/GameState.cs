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
        private List<System.Drawing.Color> coloursList = new List<System.Drawing.Color>();
        private int activePlayer;

        public int ActivePlayer { get { return activePlayer; } set { activePlayer = value; } }
        public int PlayersJoined()
        {
            return playersList.Count;
        }
        public GameState()
        {
            coloursList.Add(System.Drawing.Color.Red);
            coloursList.Add(System.Drawing.Color.Green);
            coloursList.Add(System.Drawing.Color.Blue);
            coloursList.Add(System.Drawing.Color.Yellow);
            coloursList.Add(System.Drawing.Color.Purple);
        }
        public List<Player> PlayersList { get { return playersList; }  }
        public List<System.Drawing.Color> ColoursList { get { return coloursList; } }
    }
}
