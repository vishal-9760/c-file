using System;
class Onlyinputandprocess_nooutput_3
{
	static string nocomparision()
	{
		int a,b,c;
		Console.Write("enter the 1st number");
		a=int.Parse(Console.ReadLine());
		Console.Write("enter the second number");
		b=int.Parse(Console.ReadLine());
		Console.Write("enter the third number");
		c=int.Parse(Console.ReadLine());
		string res;
		if(a>b)
			if(a>c)
				res=("a is greater ");
			else 
				res=("c is greater");
			else if(b>c)
				res=("b is greater ");
			else 
			    res=("c is greater");
			return res;
	}
	public static void Main(string []args)
	{
		Console.Write(nocomparision());
	}
}