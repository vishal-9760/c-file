using System;
class Cala
{
public static void Main(string[] args)
	{
	int number1;
	Console.Write("enter the 1st number");
	number1=int.Parse(Console.ReadLine());
	int number2;
	Console.Write("enter the 2nd number ");
	number2=int.Parse(Console.ReadLine());
	char number3;
	Console.Write("enter the opertator");
	number3=char.Parse(Console.ReadLine());
	int result=0;
	if(number3=='+')
	{
		result=number1+number2;
	}
	else if(number3=='-')
	{
		result=number1-number2;
	}
	else if(number3=='/')
	{
		result=number1/number2;
	}
     else if(number3=='%')
	{
		result=number1%number2;
	}
	else if(number3=='*')
	{
		result=number1*number2;
	}
	else
		System.Console.WriteLine("inavlid input");
	
	
	if(result!=0)
	{
		Console.Write("Result is:"+result);
	}
	}
  
}