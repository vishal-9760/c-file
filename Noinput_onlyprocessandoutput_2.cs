using System;
class Noinput_onlyprocessandoutput_2
{
	static void even(int a)
	{
		string result;
		if(a%2==0)
			result=("even");
		else
			result=("odd");
		Console.Write("result is"+result);
	}
	public static void Main(string []args)
	{
		int num;
		Console.Write("enter any number");
		num=Convert.ToInt32(Console.ReadLine());
		even(num);
	}
}