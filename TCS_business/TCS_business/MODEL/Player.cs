using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.CONTROLER;


namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Class representing player in a game.
    /// </summary>
    public class Player
    {
        List<Card> cards;
        private string name;
        private System.Drawing.Color color;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Card> Cards
        {
            get { return cards; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int cash;
        public int Cash
        {
            get { return cash; }
            set { cash = value; }
        }
        private int waited = 0;
        public int Waited
        {
            get { return waited; }
            set { waited = value; }
        }

        private bool inJail = false;
        public bool InJail
        {
            get { return inJail; }
            set { inJail = value; }
        }

        private Timer timer;

        /// <summary>
        /// Boolean indicating whether it's this player turn
        /// </summary>
        private bool active = false;
        public bool Active { set { active = value; } get { return active; } }

        /// <summary>
        /// Time for a game, in seconds
        /// </summary>
        private int time;
        public TimeSpan Time
        {
            set { time = value.Seconds + value.Minutes * 60; }
            get { return new TimeSpan(0, time / 60, time % 60); }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (active)
            {
                time--;
                if (time == 0) ApplicationController.Instance.Game.End();
                ApplicationController.Instance.UpdatePlayerDataView(this);
            }
        }

        /// <summary>
        /// Constructs new Player with the specified name.
        /// It sets default amount of Cash.
        /// </summary>
        /// <param name="s">Name of Player</param>
        /// <param name="time">Time for player in minutes</param>
        public Player(string s, int id, System.Drawing.Color color, int cash, int time)
        {
            this.color = color;
            Name = s;
            Cash = cash;
            Id = id;
            cards = new List<Card>();
            this.time = time * 60;
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        /// <summary>
        /// Transfer specified amount of money to another Player.
        /// </summary>
        /// <param name="other">Who should receive the money</param>
        /// <param name="amount">How much to transfer</param>
        public void GiveCash(Player other, int amount)
        {
            Cash -= amount;
            other.Cash += amount;
        }


        /// <summary>
        /// Takes the player to the jail.
        /// </summary>
        public void GoToJail()
        {
            if (cards.Count > 0) cards.RemoveAt(0);
            else inJail = true;
        }

        /// <summary>
        /// Takes the player out of jail.
        /// </summary>
        public void exitJail()
        {
            inJail = false;
        }

        public override String ToString()
        {
            return name;
        }
        public System.Drawing.Color Color { get { return color; } set { color = value; } }
    }
}
