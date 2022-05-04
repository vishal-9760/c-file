using System;
class Methodipo2
{
	static void add()
	{
		int a,b,c;
		Console.Write("Enter the first number ");
		a=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the second number");
		b=Convert.ToInt32(Console.ReadLine());
		c=a+b;
		Console.Write("result is :"+c);
	}
	public static void Main(string [] args)
	{
		add();
	}
}
