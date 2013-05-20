using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author>Anita Ciosek</author>
    /// Class representing country consisting of cities.
    /// </summary>
    class Country
    {
        string name;
        Player owner;
        byte color;
        List<Field> fields;

        /// <summary>
        /// Constructs country with a given name.
        /// </summary>
        /// <param name="s">Name of country</param>
        /// <param name="c">Color of country</param>
        Country(string s, byte c){
            name = s;
            color = c;
        }

        /// <summary>
        /// Adds field to list of fields of this country
        /// </summary>
        /// <param name="f">Field to add</param>
        void Add(Field f)
        {
            fields.Add(f);
        }

        /// <summary>
        /// Set who is the owner of all country
        /// </summary>
        /// <param name="p">Player who has all the fields of this country</param>
        void SetOwner(Player p)
        {
            owner = p;
        }
    }
}
