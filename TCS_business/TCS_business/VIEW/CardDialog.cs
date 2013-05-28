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
    public partial class CardDialog : Form
    {
        public CardDialog(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
