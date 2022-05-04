using System;
class Onlyprocess_noinput_nooutput2
{
	static string even(int a)
	{
		string result;
		if(a%2==0)
			result="even";
		else
			result="odd";
		return result;
	}
	public static void Main(string []args)
	{
		int num;
		Console.Write("Enter any number");
		num=int.Parse(Console.ReadLine());
		Console.Write(even(num));
		
	}
}