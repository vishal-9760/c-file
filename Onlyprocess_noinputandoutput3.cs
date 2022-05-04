using System;
class Onlyprocess_noinputandoutput3
{
	static string nocomparision(int a,int b,int c)
	{
		string res;
		if(a>b)
			if(a>c)
				res=("a is greater ");
			else 
				res=("c is greater ");
			else if(b>c)
				res=("b is greater");
			else
				res=("c is greater");
			return res;

	}
	public static void Main(string []args)
	{
		int num1;
		Console.Write("enter 1st number");
		num1=int.Parse(Console.ReadLine());
		int num2;
		Console.Write("enter 2nd number ");
		num2=int.Parse(Console.ReadLine());
		int num3;
		Console.Write("ente 3rd number");
		num3=int.Parse(Console.ReadLine());
		Console.Write(nocomparision(num1,num2,num3));
	}
}