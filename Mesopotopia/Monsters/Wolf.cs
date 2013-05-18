using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
	public class Wolf : Creatures {

		public string Name { get; set; }
		public string Characteristics { get; set; }
		private string[] attribute = { "Dark" , "Light" };
		private string[] color = { "Brown" , "Black" , "Gray"};
		private static Random r = new Random(Environment.TickCount);
		
		public Wolf() {	
			this.Characteristics = (this.attribute[r.Next(this.attribute.Length)] + " " + this.color[r.Next(this.color.Length)]);
		}
		
		public Wolf(uint attackDamage , uint defensePoints , uint level , string name) : base(attackDamage , defensePoints , level) {
			this.Name = name;
			this.Characteristics = (this.attribute[r.Next(this.attribute.Length)] + " " + this.color[r.Next(this.color.Length)]);
		}
	}
}