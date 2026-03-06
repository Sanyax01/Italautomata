using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
	internal class Tea : ForroItal
	{
		private bool citrommal;
		//base(nev,ar,cukor): meghivja az ősosztalyt konstruktorát és átadom az adattagjait és az új adattagot itt inicializálom(cak az újjat)
		public Tea(string nev, int mennyiseg, int cukor, bool citrommal) : base(nev, mennyiseg, cukor)
		{
			this.citrommal = citrommal;
		}

		public bool Citrommal { get => citrommal; set => citrommal = value; }

		public override void Aremeles()
		{
			this.ar = (int)(this.ar + this.ar * 0.15);
		}  
	

		public override string ToString()
		{
			return base.ToString() + (this.citrommal? "citrommal" : "citrom nélkül");
		}
	}
}
