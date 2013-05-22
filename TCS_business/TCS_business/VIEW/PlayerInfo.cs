using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCS_business.VIEW
{
    public partial class PlayerInfo : UserControl
    {
        public PlayerInfo(String name, int Cash, System.Drawing.Color colour)
        {
            InitializeComponent();
            this.label1.Text = name;
            this.cashLabel.Text = Cash.ToString();
            this.pictureBox1.BackColor = colour;
        }

        private void PlayerInfo_Load(object sender, EventArgs e)
        {

        }

        internal void Update(MODEL.Player player)
        {
            this.Invoke((MethodInvoker)delegate { cashLabel.Text = player.Cash.ToString(); });
          
        }
    }
}
