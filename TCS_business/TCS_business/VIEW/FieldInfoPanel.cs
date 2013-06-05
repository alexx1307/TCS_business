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
    public partial class FieldInfoPanel : UserControl
    {
        MODEL.Field field;
        public FieldInfoPanel()
        {
            InitializeComponent();
        }

        internal void UpdateContent(MODEL.Field field,bool shouldBuyButtonBeSeen)
        {
            this.field = field;
            label1.Text = field.Description;
            if (shouldBuyButtonBeSeen)
                this.button1.Show();
            else
                this.button1.Hide();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (field as MODEL.City).BuildHouse();
            CONTROLER.Game game = CONTROLER.ApplicationController.Instance.game;
            CONTROLER.ApplicationController.Instance.UpdateBoardView(game.Board);
        }
    }
}
