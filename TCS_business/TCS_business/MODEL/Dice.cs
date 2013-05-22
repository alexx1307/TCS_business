using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Class representing dice and symulate dice throwing
    /// </summary>
    public class Dice
    {
        public Dice(){}

        /// <summary>
        /// Simulates a roll of the dice
        /// </summary>
        /// <returns>Number stranded mesh</returns>
        public int Throw()
        {
            return new Random().Next(1, 6);
        }

        /// <summary>
        /// Simulates a roll of the dice
        /// </summary>
        /// <returns>Number stranded mesh</returns>
        public int Throw2()
        {
            return new Random().Next(0, 120) % 6 + 1;
        }
    }
}
