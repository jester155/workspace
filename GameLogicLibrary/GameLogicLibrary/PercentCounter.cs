using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLibrary {
	class PercentCounter {
		//.Publicly used object references
		Random r = new Random(Environment.TickCount);

		//.Gets a percent if needed (acts as a 10 sided die essentially returning "00,10,20,etc."
		int intervalTen;
		int intervalFive;
		int intervalOne;

		public PercentCounter() {
			this.intervalTen = r.Next(1 , 10) * 10;
			this.intervalFive = r.Next(1 , 20) * 5;
			this.intervalFive = r.Next(1 , 100);
		}

		//.Returns percent value 10, 20, 30, 40, etc.
		public int IntervalTen {
			get { return this.intervalTen; }
			set { this.intervalTen = r.Next(11) * 10; }
		}

		//.Return percent value 60, 65, 70, 75, etc.
		public int IntervalFive {
			get { return this.intervalFive; }
			set { this.intervalFive = r.Next(1 , 20) * 5; }
		}

		//.Esentially returns 1-100 for a precise percent. 
		public int InvervalOne {
			get { return this.intervalOne; }
			set { this.intervalOne = r.Next(1 , 100); }
		}
	}
}
