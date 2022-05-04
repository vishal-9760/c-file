using System;
class Arraay
{
	public static void Main(string []args)
	{
		int []arr={78,87,87,89,52};
		int l=arr.Length;
		int i=0;
		while(i<l)
		{
			Console.WriteLine("[{0}] = {1}",i,arr[i]);
			i++;
		}
	}
}