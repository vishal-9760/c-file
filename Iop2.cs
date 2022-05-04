using System;
class Iop2
{
	static void nocomparision()
	{
		int a,b,c;
		Console.Write("enter 1st number");
		a=int.Parse(Console.ReadLine());
		Console.Write("enter 2nd number");
		b=int.Parse(Console.ReadLine());
		Console.Write("enter 3rd number");
		c=int.Parse(Console.ReadLine());
	
		if(a>b)
		if(a>c)
		Console.Write("a is greater");
		else 
			Console.Write("c is greater");
		 if(b>c)
			Console.Write("b is greater");
		else
			Console.Write("c is greater ");
		
	}
	public static void Main(string []args)
	{
		nocomparision();
	}
}