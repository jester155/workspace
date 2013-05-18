using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monsters;

namespace Mesopotopia {
	class Program {
		static void Main(string[] args) {

			List<Wolf> Wolves = new List<Wolf> {
				new Wolf(25 , 10 , 5 , "Dirty") , 
				new Wolf(20 , 10 , 5 , "Firty") , 
				new Wolf(23 , 10 , 5 , "Mirty")
			};

			Wolves.ForEach(w => Console.WriteLine(w.Name));
			var wolf = new Wolf(35 , 12 , 1 , "wolf");
			wolf.Name = "Shana";
			
			Console.WriteLine("{0} hey it worked {1}" , 
				wolf.Name ,
				wolf.Characteristics
			);
			Console.WriteLine(wolf.Attack);
			Console.ReadKey();
		}
	}
}
