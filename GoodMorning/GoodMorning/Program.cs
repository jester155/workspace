using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodMorning {
	class Program {

		enum Languages { English = 1 , Italian , Spanish , German , End };
		
		static void Main(string[] args) {

			Console.WriteLine("Pick a language and I will say good morning!");
			for(int i = (int)Languages.English ; i <= (int)Languages.End ; i++)
				Console.WriteLine("{0}: {1}" , i , Enum.GetName(typeof(Languages) , i));

			Menu:
			int choice;
			int.TryParse(Console.ReadLine() , out choice);
			switch(choice) {
				case (int)Languages.English:
					Console.WriteLine("Good Morning!");
					break;

				case (int)Languages.Italian:
					Console.WriteLine("Buongiorno");
					break;

				case (int)Languages.Spanish:
					Console.WriteLine("¡Buenos días");
					break;

				case (int)Languages.German:
					Console.WriteLine("Guten Morgen");
					break;

				case (int)Languages.End:
					goto End;
				default:
					Console.WriteLine("{0} is not a valid option!\nPlease try again.");
					goto Menu;
			}

			End:
			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}
	}
}
