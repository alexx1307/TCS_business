using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCS_business.VIEW
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Class to show info about players in a game.
    /// </summary>
    public partial class ListOfPlayersForm : Form
    {
        public ListOfPlayersForm()
        {
            InitializeComponent();
            foreach (TCS_business.MODEL.Player p in CONTROLER.ListOfPlayers.list)
            {
                listView1.Items.Add(p.Name); //for now it is only name to show
            }
            
            
        }

    }
}
