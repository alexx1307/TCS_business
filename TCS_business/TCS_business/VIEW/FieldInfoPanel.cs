using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.MODEL;

namespace TCS_business.VIEW
{
    public partial class FieldInfoPanel : UserControl
    {
        MODEL.Field field;
        public FieldInfoPanel()
        {
            InitializeComponent();
        }

        internal void UpdateContent(MODEL.Field field, bool shouldBuyButtonBeSeen, bool shouldPledgeButtonBeSeen)
        {
            this.field = field;
            label1.Text = field.Description + "\n";
            if (this.field is MODEL.IPurchasable)
            {
                label2.Text = "Stakes:\n";
                if (this.field is MODEL.City)
                {
                    label2.Text += "without house: " + (this.field as MODEL.City).BasicStake.ToString() + "\n";
                    label2.Text += "with 1 house: " + ((this.field as MODEL.City).Stake + ((this.field as MODEL.City).Cost*3)/4).ToString() + "\n";
                    label2.Text += "with 2 houses: " + ((this.field as MODEL.City).Stake + ((this.field as MODEL.City).Cost*6)/4).ToString() + "\n";
                    label2.Text += "with 3 houses: " + ((this.field as MODEL.City).Stake + ((this.field as MODEL.City).Cost * 9) / 4).ToString() + "\n";
                    label2.Text += "with 4 houses: " + ((this.field as MODEL.City).Stake + 3 * (this.field as MODEL.City).Cost).ToString() + "\n";
                }
                else if (this.field is MODEL.Powerhouse)
                {
                    label2.Text += "when 1 owned: 50\n";
                    label2.Text += "when 2 owned: 100\n";
                }
                else  if (this.field is MODEL.Railway)
                {
                    label2.Text += "when 1 owned: 50\n";
                    label2.Text += "when 2 owned: 100\n";
                    label2.Text += "when 3 owned: 150\n";
                    label2.Text += "when 4 owned: 200\n";
                }

            }
            else if (this.field is MODEL.Chance)
            {
                label2.Text = "You'll draw\n cards here";
            }
            else if (this.field is MODEL.StartField)
            {
                label2.Text = "For passing through\nthis field you'll get 200";
            }
            else if (this.field is MODEL.Tax)
            {
                label2.Text = "For staying on\nthis field you'll \nhave to pay "+(field as MODEL.Tax).Stake;
            }
            else if (this.field is MODEL.FreeParking)
            {
                label2.Text = "Stay here and\n take a rest";
            }else{
                label2.Text = "";
            }
            

            if (field is MODEL.IPurchasable)
            {
                if (shouldBuyButtonBeSeen)
                {
                    this.button1.Show();
                }
                else
                {
                    this.button1.Hide();
                }
                if (shouldPledgeButtonBeSeen)
                {
                    this.button2.Show();
                }
                else
                {
                    this.button2.Hide();
                }
                if (field is IPurchasable)
                {
                    if ((field as IPurchasable).Owner == CONTROLER.ApplicationController.Instance.Game.GameState.ActivePlayer)
                    {
                        sellFieldButton.Visible = true;
                        
                    }
                    else
                    {
                       
                        sellFieldButton.Hide();
                    }
                }

                if ((field as MODEL.IPurchasable).Pledged == true)
                {
                    this.button2.Text = "Unpledge";
                }
                else
                {
                    this.button2.Text = "Pledge";
                }
            }
            else
            {
                this.button1.Hide();
                this.button2.Hide();
            }
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (field as MODEL.City).BuildHouse();
            CONTROLER.Game game = CONTROLER.ApplicationController.Instance.Game;
            CONTROLER.ApplicationController.Instance.UpdateBoardView(game.Board);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (field as MODEL.IPurchasable).ChangePledged();
            this.UpdateContent(field, false, true);
            CONTROLER.Game game = CONTROLER.ApplicationController.Instance.Game;
            CONTROLER.ApplicationController.Instance.UpdatePlayerDataView((field as MODEL.IPurchasable).Owner);
            CONTROLER.ApplicationController.Instance.UpdateBoardView(game.Board);
            if(game.Board.Fields[game.Board.Positions[game.GameState.ActivePlayer]] is MODEL.IPurchasable)
            {
                if(game.GameState.ActivePlayer.Cash > (game.Board.Fields[game.Board.Positions[game.GameState.ActivePlayer]] as MODEL.IPurchasable).Cost)
                    CONTROLER.ApplicationController.Instance.EnableBuyButton();
            }
        }

        private void sellFieldButton_Click(object sender, EventArgs e)
        {
            CONTROLER.ApplicationController.Instance.AuctionField(this.field);
        }
    }
}
