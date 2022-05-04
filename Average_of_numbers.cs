using System;
class Average_of_numbers
{
	public static void Main(string[]args)
	{
		int a=1;
		int b;
		Console.Write("Enter the number");
		b=int.Parse(Console.ReadLine());
		int c=0;
		int sum=0;
		while(a<=b)
		{ 
	        Console.Write("enter the"+a+"number");
	        c=int.Parse(Console.ReadLine());
		    sum=sum+c;
			a++;
		}
		Console.Write(sum/b);
	}
}