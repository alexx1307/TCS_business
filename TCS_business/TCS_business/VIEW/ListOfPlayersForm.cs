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
            foreach (TCS_business.MODEL.Player p in TCS_business.MODEL.ListOfPlayers.list)
            {
               
                listView1.Items.Add(p.Name);
            }
            
            
        }

    }
}
