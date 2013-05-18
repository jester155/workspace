using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesopotopia {
	class Menu {
		private static int input;

		public static void showMenu() {
			Console.WriteLine("1: New Game");
			Console.WriteLine("2: Continue Game");
			Console.WriteLine("3: Exit");

			int.TryParse(Console.ReadLine() , out input);

			if(input > 0 && input < 4) {
				switch(input) {
					case 1:
						Console.WriteLine("Start New Game");
						break;
					case 2:
						Console.WriteLine("Continue From Save");
						break;
					case 3:
						Environment.Exit(0);
						break;
				}
			}
			else {
				MessageBox.Show("Please enter a valid menu option");
			}
		}

		public static void newInput() {
			input = Console.Read();
		}
	}
}
