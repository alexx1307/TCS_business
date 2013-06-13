using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace TCS_business.MODEL
{
    /// <summary>
    /// <author>Anita Ciosek</author>
    /// Class representing country consisting of cities.
    /// </summary>
    public class Country
    {
        string name;
        //Player owner;
        System.Drawing.Color color;
        List<Field> fields;
        public System.Drawing.Color Color
        {
            get { return color; }
        }

        public List<Field> Fields
        {
            get { return fields; } 
        }

        /// <summary>
        /// Constructs country with a given name.
        /// </summary>
        /// <param name="s">Name of country</param>
        /// <param name="c">Color of country</param>
        public Country(string s, System.Drawing.Color color){
            name = s;
            this.color = color;
            fields = new List<Field>();
        }

        /// <summary>
        /// Adds field to list of fields of this country
        /// </summary>
        /// <param name="f">Field to add</param>
        public void Add(Field f)
        {
            fields.Add(f);
        }

        ///// <summary>
        ///// Set who is the owner of all country
        ///// </summary>
        ///// <param name="p">Player who has all the fields of this country</param>
        //void SetOwner(Player p)
        //{
        //    owner = p;
        //}
    }
}
