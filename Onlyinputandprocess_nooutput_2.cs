using System;
class Onlyinputandprocess_nooutput_2
{
	static string even()
	{
		int a;
		Console.Write("Enter any number");
		a=Convert.ToInt32(Console.ReadLine());
		string result;
		if(a%2==1)
			result =("odd");
		else
			result =("even");
		return result;
	}
	public static void Main(string []args)
	{
		string num=even();
		Console.Write("result is :"+num);
	}
}