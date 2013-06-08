using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.CONTROLER;

namespace TCS_business.MODEL
{
    public abstract class IPurchasable : Field, IPayable
    {
        Player owner;
        int cost = 100; // todo: zmienic
        bool pledged;
        public virtual Player Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
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
            p.Cash -= cost;
            ApplicationController.Instance.DisableBuyButton();
            ApplicationController.Instance.UpdateBoardView(ApplicationController.Instance.Game.Board);
        }


        public override void Action(Player p)
        {
            if (owner == null && p.Cash >= cost) ApplicationController.Instance.EnableBuyButton();
            else ApplicationController.Instance.DisableBuyButton();
            if (owner != null && p != owner && !pledged)
            {
                p.GiveCash(owner, Stake);
                ApplicationController.Instance.ShowPayInfo("Charged at " + Stake.ToString());
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
