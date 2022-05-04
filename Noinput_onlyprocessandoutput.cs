using System;
class Noinput_onlyprocessandoutput
{
	static void add(int a,int b)
	{
		int result =a+b;
		Console.Write("Result is:"+result);
		
	}
	public static void Main(string []args)
	{
		int num1,num2;
		Console.Write("First number");
		num1 =Convert.ToInt32(Console.ReadLine());
		Console.Write("Second num");
		num2=Convert.ToInt32(Console.ReadLine());
		add(num1,num2);
	}
}