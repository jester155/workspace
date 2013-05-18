using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
	class DeclaredCars
	{
		public static Cars defaultCar = new Cars();
		public static Cars marksCar = new Cars("Chevy", "Cavalier", "Black", 2003);
		public static Cars shannonsCar = new Cars("Hyundai", "Sonata", "Gray", 2012);
		public static Cars shanasCar = new Cars("Chevy", "Cobalt", "White", 2008);
	}
}
