using System;
class No_of_even_and_odd
{
	public static void Main(string []args)
	{
			int i=0;
			int num=0;
			int num1=0;
			int even=0,odd=0;
			Console.Write("enter the number:");
			num=int.Parse(Console.ReadLine());
			Console.WriteLine("enter the values:");
			while(i<num)
			{
				num1=int.Parse(Console.ReadLine());
				if(num1%2==0)
					even++;
				else 
					odd++;
				i++;
			}
			Console.WriteLine("even number are:"+" "+even);
			Console.Write("even number are:"+" "+odd);
	}
}
    