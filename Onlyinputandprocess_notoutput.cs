using System;
class Onlyinputandprocess_notoutput
{
	static int add()
	{
		int a,b;
		Console.Write("Enter first number");
		a=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the second number");
		b=Convert.ToInt32(Console.ReadLine());
		int result=a+b;
		return result;
	}
	static void Main(string [] args)
	{
		int num =add();
		Console.Write(num);
		
	}
	
	
}