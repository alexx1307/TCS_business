using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.CONTROLER;
namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing city on the board.
    /// </summary>
    public class City : IPurchasable,IPayable 
    {
        Country country;
        byte Houses = 0;
        
        public Country Country{
            get { return country; }
        }
        public City(String desc,Country country):base(desc)
        {
            this.country = country;
            country.Add(this);
        }

        int houseCost()
        {
            return this.Cost / 2;
        }
        public void BuildHouse(){
            //sprawdz czy niezastawione
            //pobierz odpowiednia oplate od gracza
            if (Houses == 4)
            {
                MessageBox.Show("You cannot buy more houses in this city.");
                return;
            }
            if (Owner.Cash < this.Cost)
            {
                MessageBox.Show("You don't have enough cash to buy a house");
                return;
            }
            ++Houses;
            Owner.Cash -= houseCost();
        }


        public int Stake
        {
            get
            {
                int val = (int)(Cost / 15);
                if (val <= 8)
                {
                    val = 8;
                }
                else if (val <= 12)
                {
                    val = 12;
                }
                else if (val <= 18)
                {
                    val = 18;
                }
                else if (val <= 22)
                {
                    val = 25;
                }
                else if (val <= 30)
                {
                    val = 30;
                }
                else if (val <= 40)
                {
                    val = 40;
                }
                else
                {
                    val = 50;
                }
                int added = 0;
                added = (int)((Cost * 3) / 4) * Houses;
                return val + added;
            }
            set
            {
            }
        }
    }
}
