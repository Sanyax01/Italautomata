using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
	internal class Kave : ForroItal
	{
		private string tej;

		public Kave(string nev, int mennyiseg, int cukor, string tej) : base(nev, mennyiseg, cukor)
		{
			this.tej = tej;
		}

		public string Tej { get => tej; set => tej = value; }

		public override void Aremeles()
		{
			this.ar = (int)(this.ar + this.ar * 0.20);
		}

		public override string ToString()
		{
			return base.ToString() + $"{this.tej}";
		}
	}
}
