using System;
class Soorting
{
	public static void Main(string[]args)
	{
		int []arr={1,2,35,78,90,1,4};
		int temp=0;
		int i=0;
		while(i<arr.Length)
		{
			int j=i+1;
			while(j<arr.Length)
			{
				if(arr[i]>arr[j])
					{
					temp=arr[i];
					arr[i]=arr[j];
					arr[j]=temp;
					}
				j++;
			}
			Console.WriteLine(arr[i]);
			i++;
		}
	}
}