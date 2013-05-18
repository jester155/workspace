using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters {
	public class Creatures {

		string[] element = { "Air" , "Water" , "Earth" , "Fire" , "Shadow" , null };
		public string Element { get; set; }
		public uint Attack { get; set; }
		public uint Defense { get; set;}
		public uint Level { get; set; }
		public Creatures() { }
		
		public Creatures(uint attackDamage , uint defensePoints , uint level) {
			Random r = new Random(Environment.TickCount);
			this.Attack = attackDamage;
			this.Defense = defensePoints;
			this.Level = level;
			this.Element = this.element[r.Next(element.Length)];
		}
	}
}
