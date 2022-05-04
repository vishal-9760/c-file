using System;
class And_or
{
	public static void Main(string[] args)
	{
		int a,b,c;
		a=int.Parse(args[0]);
		b=int.Parse(args[1]);
		c=int.Parse(args[2]);
		if(a>b&a>c)
			Console.WriteLine("a is greater ");
		else if(b>a&b>c)
			Console.Write("b is greater");
		else
			Console.Write("c is greater ");
			
	}
}