using System;
class Method_array_addition
{
	static int add(int []a)
	{
		int sum=0;
		int i;
		for(i=0;i<5;i++)
		{
		sum=a[i]+sum;
		}
		return sum;
	}
	public static void Main(string []args)
	{
		int []arr={14,543,41,58,78};
			Console.Write(add(arr));
		
		
	}
}