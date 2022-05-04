using System;
class Simpleintrest
{
	public static void Main(string []args)
	{
		int si;
		int p;
		p=int.Parse(args[0]);
		int r;
		r=int.Parse(args[1]);
		int t;
		t=int.Parse(args[2]);
		si=(p*r*t)/100;
		Console.Write(si);
	}
}