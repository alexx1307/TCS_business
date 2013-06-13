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
            set { 
                Player ap = ActivePlayer;
                for (int i = 0; i <= PlayersLeft; i++) //zabezpieczenie przed zapetleniem
                {
                    if (ActivePlayer != value)
                        NextPlayer();
                }
            }
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


        internal Player NextPlayer()
        {
            if (PlayersLeft == 0)
            {
                //TODO 
                return ActivePlayer;
            }
            activePlayerIndex = (activePlayerIndex + 1) % PlayersLeft;
            return ActivePlayer;
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
