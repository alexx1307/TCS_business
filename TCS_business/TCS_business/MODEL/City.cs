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
        byte Houses = 0;
        
        public City(String desc):base(desc)
        {
        }
        

        void BuildHouse(){
            //sprawdz czy niezastawione
            //pobierz odpowiednia oplate od gracza
            ++Houses;
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
