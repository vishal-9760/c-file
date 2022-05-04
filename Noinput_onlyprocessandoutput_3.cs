using System;
class Noinput_onlyprocessandoutput_3
{
	static void nocomparision(int a,int b,int c)
	{
		if(a>b)
			if(a>c)
				Console.Write("a is greater");
			else
				Console.Write("c is greater");
			else if(b>c)
				Console.Write("b is greater");
			else 
				Console.Write("c is greater");
	}
	public static void Main(string[]args)
	{
		int num1;
		Console.Write("enter the 1st number");
		num1=int.Parse(Console.ReadLine());
		int num2;
		Console.Write("enter the second number");
		num2=int.Parse(Console.ReadLine());
		int num3;
		Console.Write("enter the third number");
		num3=int.Parse(Console.ReadLine());
		nocomparision(num1,num2,num3);
	}
}