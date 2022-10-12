using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake
{
    internal class Dice
    {
        public Dice()
        {
            Max = 6;
        }

        public int Max { get; set; }

        public int rollDice()
        {
            Random Rnd = new Random();
            return Rnd.Next(Max);
        }
    }

}
