using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.CONTROLER;

namespace TCS_business.MODEL
{
    public abstract class IPurchasable : Field,IPayable
    {
        Player owner;
        int cost;
        bool pledged;
        public virtual Player Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public int Cost
        {
            get;
            set;
        }
        private int PledgeValue()
        {
            return 200;
        }
        public bool Pledged
        {
            get { return pledged; }
        }
        public IPurchasable(string s)
            : base(s)
        { }
        public void ChangePledged()
        {
            if (pledged == false)
                Owner.Cash += PledgeValue();
            else
                Owner.Cash -= PledgeValue();

            pledged = !pledged;
        }
        public void Buy(Player p)
        {
            Owner = p;
        }


        public override void Action(Player p)
        {
            if (owner == null)
            {
                ApplicationController.Instance.ShowBuyPrompt();
            }
            else if (p != owner)
            {
                if (!pledged)
                {
                    p.GiveCash(owner, Stake);
                    MessageBox.Show("Pobrana opłata w wysokości" + Stake.ToString());
                }
            }

        }

        public int Stake
        {
            get
            {
                return 500;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
