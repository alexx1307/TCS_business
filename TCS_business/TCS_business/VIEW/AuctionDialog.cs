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
    public partial class AuctionDialog : Form
    {
        int offer = -1;
        public int Result
        {
            get
            {
                return offer;
            }
        }
        public AuctionDialog(string playerName,Color color, string fieldName, int minStake, int maxStake)
        {
            InitializeComponent();
            this.Location = new Point(200,200); 
            numericUpDown1.Minimum = minStake;
            numericUpDown1.Maximum = maxStake;
            numericUpDown1.Value=minStake;
            label2.Text = playerName;
            label1.Text = "If you want to buy field " + fieldName + ", make an offer with minimum stake of " + minStake + ",\nor pass if you don't want to spend money";
        }

        private void passButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bidButton_Click(object sender, EventArgs e)
        {
            offer = (int)numericUpDown1.Value;
            this.Close();

        }
    }
}
