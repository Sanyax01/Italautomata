namespace Italautomata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForroItal f1 = new ForroItal("forrócsoki",150,13);
			Console.WriteLine(f1);
            Tea t1 = new Tea("zöld tea",180,0,true);
            Console.WriteLine(t1);
			Console.WriteLine(t1.Nev);
        }
    }
}
