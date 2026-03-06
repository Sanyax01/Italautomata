using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
	internal class ForroItal
	{
		protected string nev;
		protected int ar;
		protected int cukor;

		public ForroItal(string nev, int mennyiseg, int cukor)
		{
			this.nev = nev;
			this.ar = mennyiseg;
			this.cukor = cukor;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Ar { get => ar; set => ar = value; }
		public int Cukor { get => cukor; set => cukor = value; }


		public void ArEmeles(int osszeg)
		{
			this.ar += osszeg;
		}

		public virtual void Aremeles()
		{
			this.ar += (int)(this.ar*0.2);
		}

		public override string ToString()
		{
			return $"{this.nev} {this.cukor} cukorral {this.ar} ft ";
		}
	}
}
