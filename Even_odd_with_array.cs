using System;
class Even_odd_with_array
{
	public static void Main(string []args)
	{
		int []arr={10,15,20,21,27};
		int i=0;
		int even=0;
		int odd=0;
		int e=0;
		int o=0;
		while(i<arr.Length)
		{
			if(arr[i]%2==0)
			{
				even++;
			}
			else
			{
				odd++;
			}
			i++;	
		}
			
		int[]evenarr=new int[even];
		int[]oddarr=new int[odd];
		i=0;
		while(i<arr.Length)
		{
			if(arr[i]%2==0)
			{	evenarr[e]=arr[i];
				e++;
			}
			else 
			{				
			oddarr[o]=arr[i];
			o++;
			}
			i++;
		}
			Console.Write("even number are:");
			foreach(int evennum in evenarr)
			{
				Console.Write( "  "+evennum );
			}
			Console.WriteLine();
			Console.Write("odd number are:");
			foreach(int oddnum in oddarr)
			{
				Console.Write( "  "+oddnum );
			}
		
	}
}