using System;
class Find_min_value
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
			if(i==0)
				sum=num;
			if(num<sum)
				sum=num;
			i++;
		}
		Console.Write(sum);
	}
}