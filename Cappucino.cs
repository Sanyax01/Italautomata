using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
	internal class Cappucino : Kave
	{
		private bool tejszinhab;

		public Cappucino(string nev, int mennyiseg, int cukor, string tej, bool tejszinhab) : base(nev, mennyiseg, cukor, tej)
		{
			this.tejszinhab = tejszinhab;
		}





		public override string ToString()
		{
			return base.ToString()+(this.tejszinhab? " tejszinhabbal, színes cukorszórással":"tejszínhab nélkül");
		}
	}
}
