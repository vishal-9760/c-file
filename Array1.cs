using System;
class Array1
{
	public static void Main(string []args)
	{
		int num=0;
		num=int.Parse(Console.ReadLine());
		int []arr=new int[num];
		
		int i;
		Console.WriteLine("enter the value in array :");
		for(i=0;i<5;i++)
		{
			arr[i]=int.Parse(Console.ReadLine());
			
		}
		for(i=0;i<5;i++)
		{
			Console.WriteLine("[{0}] {1}",i,arr[i]);
		}
		
	}
}	