using System;
class Find_max_number
{
	public static void Main(string []args)
	{
		int i=0;
		int b=0;
		Console.Write("Enter the number");
		b=int.Parse(Console.ReadLine());
		int num=0;
		int sum=0;
		while(i<b)
		{
			Console.Write("enter the"+i+"number");
			num=int.Parse(Console.ReadLine());
			if(num>sum)
				sum=num;
			i++;
		}
		Console.Write(sum);
	}
}