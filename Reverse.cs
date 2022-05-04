using System;
class Reverse
{
	public static void Main(string[]args)
	{
		int inp;
		inp=int.Parse(Console.ReadLine());
		int rev=0;
		int rem;
		while(inp!=0)
		{
			rem=inp%10;
			rev=rev*10+rem;
			 inp=inp/10;
			
		}
		Console.Write(rev);
	}
}