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
            ++Houses;
            Owner.Cash -= houseCost();
        }


        public int Stake
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
