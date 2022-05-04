using System;
class Searching
{
	public static void Main(string []args)
	{
		int []arr={1,45,85,65,124,5,65,84};
		Console.WriteLine("Enter The Value :");
		int value=int.Parse(Console.ReadLine());
		int i=0;
		bool x=false;
		while(i<arr.Length)
		{
			if(arr[i]==value)
		{			
		x=true;
			Console.WriteLine("found");
			break;
		}
			i++;
		}
		if(x==false)
			Console.Write("notfound");
	}
}