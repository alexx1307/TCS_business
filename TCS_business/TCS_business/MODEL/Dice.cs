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
        public Dice() { }

        private static readonly Random random = new Random();

        /// <summary>
        /// Simulates a roll of the dice
        /// </summary>
        /// <returns>Number stranded mesh on both dices</returns>
        public Tuple<int, int> Throw()
        {
            return new Tuple<int, int>(
                random.Next(1, 7),
                random.Next(1, 7));
        }
    }
}
