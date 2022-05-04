using System;
class Onlyprocess_noinput_nooutput
{
	static int add(int a,int b)
	{
		
		int c=a+b;
		return c;
	}
	public static void Main(string []args)
	{
		int firstnum;
		Console.Write("Enter the first number");
		firstnum=Convert.ToInt32(Console.ReadLine());
		int secondnum;
		Console.Write("Enter the first number");
		secondnum=Convert.ToInt32(Console.ReadLine());
		int result=firstnum+secondnum;
		Console.Write("result is:"+result);
		add(firstnum,secondnum);
	}
}