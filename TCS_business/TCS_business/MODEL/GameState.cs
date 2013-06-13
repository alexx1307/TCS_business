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
        private List<Player> playersInGame = new List<Player>();
        private int activePlayerIndex;
        public int ActivePlayerIndex { get { return activePlayerIndex; } set { activePlayerIndex = value; } }
        public Player ActivePlayer
        {
            get { return playersInGame[ActivePlayerIndex]; }
        }
        public int PlayersLeft
        {
            get { return playersInGame.Count; }
        }
        private Dice dice = new Dice();
        public Dice Dice { get { return dice; } }
        public int PlayersJoined()
        {
            return playersList.Count;
        }

        public List<Player> PlayersList { get { return playersInGame; }  }


        internal int NextPlayer()
        {
            activePlayerIndex = (activePlayerIndex + 1) % PlayersLeft;
            return activePlayerIndex;
        }
        void removeLoser(Player p)
        {
            playersInGame.Remove(p);
        }

        internal void AddPlayer(Player p)
        {
            playersList.Add(p);
            playersInGame.Add(p);
        }
    }
}
