namespace Italautomata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForroItal f1 = new ForroItal("forrócsoki",150,13);
			Console.WriteLine(f1);
            Tea t1 = new Tea("zöld tea",180,0,true);
			Tea t2 = new Tea("barack tea", 190, 2, false);
			Console.WriteLine(t1);
			Console.WriteLine(t2);


            Kave k1 = new Kave("eszpresszó", 220, 5, "tej nélkül");
			Kave k2 = new Kave("hosszó kávé", 250, 2, "mandula tejjel");
			Kave k3 = new Kave("ristretto", 200, 0, "sok tejjel");
			Console.WriteLine(k1);
			Console.WriteLine(k2);
			Console.WriteLine(k3);
			Console.WriteLine("---------------Áremeés utan---------------------");
			f1.ArEmeles(50);
			t1.ArEmeles(50);
			t2.ArEmeles(45);
			Console.WriteLine(t1);
			Console.WriteLine(f1);
			t1.Aremeles();
			Console.WriteLine(t1);
			t1.Aremeles();
			t2.Aremeles();
			Console.WriteLine(t1);
			Console.WriteLine("----------------Kapucsinó----------------------");
			Cappucino c1 = new Cappucino("mogyorós cappucino",350,4,"sok tejjel",true);
			Console.WriteLine(c1);
			c1.ArEmeles(43);
			Console.WriteLine(c1);
			c1.Aremeles();
			Console.WriteLine(c1);
		}
    }
}
