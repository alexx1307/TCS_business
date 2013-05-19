using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.CONTROLER;


namespace TCS_business.MODEL
{   

    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Class representing player in a game.
    /// </summary>
    public class Player
    {
        List<Field> fields;
        //List<Card> cards;
        private string name;
        private System.Windows.Forms.Panel playersPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox colourBox;

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        private bool inJail = false;
        public bool InJail
        {
            get { return inJail; }
            set { inJail = value; }
        }
        public System.Windows.Forms.Panel PlayersPanel
        {
            get { return playersPanel; }
            set { playersPanel = value; }
        }
        /// <summary>
        /// Constructs new Player with the specified name.
        /// It sets default amount of Cash.
        /// </summary>
        /// <param name="s">Name of Player</param>
        public Player(string s, int id,System.Drawing.Color playersColour)
        {
            Name = s;
            Cash = GameConfig.defaultStartCash;
            Id = id;
            nameLabel = new System.Windows.Forms.Label();
            nameLabel.Text = Name;
            cashLabel = new System.Windows.Forms.Label();
            cashLabel.Text = Cash.ToString();
            colourBox = new System.Windows.Forms.PictureBox();
            colourBox.BackColor = playersColour;
            timeLabel = new System.Windows.Forms.Label();
            playersPanel = new System.Windows.Forms.Panel();
            playersPanel.Size = new System.Drawing.Size(201, 74);
            playersPanel.Controls.Add(colourBox);
            playersPanel.Controls.Add(nameLabel);
            playersPanel.Controls.Add(cashLabel);
            playersPanel.Controls.Add(timeLabel);
        }

        /// <summary>
        /// Transfer specified amount of money to another Player.
        /// </summary>
        /// <param name="other">Who should receive the money</param>
        /// <param name="amount">How much to transfer</param>
        void GiveCash(Player other, int amount)
        {
            Cash -= amount;
            other.Cash += amount;
        }


        /// <summary>
        /// Takes the player to the jail.
        /// </summary>
        void goToJail()
        {
            // jesli posiada karte ze nie idzie do wiezienia to nie idzie i usuwa karte
            inJail = true;
        }

        /// <summary>
        /// Takes the player out of jail.
        /// </summary>
        void exitJail()
        {
            inJail = false;
        }
    }
}
