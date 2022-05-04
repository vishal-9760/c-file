using System;
class Methodiop
{
	static void even()
	{
		string result;
		int a;
		Console.Write("Enter the number");
		a=Convert.ToInt32(Console.ReadLine());
		if(a%2==1)
		    result=("no id odd");
		else 
			result=("no is even");
		Console.Write(result);
	}
	public static void  Main(string [] args)
	{
		even();
	}
}