using System;
class Sorting_with_method
{
	static int[] sort(int[]arr)
	{
		int i,j,temp=0;
		for(i=0;i<arr.Length;i++)
		{
			for(j=i+1;j<arr.Length;j++)
			{
				if(arr[i]>arr[j])
				{
					temp=arr[i];
					arr[i]=arr[j];
					arr[j]=temp;
				}
			}
		}
		return arr;
	}	
	public static void Main(string []args)
	{
		
		int []a={20,54,86,95,1,25,31,21,85};
		int []result=sort(a);
		for(int i=0;i<a.Length;i++)
		{
			Console.WriteLine(result[i]);
		}
		
	}
}