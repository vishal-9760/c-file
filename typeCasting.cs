using System;
class typecasting
{
	public static void Main(string [] args)
	{
		double a;
		System.Console.WriteLine("enter the number");
		a=Convert.ToDouble(Console.ReadLine());
		char b=(char)a;
		System.Console.WriteLine(b);
	}
}