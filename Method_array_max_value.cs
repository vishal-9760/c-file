using System;
class Method_array_max_value
{
	static int max(int []a)
	{
		int h=a[0];
		int i;
		for( i=0;i<a.Length;i++)
		{
			if(a[i]>h)
			{
				h=a[i];
			}
		}
		return h;
	}
	public static void Main(string []args)
	{
		int []arr={54,4,8,2,45,9,4,85};
		int high=max(arr);
		Console.Write("max value is :"+high);
	}
}