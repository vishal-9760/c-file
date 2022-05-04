using System;
class Even_odd_with_array_with_forloop
{
	public static void Main(string []args)
	{
		int []arr={12,53,63,1,57,48,35};
		int even=0,odd=0;
		int e=0,o=0;
		int i=0;
		while(i<arr.Length)
		{
			if(arr[i]%2==0)
				even++;
			else 
				odd++;
			i++;
		}
			int []evenarr=new int [even];
			int []oddarr=new int [odd];
			i=0;
			while(i<arr.Length)
			{
				if(arr[i]%2==0)
				{
					evenarr[e]=arr[i];
						e++;
				}
					else 
					{
						oddarr[o]=arr[i];
							o++;
				    }
				i++;
			}
				Console.Write("even numbers are :");
				for(i=0;i<evenarr.Length;i++)
				{
					Console.WriteLine(evenarr[i]+" ");
				}
				Console.Write("odd numbers are :");
				for(i=0;i<oddarr.Length;i++)
				{
					Console.Write(oddarr[i]+" ");
				}
	}
}