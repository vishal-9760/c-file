using System;
class Countable
{
	public static void Main(string []args)
	{
		int a;
		int i=0;
		a=int.Parse(Console.ReadLine());
		while(a!=0)
		{
			a=a/10;
			i++;
		}
		Console.Write(i);
	}
}