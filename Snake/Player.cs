using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	internal class Player
	{

		public Player(String name) {
			Score = 0;
			Name = name;
		}

		public int Score { get; set; }
		public String Name { get; set; }
	}
}
