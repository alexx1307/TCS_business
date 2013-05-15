using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.MODEL;
using TCS_business.CONTROLER;
namespace TCS_business.VIEW
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Shows the form where player can enter his name and adds him to list of players.
    /// </summary>
    public partial class AddPlayer : Form
    {
        Player resultPlayer;
        public Player ResultPlayer
        {
            get { return resultPlayer; }
        }
        public AddPlayer()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                String s = textBox1.Text;
                this.Close();
                // tu powinien byc jakis limit graczy ustawiony, ze jesli wiecej niz limit to nie dodaje nowego
                this.DialogResult = DialogResult.OK;
                resultPlayer = new TCS_business.MODEL.Player(s, TCSBusinessApplication.GetInstance().game.PlayersNumber);
                MainWindow.NameList[MainWindow.nr++] = s;
            }

        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
