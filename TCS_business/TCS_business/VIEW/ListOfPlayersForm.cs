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
    public partial class ListOfPlayersForm : Form
    {
        public ListOfPlayersForm()
        {
            InitializeComponent();
            foreach(Player p in ListOfPlayers.list) {
               
                listView1.Items.Add(p.Name);
            }
            
            
        }

    }
}
