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
    public partial class AddPlayer : Form
    {
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
                TCS_business.MODEL.Player p = new TCS_business.MODEL.Player(s);
                TCS_business.MODEL.ListOfPlayers.list.Add(p);
            }

        }
    }
}
