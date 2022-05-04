using System;
class Min_value_with_array
{
	static int min(int []arr)
	{
		int sum=999999;
		for(int i=0;i<arr.Length;i++)
		{
			if(arr[i]<sum)
				sum=arr[i];
		}
		return sum;
	}
	public static void Main(string[]args)
	{
		int size;
		Console.Write("enter the size of array");
		size=int.Parse(Console.ReadLine());
		int []arr=new int [size];
		Console.WriteLine("enter the value :");
		for(int i=0;i<arr.Length;i++)
		{
			arr[i]=int.Parse(Console.ReadLine());
		}
		Console.Write("minimum value is:");
		Console.Write(min(arr));
	}
}