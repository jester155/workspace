using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLibrary {
	class Coin {
		//.Publicly used object references
		Random r = new Random(Environment.TickCount);
		
		//.Fields
		bool coin;

		//.Constructor that returns true or false. (Heads or Tails)
		public Coin() {
			if(r.Next(2) == 0)
				this.coin = true;
			else
				this.coin = false;
		}

		//.Reset the coin field if another flip result is needed.
		public bool Coins {
			get { return this.coin; }
			set {
				if(r.Next(2) == 0)
					this.coin = true;
				else
					this.coin = false;
			}
		}
	}
}
